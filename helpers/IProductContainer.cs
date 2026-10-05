using WinFormsApp1.models;

namespace WinFormsApp1.helpers
{
    internal interface IProductContainer
    {
        Product Product { get; set; }
        void RenderProduct();
    }
}
