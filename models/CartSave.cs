namespace WinFormsApp1.models
{
    /// <summary>Línea del carrito: un producto + su cantidad.</summary>
    public class CartSave(ulong productId, uint cantidad = 1)
    {
        public readonly ulong ProductId = productId;
        public uint Cantidad { get; set; } = cantidad;
    }
}
