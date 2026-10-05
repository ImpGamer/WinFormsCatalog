using System.ComponentModel;
using WinFormsApp1.helpers;
using WinFormsApp1.models;

namespace WinFormsApp1.components
{
    /// <summary>
    /// Tarjeta reutilizable de producto.
    /// No conoce el carrito ni el catálogo: solo muestra un <see cref="Product"/>
    /// y avisa con <see cref="AddToCartRequested"/> cuando el usuario pulsa el botón.
    /// Quien lo contiene (la ventana) decide qué hacer con ese evento.
    /// </summary>
    public partial class ProductCard : UserControl, IProductContainer
    {
        private Product _product = null!;
        /// <summary>
        /// Se dispara cuando el usuario presiona el boton de agregar a carrito y pasa
        /// el <see cref="Product.Id"/> del producto aqui en la store
        /// </summary>
        public event Action<ulong>? AddToCartRequested;

        public ProductCard()
        {
            InitializeComponent();
            RenderProduct();

            Disposed += (_, _) =>
            {
                AddToCartRequested = null;

                image.Image = null;
            };
        }

        /// <summary>Producto que dibuja la tarjeta. Al asignarlo se repinta sola.</summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Product Product
        {
            get => _product;
            set
            {
                _product = value;
                RenderProduct();
            }
        }

        private void OnAddToCartClick(object sender, EventArgs e)
        {
            if (_product is null)
            {
                MessageBox.Show(
                    "No se puede agregar al carrito, no hay producto asignado a esta tarjeta.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            AddToCartRequested?.Invoke(_product.Id);
        }

        public void RenderProduct()
        {
            if (_product is null) return;

            productName.Text = _product.Nombre;
            discountPrice.Text = $"${_product.PrecioFinal}";
            originalPrice.Text = $"${_product.Precio}";
            discountLabel.Text = $"-{_product.Descuento}%";

            originalPrice.Visible = _product.TieneDescuento;
            discountLabel.Visible = _product.TieneDescuento;

            bool hasStock = _product.Stock > 0;
            Color labelColor = hasStock ? Color.FromArgb(100) : Color.Red;
            string text = hasStock ? $"Disponibles: {_product.Stock}" : "agotado".ToUpper();

            stockLabel.ForeColor = labelColor;
            stockLabel.Text = text;
            Enabled = hasStock;

            image.Image = _product.Imagen;
        }
    }
}
