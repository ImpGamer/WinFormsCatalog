namespace WinFormsApp1.windows
{
    partial class CartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// private TableLayoutPanel mainLayout;
        private TableLayoutPanel mainLayout;
        private FlowLayoutPanel productsPanel;
        private TableLayoutPanel purchasePanel;

        private Label titleLabel;
        private Label productsCountLabel;
        private Label totalLabel;

        private Button buyButton;
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
            productsPanel = new FlowLayoutPanel();
            purchasePanel = new TableLayoutPanel();

            titleLabel = new Label();
            productsCountLabel = new Label();
            totalLabel = new Label();
            buyButton = new Button();

            SuspendLayout();

            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 70F)
            );
            mainLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 30F)
            );

            mainLayout.RowCount = 1;
            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F)
            );

            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Padding = new Padding(12);

            // 
            // productsPanel
            // 
            productsPanel.AutoScroll = true;
            productsPanel.Dock = DockStyle.Fill;
            productsPanel.FlowDirection = FlowDirection.TopDown;
            productsPanel.WrapContents = false;
            productsPanel.Padding = new Padding(8);

            // 
            // purchasePanel
            // 
            purchasePanel.ColumnCount = 1;
            purchasePanel.RowCount = 1;
            purchasePanel.Dock = DockStyle.Fill;
            purchasePanel.Padding = new Padding(16);

            purchasePanel.RowStyles.Add(
                new RowStyle(SizeType.AutoSize)
            );

            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            titleLabel.Text = "Datos de compra";

            // 
            // productsCountLabel
            // 
            productsCountLabel.AutoSize = true;
            productsCountLabel.Padding = new Padding(0, 16, 0, 0);
            productsCountLabel.Text = "Cantidad de productos: 0";

            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font(
                "Segoe UI",
                12F,
                FontStyle.Bold
            );
            totalLabel.Padding = new Padding(0, 8, 0, 16);
            totalLabel.Text = "Total: $0.00";

            // 
            // buyButton
            // 
            buyButton.Dock = DockStyle.Bottom;
            buyButton.Height = 45;
            buyButton.Text = "Realizar compra";
            buyButton.UseVisualStyleBackColor = true;
            buyButton.Click += BuyButtonClick;

            // 
            // purchasePanel Controls
            // 
            purchasePanel.Controls.Add(
                titleLabel,
                0,
                0
            );

            purchasePanel.Controls.Add(
                productsCountLabel,
                0,
                1
            );

            purchasePanel.Controls.Add(
                totalLabel,
                0,
                2
            );

            purchasePanel.Controls.Add(
                buyButton,
                0,
                3
            );

            // 
            // mainLayout Controls
            // 
            mainLayout.Controls.Add(
                productsPanel,
                0,
                0
            );

            mainLayout.Controls.Add(
                purchasePanel,
                1,
                0
            );

            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(900, 600);

            Controls.Add(mainLayout);

            MinimumSize = new Size(800, 500);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Carrito";
            ResumeLayout(false);
        }
        #endregion
    }
}