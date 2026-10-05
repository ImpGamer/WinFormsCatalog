using WinFormsApp1.models;

namespace WinFormsApp1.stores
{
    public static class Stores
    {
        public static ProductStore Products { get; } = new(
            [
             new Product
            {
                Nombre = "Auriculares Bluetooth",
                Precio = 89.99m,
                Descuento = 20m,
                Ruta = "assets/images/products/auriculares.png",
                Stock = 0
            },
            new Product
            {
                Nombre = "Teclado Mecánico",
                Precio = 129.50m,
                Descuento = 15m,
                Ruta = "assets/images/products/teclado.png",
                Stock = 23
            },
            new Product
            {
                Nombre = "Monitor 27'' QHD",
                Precio = 349.00m,
                Descuento = 0m,
                Ruta = "assets/images/products/monitor.png",
                Stock = 25
            },
            new Product
            {
                Nombre = "Ratón Inalámbrico",
                Precio = 45.75m,
                Descuento = 35m,
                Ruta = "assets/images/products/raton.png",
                Stock = 13
            },
            new Product
            {
                Nombre = "Mando Inalámbrico",
                Precio = 69.99m,
                Descuento = 10m,
                Ruta = "assets/images/products/mando.png",
                Stock = 40
            },
            new Product
            {
                Nombre = "Laptop Gamer 15''",
                Precio = 1099.00m,
                Descuento = 12m,
                Ruta = "assets/images/products/laptop.png",
                Stock = 7
            },
            new Product
            {
                Nombre = "Altavoz Bluetooth",
                Precio = 59.99m,
                Descuento = 25m,
                Ruta = "assets/images/products/altavoz.png",
                Stock = 31
            },
            new Product
            {
                Nombre = "Micrófono de Streaming",
                Precio = 119.00m,
                Descuento = 0m,
                Ruta = "assets/images/products/microfono.png",
                Stock = 18
            },
            new Product
            {
                Nombre = "Webcam HD 1080p",
                Precio = 54.50m,
                Descuento = 15m,
                Ruta = "assets/images/products/webcam.png",
                Stock = 22
            },
            new Product
            {
                Nombre = "Smartwatch Deportivo",
                Precio = 149.99m,
                Descuento = 30m,
                Ruta = "assets/images/products/smartwatch.png",
                Stock = 15
            },
            new Product
            {
                Nombre = "Tablet 10''",
                Precio = 299.00m,
                Descuento = 8m,
                Ruta = "assets/images/products/tablet.png",
                Stock = 9
            },
            new Product
            {
                Nombre = "Disco Duro Externo 1TB",
                Precio = 84.00m,
                Descuento = 20m,
                Ruta = "assets/images/products/disco-duro.png",
                Stock = 27
            }
        ]);

        public static CartStore Cart { get; } = new();
    }
}
