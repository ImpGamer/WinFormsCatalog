namespace WinFormsApp1.components
{
    partial class ProductCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben desecharse; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            cardPanel = new Panel();
            addToCartBtn = new Button();
            stockLabel = new Label();
            infoPanel = new Panel();
            pricePanel = new Panel();
            discountLabel = new Label();
            discountPrice = new Label();
            originalPrice = new Label();
            productName = new Label();
            image = new PictureBox();

            cardPanel.SuspendLayout();
            infoPanel.SuspendLayout();
            pricePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            SuspendLayout();

            // 
            // cardPanel
            // 
            cardPanel.BackColor = Color.White;
            cardPanel.BorderStyle = BorderStyle.FixedSingle;
            cardPanel.Controls.Add(addToCartBtn);
            cardPanel.Controls.Add(stockLabel);
            cardPanel.Controls.Add(infoPanel);
            cardPanel.Controls.Add(image);
            cardPanel.Dock = DockStyle.Fill;
            cardPanel.Location = new Point(0, 0);
            cardPanel.Name = "cardPanel";
            cardPanel.Padding = new Padding(1);
            cardPanel.Size = new Size(355, 441);
            cardPanel.TabIndex = 0;

            // 
            // addToCartBtn
            // 
            addToCartBtn.BackColor = Color.FromArgb(192, 0, 192);
            addToCartBtn.Cursor = Cursors.Hand;
            addToCartBtn.Dock = DockStyle.Bottom;
            addToCartBtn.FlatAppearance.BorderSize = 0;
            addToCartBtn.FlatStyle = FlatStyle.Flat;
            addToCartBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            addToCartBtn.ForeColor = Color.White;
            addToCartBtn.Location = new Point(1, 384);
            addToCartBtn.Name = "addToCartBtn";
            addToCartBtn.Size = new Size(351, 54);
            addToCartBtn.TabIndex = 2;
            addToCartBtn.Text = "Agregar al carrito";
            addToCartBtn.UseVisualStyleBackColor = false;
            addToCartBtn.Click += OnAddToCartClick;

            // 
            // stockLabel
            // 
            stockLabel.Dock = DockStyle.Bottom;
            stockLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            stockLabel.ForeColor = Color.FromArgb(100, 100, 100);
            stockLabel.Location = new Point(1, 364);
            stockLabel.Name = "stockLabel";
            stockLabel.Padding = new Padding(12, 0, 12, 0);
            stockLabel.Size = new Size(351, 20);
            stockLabel.TabIndex = 3;
            stockLabel.Text = "Disponibles: 10";
            stockLabel.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // infoPanel
            // 
            infoPanel.BackColor = Color.White;
            infoPanel.Controls.Add(pricePanel);
            infoPanel.Controls.Add(productName);
            infoPanel.Dock = DockStyle.Fill;
            infoPanel.Location = new Point(1, 211);
            infoPanel.Name = "infoPanel";
            infoPanel.Padding = new Padding(18, 15, 18, 12);
            infoPanel.Size = new Size(351, 227);
            infoPanel.TabIndex = 1;

            // 
            // pricePanel
            // 
            pricePanel.Controls.Add(discountLabel);
            pricePanel.Controls.Add(discountPrice);
            pricePanel.Controls.Add(originalPrice);
            pricePanel.Dock = DockStyle.Top;
            pricePanel.Location = new Point(18, 57);
            pricePanel.Name = "pricePanel";
            pricePanel.Size = new Size(315, 90);
            pricePanel.TabIndex = 1;

            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.BackColor = Color.FromArgb(220, 252, 231);
            discountLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            discountLabel.ForeColor = Color.FromArgb(22, 101, 52);
            discountLabel.Location = new Point(145, 39);
            discountLabel.Name = "discountLabel";
            discountLabel.Padding = new Padding(7, 3, 7, 3);
            discountLabel.Size = new Size(50, 21);
            discountLabel.TabIndex = 2;
            discountLabel.Text = "-20%";
            discountLabel.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // discountPrice
            // 
            discountPrice.AutoSize = true;
            discountPrice.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            discountPrice.ForeColor = Color.FromArgb(35, 35, 35);
            discountPrice.Location = new Point(45, 31);
            discountPrice.Name = "discountPrice";
            discountPrice.Size = new Size(105, 32);
            discountPrice.TabIndex = 1;
            discountPrice.Text = "$799.99";

            // 
            // originalPrice
            // 
            originalPrice.AutoSize = true;
            originalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Strikeout);
            originalPrice.ForeColor = Color.FromArgb(120, 120, 120);
            originalPrice.Location = new Point(45, 12);
            originalPrice.Name = "originalPrice";
            originalPrice.Size = new Size(46, 15);
            originalPrice.TabIndex = 0;
            originalPrice.Text = "$999.99";

            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Dock = DockStyle.Top;
            this.productName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            this.productName.ForeColor = Color.FromArgb(35, 35, 35);
            this.productName.MaximumSize = new Size(315, 0);
            this.productName.Name = "productName";
            this.productName.Padding = new Padding(0);
            this.productName.TabIndex = 0;
            this.productName.Text = "Nombre del producto";
            this.productName.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // image
            // 
            image.BackColor = Color.FromArgb(230, 230, 230);
            image.Dock = DockStyle.Top;
            image.Location = new Point(1, 1);
            image.Name = "image";
            image.Size = new Size(351, 210);
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.TabIndex = 0;
            image.TabStop = false;

            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(cardPanel);
            Name = "ProductCard";
            Size = new Size(355, 441);

            cardPanel.ResumeLayout(false);
            infoPanel.ResumeLayout(false);
            pricePanel.ResumeLayout(false);
            pricePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel cardPanel;
        private PictureBox image;

        private Panel infoPanel;
        private Label productName;

        private Panel pricePanel;
        private Label originalPrice;
        private Label discountPrice;
        private Label discountLabel;

        private Label stockLabel;
        private Button addToCartBtn;
    }
}