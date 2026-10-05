using WinFormsApp1.components;
using WinFormsApp1.models;
using WinFormsApp1.stores;

namespace WinFormsApp1.windows
{
    public partial class CartForm : Form
    {
        /// <summary>Total real de la compra: es el valor que se le pasa a UserForm.</summary>
        private decimal _totalAPagar;

        public CartForm()
        {
            InitializeComponent();
            BuildCartItems(Stores.Cart.Saved);
            UpdateUI(Stores.Cart.Total);

            Stores.Cart.OnCountItemsChanged += OnCountItemsChanged;
            Stores.Cart.OnCartItemsChanged += BuildCartItems;

            Disposed += (_, _) =>
            {
                Stores.Cart.OnCartItemsChanged -= BuildCartItems;
                Stores.Cart.OnCountItemsChanged -= OnCountItemsChanged;
            };
        }

        private void BuyButtonClick(object? sender, EventArgs e)
        {
            using UserForm userForm = new(_totalAPagar);
            Close();

            userForm.ShowDialog();
        }

        private void OnCountItemsChanged(uint total, IReadOnlyList<CartSave> itemsIds)
        {
            UpdateUI(total);
            CalculateSubtotal(itemsIds);
        }

        private void BuildCartItems(IReadOnlyList<CartSave> itemsIds)
        {
            foreach (Control control in productsPanel.Controls)
                control.Dispose();
            productsPanel.Controls.Clear();

            foreach(CartSave itemSaved in itemsIds)
            {
                Product? product = Stores.Products.GetById(itemSaved.ProductId);
                if (product is null) continue;

                CartItem cartItem = new(
                    product,
                    itemSaved.Cantidad
                )
                {
                    Width = productsPanel.ClientSize.Width
                };
                cartItem.OnQuantityChanged += (newQuantity) => Stores.Cart.SetQuantity(product.Id, newQuantity);
                cartItem.OnRemove += () => Stores.Cart.Remove(product.Id);

                productsPanel.Controls.Add(cartItem);
            }

            CalculateSubtotal(itemsIds);
        }

        private void CalculateSubtotal(IReadOnlyList<CartSave> itemsIds)
        {
            decimal total = itemsIds.Sum(static saved =>
                {
                    Product? product = Stores.Products.GetById(saved.ProductId);
                    if (product is null) return 0.0m;

                    return Math.Round(product.PrecioFinal * saved.Cantidad, 2, MidpointRounding.AwayFromZero);
                }
            );

            totalLabel.Text = $"Subtotal ${total}";
            _totalAPagar = total;   // se guarda para pasárselo a UserForm
        }
        private void UpdateUI(uint total)
        {
            buyButton.Enabled = total > 0;
            productsCountLabel.Text = $"Productos: {total}";
        }
    }
}
