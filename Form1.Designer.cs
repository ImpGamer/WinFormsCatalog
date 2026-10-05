namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Panel _topBar;
        private Label _titulo;

        private Panel _carrito;
        private Label _carritoIcono;
        private Label _carritoBadge;

        private Panel _carouselPanel;
        private PictureBox _carouselImage;

        private Panel _searchPanel;
        private TextBox _searchInput;
        private Button _searchButton;

        private TableLayoutPanel catalogGridPanel;
        private Panel catalogScrollPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            _topBar = new Panel();
            _carrito = new Panel();
            _carritoBadge = new Label();
            _carritoIcono = new Label();
            _titulo = new Label();
            _carouselPanel = new Panel();
            _carouselImage = new PictureBox();
            _searchPanel = new Panel();
            _searchButton = new Button();
            _searchInput = new TextBox();
            catalogGridPanel = new TableLayoutPanel();
            catalogScrollPanel = new Panel();
            _topBar.SuspendLayout();
            _carrito.SuspendLayout();
            _carouselPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_carouselImage).BeginInit();
            _searchPanel.SuspendLayout();
            catalogScrollPanel.SuspendLayout();
            SuspendLayout();
            // 
            // _topBar
            // 
            _topBar.BackColor = Color.FromArgb(255, 255, 128);
            _topBar.Controls.Add(_carrito);
            _topBar.Controls.Add(_titulo);
            _topBar.Dock = DockStyle.Top;
            _topBar.Location = new Point(0, 0);
            _topBar.Name = "_topBar";
            _topBar.Padding = new Padding(16, 0, 16, 0);
            _topBar.Size = new Size(904, 64);
            _topBar.TabIndex = 0;
            // 
            // _carrito
            // 
            _carrito.Controls.Add(_carritoBadge);
            _carrito.Controls.Add(_carritoIcono);
            _carrito.Cursor = Cursors.Hand;
            _carrito.Dock = DockStyle.Right;
            _carrito.Location = new Point(828, 0);
            _carrito.Name = "_carrito";
            _carrito.Size = new Size(60, 64);
            _carrito.TabIndex = 1;
            _carrito.Click += OpenCartForm;

            foreach (Control control in _carrito.Controls)
                control.Click += OpenCartForm;
            // 
            // _carritoBadge
            // 
            _carritoBadge.BackColor = Color.FromArgb(220, 38, 38);
            _carritoBadge.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            _carritoBadge.ForeColor = Color.White;
            _carritoBadge.Location = new Point(37, 6);
            _carritoBadge.Name = "_carritoBadge";
            _carritoBadge.Size = new Size(20, 20);
            _carritoBadge.TabIndex = 1;
            _carritoBadge.Text = "0";
            _carritoBadge.Visible = false;
            _carritoBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _carritoIcono
            // 
            _carritoIcono.Dock = DockStyle.Fill;
            _carritoIcono.Font = new Font("Segoe UI Symbol", 25F);
            _carritoIcono.ForeColor = Color.FromArgb(35, 35, 35);
            _carritoIcono.Location = new Point(0, 0);
            _carritoIcono.Name = "_carritoIcono";
            _carritoIcono.Size = new Size(60, 64);
            _carritoIcono.TabIndex = 0;
            _carritoIcono.Text = "\U0001f6d2";
            _carritoIcono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _titulo
            // 
            _titulo.Dock = DockStyle.Left;
            _titulo.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _titulo.ForeColor = Color.FromArgb(35, 35, 35);
            _titulo.Location = new Point(16, 0);
            _titulo.Name = "_titulo";
            _titulo.Size = new Size(200, 64);
            _titulo.TabIndex = 0;
            _titulo.Text = "Games Shop";
            _titulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _carouselPanel
            // 
            _carouselPanel.Controls.Add(_carouselImage);
            _carouselPanel.Dock = DockStyle.Top;
            _carouselPanel.Location = new Point(0, 64);
            _carouselPanel.Name = "_carouselPanel";
            _carouselPanel.Padding = new Padding(10);
            _carouselPanel.Size = new Size(904, 280);
            _carouselPanel.TabIndex = 1;
            // 
            // _carouselImage
            // 
            _carouselImage.Dock = DockStyle.Fill;
            _carouselImage.Location = new Point(10, 10);
            _carouselImage.Name = "_carouselImage";
            _carouselImage.Size = new Size(884, 160);
            _carouselImage.SizeMode = PictureBoxSizeMode.StretchImage;
            _carouselImage.TabIndex = 0;
            _carouselImage.TabStop = false;
            // 
            // _searchPanel
            // 
            _searchPanel.Controls.Add(_searchButton);
            _searchPanel.Controls.Add(_searchInput);
            _searchPanel.Dock = DockStyle.Top;
            _searchPanel.Location = new Point(0, 244);
            _searchPanel.Name = "_searchPanel";
            _searchPanel.Padding = new Padding(0, 10, 0, 10);
            _searchPanel.Size = new Size(904, 60);
            _searchPanel.TabIndex = 2;
            // 
            // _searchButton
            // 
            _searchButton.Anchor = AnchorStyles.Top;
            _searchButton.Font = new Font("Segoe UI Symbol", 11F);
            _searchButton.Location = new Point(597, 8);
            _searchButton.Name = "_searchButton";
            _searchButton.Size = new Size(35, 31);
            _searchButton.TabIndex = 1;
            _searchButton.Text = "🔍";
            _searchButton.UseVisualStyleBackColor = true;
            _searchButton.Click += SearchEvent;
            // 
            // _searchInput
            // 
            _searchInput.Anchor = AnchorStyles.Top;
            _searchInput.Font = new Font("Segoe UI", 11F);
            _searchInput.Location = new Point(272, 10);
            _searchInput.Name = "_searchInput";
            _searchInput.PlaceholderText = "Buscar productos...";
            _searchInput.Size = new Size(320, 27);
            _searchInput.TabIndex = 0;
            _searchInput.KeyUp += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter) SearchEvent(sender, e);
            };
            // 
            // catalogGridPanel
            // 
            catalogGridPanel.AutoSize = true;
            catalogGridPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            catalogGridPanel.ColumnCount = 2;
            catalogGridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            catalogGridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            catalogGridPanel.Dock = DockStyle.Top;
            catalogGridPanel.Location = new Point(10, 10);
            catalogGridPanel.Name = "catalogGridPanel";
            catalogGridPanel.Padding = new Padding(10);
            catalogGridPanel.RowCount = 2;
            catalogGridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            catalogGridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            catalogGridPanel.Size = new Size(880, 20);
            catalogGridPanel.TabIndex = 1;
            // 
            // catalogScrollPanel
            // 
            catalogScrollPanel.AutoScroll = true;
            catalogScrollPanel.BorderStyle = BorderStyle.Fixed3D;
            catalogScrollPanel.Controls.Add(catalogGridPanel);
            catalogScrollPanel.Dock = DockStyle.Fill;
            catalogScrollPanel.Location = new Point(0, 304);
            catalogScrollPanel.Name = "catalogScrollPanel";
            catalogScrollPanel.Padding = new Padding(10);
            catalogScrollPanel.Size = new Size(904, 234);
            catalogScrollPanel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 1020);
            Controls.Add(catalogScrollPanel);
            Controls.Add(_searchPanel);
            Controls.Add(_carouselPanel);
            Controls.Add(_topBar);
            Name = "Form1";
            Text = "Catálogo";
            _topBar.ResumeLayout(false);
            _carrito.ResumeLayout(false);
            _carouselPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_carouselImage).EndInit();
            _searchPanel.ResumeLayout(false);
            _searchPanel.PerformLayout();
            catalogScrollPanel.ResumeLayout(false);
            catalogScrollPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}