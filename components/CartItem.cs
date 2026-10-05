using System;
using System.ComponentModel;
using WinFormsApp1.helpers;
using WinFormsApp1.models;

namespace WinFormsApp1.components
{
    public partial class CartItem : UserControl, IProductContainer
    {
        public event Action<uint>? OnQuantityChanged;
        public event Action? OnRemove;

        public CartItem(Product product, uint quantity)
        {
            InitializeComponent();
            Product = product;
            Quantity = quantity;

            Disposed += (_, _) => OnQuantityChanged = null;
        }

        private Product _product = null!;

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

        private uint _quantity = 1U;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public uint Quantity
        {
            get => _quantity;
            set
            {
                uint max = Math.Max(1U, _product.Stock);
                _quantity = Math.Clamp(value, 1U, max);

                quantityLabel.Text = _quantity.ToString();
            }
        }

        public void RenderProduct()
        {
            if (_product is null) return;

            productImage.Image = _product.Imagen;
            productName.Text = _product.Nombre;
            finalPrice.Text = $"${_product.PrecioFinal:F2}";
            originalPrice.Text = $"${_product.Precio:F2}";
            discountLabel.Text = $"-{_product.Descuento}%";

            originalPrice.Visible = _product.TieneDescuento;
            discountLabel.Visible = _product.TieneDescuento;
        }
        private void OnRemoveButtonClick(object sender, EventArgs e) => OnRemove?.Invoke();

        private void DecreaseButtonClick(object sender, EventArgs e)
        {
            uint lastQuantity = Quantity;
            Quantity--;

            if (lastQuantity != Quantity) OnQuantityChanged?.Invoke(Quantity);
        }
        private void IncreaseButtonClick(object sender, EventArgs e)
        {
            uint lastQuantity = Quantity;
            Quantity++;

            if (lastQuantity != Quantity) OnQuantityChanged?.Invoke(Quantity);
        }
    }
}
