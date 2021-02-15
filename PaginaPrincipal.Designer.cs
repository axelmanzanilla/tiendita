namespace Tiendita
{
    partial class PaginaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Shop = new System.Windows.Forms.PictureBox();
            this.btn_Buscar = new System.Windows.Forms.PictureBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.slidebar = new System.Windows.Forms.Panel();
            this.btn_Contacto = new System.Windows.Forms.Label();
            this.categorias = new System.Windows.Forms.Panel();
            this.btn_video = new System.Windows.Forms.Label();
            this.btn_madre = new System.Windows.Forms.Label();
            this.btn_procesador = new System.Windows.Forms.Label();
            this.btn_categorias = new System.Windows.Forms.Label();
            this.btn_cuenta = new System.Windows.Forms.Label();
            this.btn_Inicio = new System.Windows.Forms.Label();
            this.pnl_Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Shop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            this.slidebar.SuspendLayout();
            this.categorias.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pic_logo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1800, 95);
            this.panel1.TabIndex = 0;
            // 
            // pic_logo
            // 
            this.pic_logo.BackgroundImage = global::Tiendita.Properties.Resources.header1;
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_logo.Location = new System.Drawing.Point(187, -4);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(213, 98);
            this.pic_logo.TabIndex = 0;
            this.pic_logo.TabStop = false;
            this.pic_logo.Click += new System.EventHandler(this.Pic_logo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btn_Shop);
            this.panel2.Controls.Add(this.btn_Buscar);
            this.panel2.Controls.Add(this.txt_Search);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1323, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 95);
            this.panel2.TabIndex = 6;
            // 
            // btn_Shop
            // 
            this.btn_Shop.BackgroundImage = global::Tiendita.Properties.Resources.shop;
            this.btn_Shop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Shop.Location = new System.Drawing.Point(415, 27);
            this.btn_Shop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Shop.Name = "btn_Shop";
            this.btn_Shop.Size = new System.Drawing.Size(47, 43);
            this.btn_Shop.TabIndex = 38;
            this.btn_Shop.TabStop = false;
            this.btn_Shop.Click += new System.EventHandler(this.Btn_Shop_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackgroundImage = global::Tiendita.Properties.Resources.search;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.Location = new System.Drawing.Point(345, 27);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(47, 43);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.TabStop = false;
            this.btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(0, 33);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(336, 22);
            this.txt_Search.TabIndex = 3;
            this.txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // btn_menu
            // 
            this.btn_menu.BackgroundImage = global::Tiendita.Properties.Resources.menu1;
            this.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_menu.Location = new System.Drawing.Point(16, 27);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(43, 34);
            this.btn_menu.TabIndex = 5;
            this.btn_menu.TabStop = false;
            this.btn_menu.Click += new System.EventHandler(this.Btn_menu_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(87, 27);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(81, 31);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Menú";
            // 
            // slidebar
            // 
            this.slidebar.BackColor = System.Drawing.Color.DimGray;
            this.slidebar.Controls.Add(this.btn_Contacto);
            this.slidebar.Controls.Add(this.categorias);
            this.slidebar.Controls.Add(this.btn_categorias);
            this.slidebar.Controls.Add(this.btn_cuenta);
            this.slidebar.Controls.Add(this.btn_Inicio);
            this.slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidebar.Location = new System.Drawing.Point(0, 95);
            this.slidebar.Margin = new System.Windows.Forms.Padding(4);
            this.slidebar.Name = "slidebar";
            this.slidebar.Size = new System.Drawing.Size(293, 802);
            this.slidebar.TabIndex = 1;
            // 
            // btn_Contacto
            // 
            this.btn_Contacto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Contacto.ForeColor = System.Drawing.Color.White;
            this.btn_Contacto.Location = new System.Drawing.Point(0, 165);
            this.btn_Contacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_Contacto.Name = "btn_Contacto";
            this.btn_Contacto.Size = new System.Drawing.Size(293, 55);
            this.btn_Contacto.TabIndex = 8;
            this.btn_Contacto.Text = "      Contacto";
            this.btn_Contacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Contacto.Click += new System.EventHandler(this.Btn_Contacto_Click);
            // 
            // categorias
            // 
            this.categorias.Controls.Add(this.btn_video);
            this.categorias.Controls.Add(this.btn_madre);
            this.categorias.Controls.Add(this.btn_procesador);
            this.categorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.categorias.Location = new System.Drawing.Point(0, 165);
            this.categorias.Margin = new System.Windows.Forms.Padding(4);
            this.categorias.Name = "categorias";
            this.categorias.Size = new System.Drawing.Size(293, 0);
            this.categorias.TabIndex = 7;
            // 
            // btn_video
            // 
            this.btn_video.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_video.ForeColor = System.Drawing.Color.White;
            this.btn_video.Location = new System.Drawing.Point(0, 86);
            this.btn_video.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_video.Name = "btn_video";
            this.btn_video.Size = new System.Drawing.Size(293, 43);
            this.btn_video.TabIndex = 2;
            this.btn_video.Text = "            Tarjetas de Video";
            this.btn_video.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_video.Click += new System.EventHandler(this.Btn_video_Click);
            // 
            // btn_madre
            // 
            this.btn_madre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_madre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_madre.ForeColor = System.Drawing.Color.White;
            this.btn_madre.Location = new System.Drawing.Point(0, 43);
            this.btn_madre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_madre.Name = "btn_madre";
            this.btn_madre.Size = new System.Drawing.Size(293, 43);
            this.btn_madre.TabIndex = 1;
            this.btn_madre.Text = "            Tarjetas Madre";
            this.btn_madre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_madre.Click += new System.EventHandler(this.Btn_madre_Click);
            // 
            // btn_procesador
            // 
            this.btn_procesador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_procesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procesador.ForeColor = System.Drawing.Color.White;
            this.btn_procesador.Location = new System.Drawing.Point(0, 0);
            this.btn_procesador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_procesador.Name = "btn_procesador";
            this.btn_procesador.Size = new System.Drawing.Size(293, 43);
            this.btn_procesador.TabIndex = 0;
            this.btn_procesador.Text = "            Procesadores";
            this.btn_procesador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_procesador.Click += new System.EventHandler(this.Btn_procesador_Click);
            // 
            // btn_categorias
            // 
            this.btn_categorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categorias.ForeColor = System.Drawing.Color.White;
            this.btn_categorias.Location = new System.Drawing.Point(0, 110);
            this.btn_categorias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_categorias.Name = "btn_categorias";
            this.btn_categorias.Size = new System.Drawing.Size(293, 55);
            this.btn_categorias.TabIndex = 5;
            this.btn_categorias.Text = "      Categorías";
            this.btn_categorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categorias.Click += new System.EventHandler(this.Btn_categorias_Click);
            // 
            // btn_cuenta
            // 
            this.btn_cuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cuenta.ForeColor = System.Drawing.Color.White;
            this.btn_cuenta.Location = new System.Drawing.Point(0, 55);
            this.btn_cuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_cuenta.Name = "btn_cuenta";
            this.btn_cuenta.Size = new System.Drawing.Size(293, 55);
            this.btn_cuenta.TabIndex = 4;
            this.btn_cuenta.Text = "      Mi Cuenta";
            this.btn_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cuenta.Click += new System.EventHandler(this.Btn_cuenta_Click);
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio.ForeColor = System.Drawing.Color.White;
            this.btn_Inicio.Location = new System.Drawing.Point(0, 0);
            this.btn_Inicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Size = new System.Drawing.Size(293, 55);
            this.btn_Inicio.TabIndex = 3;
            this.btn_Inicio.Text = "      Inicio";
            this.btn_Inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inicio.Click += new System.EventHandler(this.Btn_Inicio_Click);
            // 
            // pnl_Principal
            // 
            this.pnl_Principal.AutoScroll = true;
            this.pnl_Principal.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Principal.Location = new System.Drawing.Point(0, 0);
            this.pnl_Principal.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Principal.Name = "pnl_Principal";
            this.pnl_Principal.Size = new System.Drawing.Size(1507, 802);
            this.pnl_Principal.TabIndex = 0;
            this.pnl_Principal.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Principal_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnl_Principal);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(293, 95);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1507, 802);
            this.panel5.TabIndex = 2;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.slidebar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Booster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Shop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            this.slidebar.ResumeLayout(false);
            this.categorias.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel slidebar;
        private System.Windows.Forms.PictureBox btn_Buscar;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.PictureBox btn_menu;
        private System.Windows.Forms.Panel categorias;
        private System.Windows.Forms.Label btn_madre;
        private System.Windows.Forms.Label btn_procesador;
        private System.Windows.Forms.Label btn_categorias;
        private System.Windows.Forms.Label btn_cuenta;
        private System.Windows.Forms.Label btn_Inicio;
        private System.Windows.Forms.Label btn_Contacto;
        private System.Windows.Forms.Label btn_video;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel pnl_Principal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox btn_Shop;
        private System.Windows.Forms.PictureBox pic_logo;
    }
}

