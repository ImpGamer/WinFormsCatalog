using WinFormsApp1.models;

namespace WinFormsApp1.stores
{
    /// <summary>
    /// Punto único de acceso a los stores de la aplicación.
    /// Como son instancias únicas (singleton), todas las ventanas ven
    /// el mismo estado y pueden suscribirse a sus eventos.
    ///
    ///   Stores.Products.Changed  -> refrescar el grid/lista del catálogo
    ///   Stores.Cart.Changed      -> refrescar el contador del carrito
    /// </summary>
    public static class Stores
    {
        public static ProductStore Products { get; } = new(
            [
             new Product
            {
                Nombre = "Auriculares Bluetooth",
                Precio = 89.99m,
                Descuento = 20m,
                Ruta = "assets/images/placeholder.png",
                Stock = 0
            },
            new Product
            {
                Nombre = "Teclado Mecánico",
                Precio = 129.50m,
                Descuento = 15m,
                Ruta = "assets/images/placeholder.png",
                Stock = 23
            },
            new Product
            {
                Nombre = "Monitor 27'' QHD",
                Precio = 349.00m,
                Descuento = 0m,
                Ruta = "assets/images/placeholder.png",
                Stock = 25
            },
            new Product
            {
                Nombre = "Ratón Inalámbrico",
                Precio = 45.75m,
                Descuento = 35m,
                Ruta = "assets/images/placeholder.png",
                Stock = 13
            }
        ]);

        public static CartStore Cart { get; } = new();
    }
}
