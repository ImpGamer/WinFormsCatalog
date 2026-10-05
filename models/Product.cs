using WinFormsApp1.helpers;

namespace WinFormsApp1.models
{
    /// <summary>
    /// Estructura de datos de un producto del catálogo.
    /// Solo guarda estado y valores derivados: la lógica de negocio
    /// vive en <see cref="services.PricingService"/> y <see cref="services.ProductService"/>.
    /// </summary>
    public class Product
    {
        private static ulong _nextId = 0;

        public ulong Id { get; } = ++_nextId;
        /// <summary>Nombre visible del producto.</summary>
        public string Nombre { get; set; } = string.Empty;

        /// <summary>Precio de lista, antes de aplicar el descuento.</summary>
        public decimal Precio { get; set; }

        private decimal _descuento;

        /// <summary>Descuento como valor porcentual entre 0 y 100 (ej. 20 = 20%).</summary>
        public decimal Descuento
        {
            get => _descuento;
            set => _descuento = Math.Clamp(value, 0m, 100m);
        }

        private uint _stock = 0;
        public uint Stock {
            get => _stock;
            set => _stock = Math.Max(0, value);
        }

        /// <summary>
        /// Ruta de la imagen. Acepta rutas relativas al ejecutable
        /// (ej. "assets/images/tv.png") o rutas absolutas.
        /// </summary>
        public string Ruta
        {
            get;
            set
            {
                Imagen?.Dispose();
                Imagen = null;

                string path = AssetPath.Resolve(value);
                if (!File.Exists(path))
                {
                    Imagen = null;
                    return;
                }

                try
                {
                    using var img = Image.FromFile(path);
                    Imagen = new Bitmap(img);
                }
                catch { Imagen = null; }
            }
        } = string.Empty;

        public Image? Imagen
        {
            get;
            private set;
        }

        /// <summary>Precio final = precio - descuento%.</summary>
        public decimal PrecioFinal
        {
            get
            {
                if (!TieneDescuento) return Precio;
                decimal resta = Precio * Descuento / 100m;
                return Math.Round(Precio - resta, 2, MidpointRounding.AwayFromZero);
            }
        }

        /// <summary>Dinero que ahorra el cliente con el descuento.</summary>
        public decimal Ahorro => Math.Round(Precio - PrecioFinal, 2);

        /// <summary>True si el producto tiene un descuento activo.</summary>
        public bool TieneDescuento => Descuento > 0m;

        public override string ToString() =>
            $"{Nombre} | {Precio:C} -> {PrecioFinal:C} ({(TieneDescuento ? $"-{Descuento:0.#}%" : "sin descuento")})";
    }
}
