using System.Globalization;
using WinFormsApp1.components;
using WinFormsApp1.models;
using WinFormsApp1.stores;

namespace WinFormsApp1.windows
{
    /// <summary>
    /// Formulario de pago.
    /// Pide los datos del usuario (nombre, teléfono, dirección) y el monto
    /// que el cliente coloca para pagar. Abajo a la izquierda muestra el
    /// <b>total real</b> de la compra, valor que le pasa <see cref="CartForm"/>.
    /// </summary>
    public partial class UserForm : Form
    {
        /// <summary>Total real de la compra (viene de CartForm).</summary>
        private readonly decimal _totalAPagar;

        /// <summary>Constructor sin argumentos: lo necesita el diseñador de WinForms.</summary>
        public UserForm() : this(0m)
        {
        }

        /// <summary>
        /// Recibe el total a pagar calculado en CartForm
        /// (el mismo que se muestra en su etiqueta "Subtotal").
        /// </summary>
        public UserForm(decimal totalAPagar)
        {
            InitializeComponent();

            _totalAPagar = totalAPagar;
            totalToPayLabel.Text = $"Total a pagar: {_totalAPagar:C}";
        }

        private void PayButtonClick(object? sender, EventArgs e)
        {
            string nombre = nombreInput.Text.Trim();
            string telefono = telefonoInput.Text.Trim();
            string direccion = direccionInput.Text.Trim();

            if (string.IsNullOrEmpty(nombre) ||
                string.IsNullOrEmpty(telefono) ||
                string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show(
                    "Debe completar nombre, teléfono y dirección.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if(telefono.Length != 10)
            {
                MessageBox.Show(
                    "Telefono no valido. Deben ser 10 digitos.",
                    "Telefono no valido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!TryParseMonto(totalAPagarInput.Text, out decimal montoColocado))
            {
                MessageBox.Show(
                    "Ingrese un monto válido para pagar.",
                    "Monto inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (montoColocado < _totalAPagar)
            {
                MessageBox.Show(
                    "Monto insuficiente.\n\n" +
                    $"Total a pagar: {_totalAPagar:C}\n" +
                    $"Monto colocado: {montoColocado:C}",
                    "Monto insuficiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            foreach(var saved in Stores.Cart.Saved)
            {
                Product? product = Stores.Products.GetById(saved.ProductId);
                if (product is null) continue;

                product.Stock -= saved.Cantidad;
            }
            Stores.Cart.DoPurchase();

            MessageBox.Show(
                "La compra se realizó correctamente.\n\n" +
                $"Nombre: {nombre}\n" +
                $"Teléfono: {telefono}\n" +
                $"Dirección: {direccion}\n" +
                $"Monto colocado: {montoColocado:C}\n" +
                $"Total a pagar: {_totalAPagar:C}",
                "Compra realizada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (Modal)
                DialogResult = DialogResult.OK;
            else
                Close();
        }

        private static bool TryParseMonto(string texto, out decimal monto)
        {
            monto = 0m;

            if (string.IsNullOrWhiteSpace(texto))
                return false;

            string limpio = texto.Trim().Replace("$", string.Empty).Trim();

            bool valido =
                decimal.TryParse(limpio, NumberStyles.Number, CultureInfo.InvariantCulture, out monto) ||
                decimal.TryParse(limpio, NumberStyles.Number, CultureInfo.CurrentCulture, out monto);

            return valido && monto >= 0m;
        }
    }
}
