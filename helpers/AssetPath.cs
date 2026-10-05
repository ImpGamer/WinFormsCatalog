namespace WinFormsApp1.helpers
{
    /// <summary>
    /// Resuelve rutas de imágenes/videos guardadas en la carpeta assets.
    /// En desarrollo la ruta puede ser relativa al proyecto; en tiempo de
    /// ejecución hay que buscarla junto al .exe (AppContext.BaseDirectory),
    /// porque el Working Directory no siempre es la carpeta del programa.
    /// </summary>
    public static class AssetPath
    {
        /// <summary>Carpeta assets junto al ejecutable.</summary>
        public static string AssetsRoot => Path.Combine(AppContext.BaseDirectory, "assets");

        public static string ImagesRoot => Path.Combine(AssetsRoot, "images");

        public static string VideosRoot => Path.Combine(AssetsRoot, "videos");

        /// <summary>
        /// Convierte el path guardado en <see cref="models.Product.Imagen"/>
        /// en una ruta absoluta que .NET pueda abrir.
        /// </summary>
        public static string Resolve(string? path)
        {
            if (string.IsNullOrWhiteSpace(path))
                return string.Empty;

            if (Path.IsPathRooted(path))
                return Path.GetFullPath(path);

            string normalizada = path.Replace('/', Path.DirectorySeparatorChar)
                                     .Replace('\\', Path.DirectorySeparatorChar);

            return Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, normalizada));
        }
    }
}
