using System.Collections.Immutable;
using WinFormsApp1.components;
using WinFormsApp1.helpers;
using WinFormsApp1.models;
using WinFormsApp1.stores;
using WinFormsApp1.windows;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private static readonly TimeSpan IntervaloCarrusel = TimeSpan.FromSeconds(5);
        private const string _carouselPath = "assets/images/carrusel";

        /// <summary>Corta el bucle infinito cuando la ventana se cierra.</summary>
        private readonly CancellationTokenSource _carruselCts = new();

        /// <summary>Imágenes ya decodificadas en memoria: el bucle solo intercambia referencias.</summary>
        private readonly List<Bitmap> _carruselImagenes = [];

        /// <summary>Índice actual del carrusel (-1 = aún no se ha mostrado ninguna).</summary>
        private int _carruselIndice = -1;
        private CartForm? cartForm = null;

        public Form1()
        {
            InitializeComponent();

            LoadCarruselImages();
            CarruselNext();
            ReloadCatalog(Stores.Products.Search(string.Empty));
            Stores.Cart.OnCountItemsChanged += (count, _) =>
            {
                _carritoBadge.Visible = count > 0;
                _carritoBadge.Text = count.ToString();
            };
            Stores.Cart.OnPurchase += () => ReloadCatalog(Stores.Products.Search(string.Empty));
                 
            _ = RotateCarrusel(_carruselCts.Token);

            Disposed += (_, _) =>
            {
                _carruselCts.Cancel();
                _carruselCts.Dispose();

                _carouselImage?.Image = null;
                foreach (Bitmap bitmap in _carruselImagenes)
                    bitmap.Dispose();

                _carruselImagenes.Clear();
                _carruselIndice = -1;
            };
        }


        private void LoadCarruselImages()
        {
            string carpeta = AssetPath.Resolve(_carouselPath);
            if (!Directory.Exists(carpeta))
                return;

            string[] patrones = { "*.png", "*.jpg", "*.jpeg", "*.gif" };

            IEnumerable<string> archivos = patrones
                .SelectMany(p => Directory.EnumerateFiles(carpeta, p, SearchOption.TopDirectoryOnly))
                .OrderBy(a => a, StringComparer.OrdinalIgnoreCase);

            foreach (string archivo in archivos)
            {
                Bitmap? imagen = DecodeImage(archivo);
                if (imagen is not null)
                    _carruselImagenes.Add(imagen);
            }
        }

        private static Bitmap? DecodeImage(string ruta)
        {
            try
            {
                using var stream = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using Image original = Image.FromStream(stream);
                return new Bitmap(original);
            }
            catch
            {
                return null;
            }
        }

        private void CarruselNext()
        {
            if (_carruselImagenes.Count == 0)
                return;

            _carruselIndice = (_carruselIndice + 1) % _carruselImagenes.Count;
            _carouselImage.Image = _carruselImagenes[_carruselIndice];
        }

        private async Task RotateCarrusel(CancellationToken token)
        {
            try
            {
                while (!token.IsCancellationRequested)
                {
                    // El hilo de UI queda libre mientras el runtime administra el temporizador.
                    await Task.Delay(IntervaloCarrusel, token);

                    if (token.IsCancellationRequested || IsDisposed || Disposing)
                        break;

                    CarruselNext();
                }
            }
            catch (OperationCanceledException) { }
        }

        private void ReloadCatalog(ImmutableList<Product> products)
        {
            catalogGridPanel.Controls.Clear();

            // Reinicia la estructura del grid
            catalogGridPanel.RowStyles.Clear();
            catalogGridPanel.RowCount = 0;
            catalogGridPanel.ColumnCount = 5;

            // 5 columnas con el mismo ancho
            catalogGridPanel.ColumnStyles.Clear();

            for (int column = 0; column < 5; column++)
            {
                catalogGridPanel.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 20F)
                );
            }

            for (int i = 0; i < products.Count; i++)
            {
                int column = i % 5;
                int row = i / 5;

                // Crear nueva fila cuando sea necesario
                if (row >= catalogGridPanel.RowCount)
                {
                    catalogGridPanel.RowCount++;

                    catalogGridPanel.RowStyles.Add(
                        new RowStyle(SizeType.Absolute, 440F)
                    );
                }

                ProductCard card = new()
                {
                    Dock = DockStyle.Fill,
                    Margin = new Padding(8),
                    Product = products[i]
                };
                card.AddToCartRequested += (productId) =>
                {
                    if(!Stores.Cart.Add(productId))
                    {
                        MessageBox.Show(
                            "Este producto ya esta en tu carrito.",
                            "Articulo en Carrito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }

                    MessageBox.Show("Producto agregado al carrito",
                        "Exito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                };
                catalogGridPanel.Controls.Add(card, column, row);
            }

        }

        private void SearchEvent(object sender, EventArgs e)
        {
            string searchTerm = _searchInput.Text.Trim();
            ReloadCatalog(Stores.Products.Search(searchTerm));
        }

        private void OpenCartForm(object sender, EventArgs e)
        {
            if(cartForm is null || cartForm.IsDisposed)
            {
                cartForm = new CartForm();
                cartForm.Show();
            }

            cartForm.BringToFront();
        }
    }
}
