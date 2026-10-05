using WinFormsApp1.models;

namespace WinFormsApp1.stores
{
    /// <summary>
    /// Estado compartido del carrito.
    /// Mantiene dos eventos: <see cref="Changed"/> (cualquier mutación)
    /// y <see cref="ProductoAgregado"/> (para mostrar "toast"/contador).
    /// </summary>
    public sealed class CartStore
    {
        private readonly Dictionary<ulong, CartSave> cartItems = [];
        public IReadOnlyList<CartSave> Saved { get => cartItems.Values.ToList().AsReadOnly(); }

        public event Action<uint, IReadOnlyList<CartSave>>? OnCountItemsChanged;
        public event Action<IReadOnlyList<CartSave>>? OnCartItemsChanged;
        public event Action? OnPurchase;

        public uint Total { get => (uint)cartItems.Values.Sum(static item => item.Cantidad); }

        public bool Add(ulong productId)
        {
            if (cartItems.ContainsKey(productId))
                return false;

            cartItems.Add(productId, new CartSave(
                productId,
                1
            ));

            OnCartItemsChangedInvoke();
            OnCountItemsChangedInvoke();
            return true;
        }
        public bool Remove(ulong productId)
        {
            if (!cartItems.Remove(productId))
                return false;

            OnCartItemsChangedInvoke();
            OnCountItemsChangedInvoke();
            return true;
        }

        public void SetQuantity(ulong productId, uint quantity)
        {
            if (!cartItems.TryGetValue(productId, out CartSave? item))
                return;
            if (quantity == item.Cantidad) return;

            item.Cantidad = quantity;
            OnCountItemsChangedInvoke();
        }

        public void DoPurchase()
        {
            if (Saved.Count == 0) return;

            cartItems.Clear();
            OnCountItemsChangedInvoke();
            OnCartItemsChangedInvoke();
            OnPurchase?.Invoke();
        }

        private void OnCountItemsChangedInvoke() => OnCountItemsChanged?.Invoke
            (
                Total,
                cartItems.Values.ToList().AsReadOnly()
            );

        private void OnCartItemsChangedInvoke()
        {
            OnCartItemsChanged?.Invoke(Saved);
        }
    }
}
