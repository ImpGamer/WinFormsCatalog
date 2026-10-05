namespace WinFormsApp1.components
{
    partial class CartItem
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel mainLayout;
        private PictureBox productImage;

        private Label productName;
        private Label finalPrice;
        private Label originalPrice;
        private Label discountLabel;

        private Button decreaseButton;
        private Label quantityLabel;
        private Button increaseButton;
        private Button removeButton;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();

            productImage = new PictureBox();

            productName = new Label();
            finalPrice = new Label();
            originalPrice = new Label();
            discountLabel = new Label();

            decreaseButton = new Button();
            quantityLabel = new Label();
            increaseButton = new Button();

            removeButton = new Button();

            SuspendLayout();

            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 3;
            mainLayout.RowCount = 3;

            mainLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 120F)
            );

            mainLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F)
            );

            mainLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 40F)
            );

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 40F)
            );

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 30F)
            );

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 30F)
            );

            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Padding = new Padding(8);

            // 
            // productImage
            // 
            productImage.Dock = DockStyle.Fill;
            productImage.SizeMode = PictureBoxSizeMode.Zoom;
            productImage.Margin = new Padding(4);

            mainLayout.Controls.Add(
                productImage,
                0,
                0
            );

            mainLayout.SetRowSpan(
                productImage,
                3
            );

            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Dock = DockStyle.Fill;
            productName.Text = "Nombre del producto";
            productName.TextAlign = ContentAlignment.MiddleLeft;
            productName.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Bold
            );

            mainLayout.Controls.Add(
                productName,
                1,
                0
            );

            // 
            // removeButton
            // 
            removeButton.Dock = DockStyle.None;
            removeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeButton.Size = new Size(30, 30);
            removeButton.Margin = new Padding(2);
            removeButton.Text = "×";
            removeButton.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += OnRemoveButtonClick;

            mainLayout.Controls.Add(
                removeButton,
                2,
                0
            );

            // 
            // finalPrice
            // 
            finalPrice.AutoSize = true;
            finalPrice.Text = "$0.00";
            finalPrice.TextAlign = ContentAlignment.MiddleLeft;
            finalPrice.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );

            // 
            // originalPrice
            // 
            originalPrice.AutoSize = true;
            originalPrice.Text = "$0.00";
            originalPrice.TextAlign = ContentAlignment.MiddleLeft;
            originalPrice.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Strikeout
            );

            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Text = "-0%";
            discountLabel.TextAlign = ContentAlignment.MiddleCenter;
            discountLabel.Margin = new Padding(8, 0, 0, 0);
            discountLabel.Padding = new Padding(5, 2, 5, 2);
            discountLabel.ForeColor = Color.FromArgb(22, 101, 52);
            discountLabel.BackColor = Color.FromArgb(220, 252, 231);

            // 
            // pricePanel
            // 
            var pricePanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false
            };

            pricePanel.Controls.Add(finalPrice);
            pricePanel.Controls.Add(originalPrice);
            pricePanel.Controls.Add(discountLabel);

            mainLayout.Controls.Add(
                pricePanel,
                1,
                1
            );

            // 
            // decreaseButton
            // 
            decreaseButton.Text = "-";
            decreaseButton.Width = 32;
            decreaseButton.Height = 28;
            decreaseButton.Margin = new Padding(0);
            decreaseButton.Click += DecreaseButtonClick;

            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = false;
            quantityLabel.Width = 40;
            quantityLabel.Height = 28;
            quantityLabel.Text = "1";
            quantityLabel.TextAlign = ContentAlignment.MiddleCenter;
            quantityLabel.Margin = new Padding(4, 0, 4, 0);

            // 
            // increaseButton
            // 
            increaseButton.Text = "+";
            increaseButton.Width = 32;
            increaseButton.Height = 28;
            increaseButton.Margin = new Padding(0);
            increaseButton.Click += IncreaseButtonClick;

            // 
            // quantityPanel
            // 
            var quantityPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false
            };

            quantityPanel.Controls.Add(decreaseButton);
            quantityPanel.Controls.Add(quantityLabel);
            quantityPanel.Controls.Add(increaseButton);

            mainLayout.Controls.Add(
                quantityPanel,
                1,
                2
            );

            // 
            // CartItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            BorderStyle = BorderStyle.FixedSingle;

            Controls.Add(mainLayout);

            Margin = new Padding(4);
            MinimumSize = new Size(400, 130);
            Size = new Size(500, 140);

            ResumeLayout(false);
        }

        #endregion
    }
}
