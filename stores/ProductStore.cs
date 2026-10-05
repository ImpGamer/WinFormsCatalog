using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Text.RegularExpressions;
using WinFormsApp1.models;

namespace WinFormsApp1.stores
{
    /// <summary>
    /// Estado compartido del catálogo (fuente de verdad única).
    /// Las ventanas NO se pasan datos entre sí: leen de aquí y se
    /// suscriben a <see cref="Changed"/> para refrescarse.
    /// </summary>
    public sealed class ProductStore(List<Product> products)
    {
        private readonly FrozenDictionary<ulong, Product> _productsDic = products.ToDictionary(p => p.Id).ToFrozenDictionary();

        public ImmutableList<Product> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return [.. _productsDic.Values];

            string pattern = Regex.Escape(query.Trim());

            return [.. _productsDic.Values
            .Where(product =>
                Regex.IsMatch(
                    product.Nombre,
                    pattern,
                    RegexOptions.IgnoreCase
                ))];
        }
        public Product? GetById(ulong id)
        {
            _productsDic.TryGetValue(id, out Product? product);
            return product;
        }
    }
}
