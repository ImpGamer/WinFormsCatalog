namespace WinFormsApp1.windows
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private Panel bottomPanel;

        private Label nombreLabel;
        private TextBox nombreInput;

        private Label telefonoLabel;
        private TextBox telefonoInput;

        private Label direccionLabel;
        private TextBox direccionInput;

        private Label totalAPagarLabel;
        private TextBox totalAPagarInput;

        private Label totalToPayLabel;
        private Button payButton;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; false otherwise.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            bottomPanel = new Panel();
            totalToPayLabel = new Label();
            payButton = new Button();

            nombreLabel = new Label();
            nombreInput = new TextBox();
            telefonoLabel = new Label();
            telefonoInput = new TextBox();
            direccionLabel = new Label();
            direccionInput = new TextBox();
            totalAPagarLabel = new Label();
            totalAPagarInput = new TextBox();

            SuspendLayout();

            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 32F)
            );
            mainLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 68F)
            );

            mainLayout.RowCount = 5;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            // Fila rellena: absorbe el espacio que sobra hasta la barra inferior.
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            mainLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Padding = new Padding(16, 18, 16, 8);

            // 
            // nombreLabel
            // 
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Text = "Nombre";
            nombreLabel.Dock = DockStyle.Fill;
            nombreLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            nombreLabel.TextAlign = ContentAlignment.MiddleLeft;
            nombreLabel.Padding = new Padding(0, 0, 12, 0);

            // 
            // nombreInput
            // 
            nombreInput.Name = "nombreInput";
            nombreInput.Dock = DockStyle.Fill;
            nombreInput.Font = new Font("Segoe UI", 10F);
            nombreInput.PlaceholderText = "Ingrese su nombre";

            // 
            // telefonoLabel
            // 
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Text = "Teléfono";
            telefonoLabel.Dock = DockStyle.Fill;
            telefonoLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            telefonoLabel.TextAlign = ContentAlignment.MiddleLeft;
            telefonoLabel.Padding = new Padding(0, 0, 12, 0);

            // 
            // telefonoInput
            // 
            telefonoInput.Name = "telefonoInput";
            telefonoInput.Dock = DockStyle.Fill;
            telefonoInput.Font = new Font("Segoe UI", 10F);
            telefonoInput.PlaceholderText = "Ej. 809-000-0000";

            // 
            // direccionLabel
            // 
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Text = "Dirección";
            direccionLabel.Dock = DockStyle.Fill;
            direccionLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            direccionLabel.TextAlign = ContentAlignment.MiddleLeft;
            direccionLabel.Padding = new Padding(0, 0, 12, 0);

            // 
            // direccionInput
            // 
            direccionInput.Name = "direccionInput";
            direccionInput.Dock = DockStyle.Fill;
            direccionInput.Font = new Font("Segoe UI", 10F);
            direccionInput.PlaceholderText = "Calle, número, ciudad";

            // 
            // totalAPagarLabel
            // 
            totalAPagarLabel.Name = "totalAPagarLabel";
            totalAPagarLabel.Text = "Total a pagar";
            totalAPagarLabel.Dock = DockStyle.Fill;
            totalAPagarLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            totalAPagarLabel.TextAlign = ContentAlignment.MiddleLeft;
            totalAPagarLabel.Padding = new Padding(0, 0, 12, 0);

            // 
            // totalAPagarInput
            // 
            totalAPagarInput.Name = "totalAPagarInput";
            totalAPagarInput.Dock = DockStyle.Fill;
            totalAPagarInput.Font = new Font("Segoe UI", 10F);
            totalAPagarInput.PlaceholderText = "0.00";

            // 
            // bottomPanel  (total a la izquierda + botón a la derecha)
            // 
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Height = 72;
            bottomPanel.Padding = new Padding(16, 10, 16, 12);
            bottomPanel.BackColor = Color.White;
            bottomPanel.Name = "bottomPanel";

            // 
            // totalToPayLabel  --> abajo a la izquierda (valor que pasa CartForm)
            // 
            totalToPayLabel.Text = "Total a pagar: $0.00";
            totalToPayLabel.Dock = DockStyle.Fill;
            totalToPayLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            totalToPayLabel.ForeColor = Color.FromArgb(35, 35, 35);
            totalToPayLabel.TextAlign = ContentAlignment.MiddleLeft;
            totalToPayLabel.Name = "totalToPayLabel";

            // 
            // payButton
            // 
            payButton.Dock = DockStyle.Right;
            payButton.Width = 170;
            payButton.Height = 45;
            payButton.Text = "Realizar pago";
            payButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            payButton.Name = "payButton";
            payButton.UseVisualStyleBackColor = true;
            payButton.Click += PayButtonClick;

            // 
            // mainLayout Controls (fila = label | textbox)
            // 
            mainLayout.Controls.Add(nombreLabel, 0, 0);
            mainLayout.Controls.Add(nombreInput, 1, 0);

            mainLayout.Controls.Add(telefonoLabel, 0, 1);
            mainLayout.Controls.Add(telefonoInput, 1, 1);

            mainLayout.Controls.Add(direccionLabel, 0, 2);
            mainLayout.Controls.Add(direccionInput, 1, 2);

            mainLayout.Controls.Add(totalAPagarLabel, 0, 3);
            mainLayout.Controls.Add(totalAPagarInput, 1, 3);

            // 
            // bottomPanel Controls
            //  (el último agregado se dibuja primero: payButton toma el borde
            //   derecho y totalToPayLabel rellena lo que queda a la izquierda)
            // 
            bottomPanel.Controls.Add(totalToPayLabel);
            bottomPanel.Controls.Add(payButton);

            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(540, 320);

            Controls.Add(mainLayout);
            Controls.Add(bottomPanel);

            AcceptButton = payButton;

            MinimumSize = new Size(500, 310);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos del usuario";
            ResumeLayout(false);
        }

        #endregion
    }
}
