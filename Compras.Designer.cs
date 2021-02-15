namespace Tiendita
{
    partial class Compras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Comprar = new System.Windows.Forms.PictureBox();
            this.btn_Borrar = new System.Windows.Forms.PictureBox();
            this.text_Total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_carrito = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Comprar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Borrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_carrito)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbl_Nombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 945);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Comprar);
            this.panel2.Controls.Add(this.btn_Borrar);
            this.panel2.Controls.Add(this.text_Total);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.grid_carrito);
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1333, 457);
            this.panel2.TabIndex = 11;
            // 
            // btn_Comprar
            // 
            this.btn_Comprar.BackColor = System.Drawing.Color.Silver;
            this.btn_Comprar.BackgroundImage = global::Tiendita.Properties.Resources.payment;
            this.btn_Comprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Comprar.Location = new System.Drawing.Point(1193, 404);
            this.btn_Comprar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Comprar.Name = "btn_Comprar";
            this.btn_Comprar.Size = new System.Drawing.Size(53, 49);
            this.btn_Comprar.TabIndex = 13;
            this.btn_Comprar.TabStop = false;
            this.btn_Comprar.Click += new System.EventHandler(this.Btn_Comprar_Click);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.BackColor = System.Drawing.Color.Silver;
            this.btn_Borrar.BackgroundImage = global::Tiendita.Properties.Resources.trash;
            this.btn_Borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Borrar.Location = new System.Drawing.Point(1193, 4);
            this.btn_Borrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(53, 49);
            this.btn_Borrar.TabIndex = 9;
            this.btn_Borrar.TabStop = false;
            this.btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // text_Total
            // 
            this.text_Total.Location = new System.Drawing.Point(988, 420);
            this.text_Total.Margin = new System.Windows.Forms.Padding(4);
            this.text_Total.Name = "text_Total";
            this.text_Total.ReadOnly = true;
            this.text_Total.Size = new System.Drawing.Size(196, 22);
            this.text_Total.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(912, 415);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total";
            // 
            // grid_carrito
            // 
            this.grid_carrito.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grid_carrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_carrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.cantidad,
            this.precio,
            this.total});
            this.grid_carrito.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid_carrito.Location = new System.Drawing.Point(0, 0);
            this.grid_carrito.Margin = new System.Windows.Forms.Padding(4);
            this.grid_carrito.Name = "grid_carrito";
            this.grid_carrito.ReadOnly = true;
            this.grid_carrito.RowHeadersWidth = 51;
            this.grid_carrito.Size = new System.Drawing.Size(1333, 396);
            this.grid_carrito.TabIndex = 9;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 120;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 350;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 75;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 150;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 150;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(448, 25);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(138, 39);
            this.lbl_Nombre.TabIndex = 5;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Carrito de compras de";
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 945);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Comprar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Borrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_carrito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_Borrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_Total;
        private System.Windows.Forms.PictureBox btn_Comprar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grid_carrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}