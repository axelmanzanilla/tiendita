using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteDb;

namespace Tiendita
{
    public partial class PaginaPrincipal : Form
    {
        SQLiteConn conn;
        Usuario user;

        public PaginaPrincipal()
        {
            InitializeComponent();
            Cargar();
        }

        private void Btn_menu_Click(object sender, EventArgs e)
        {
            if (slidebar.Width == 220) slidebar.Width = 0;
            else if (slidebar.Width == 0) slidebar.Width = 220;
        }

        private void Btn_categorias_Click(object sender, EventArgs e)
        {
            if (categorias.Height == 105) categorias.Height = 0;
            else if (categorias.Height == 0) categorias.Height = 105;
        }

        private void Btn_cuenta_Click(object sender, EventArgs e)
        {
            Cargar();
            Loads(new Cuenta(user));
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            Loads(new Inicio(user));
        }

        private void Btn_Contacto_Click(object sender, EventArgs e)
        {
            Loads(new Contacto());
        }

        private void Btn_Shop_Click(object sender, EventArgs e)
        {

            Loads(new Compras(user));
        }

        private void Pic_logo_Click(object sender, EventArgs e)
        {
            Loads(new Inicio(user));
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            Loads(new Inicio(user));
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            this.pnl_Principal.Controls.Clear();

            List<Tarjeta> tarjetas = conn.GetTarjetas().FindAll(t => t.Description.Contains(txt_Search.Text));
            int num = tarjetas.Count;
            if (num > 15) num = 15;
            for (int i = 0; i < num; i++)
            {
                this.pnl_Principal.Controls.Add(AddImage(tarjetas[i].Id));
            }
        }

        private void Btn_procesador_Click(object sender, EventArgs e)
        {
            Categorias("PROCESADOR");
        }

        private void Btn_madre_Click(object sender, EventArgs e)
        {
            Categorias("TARJETA MADRE");
        }

        private void Btn_video_Click(object sender, EventArgs e)
        {
            Categorias("TARJETA DE VIDEO");
        }

        private void Loads(object hija)
        {
            if (this.pnl_Principal.Controls.Count > 0)
                this.pnl_Principal.Controls.RemoveAt(0);
            Form ventana = hija as Form;
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            this.pnl_Principal.Controls.Add(ventana);
            this.pnl_Principal.Tag = ventana;
            ventana.Show();
        }

        private void Cargar()
        {
            conn = new SQLiteConn("DataBase.db", true);
            if (conn.GetUsers().Exists(u => u.Active == true))
                user = conn.GetUsers().Find(u => u.Active == true);
            else user = conn.GetUsers()[0];
        }

        private PictureBox AddImage(string codigo)
        {
            PictureBox image = new PictureBox();

            image.BackgroundImage = Image.FromFile($"imagenes/{codigo}.jpg");
            image.Name = codigo;
            image.BackgroundImageLayout = ImageLayout.Stretch;
            image.Size = new Size(200, 150);
            image.Click += Pic_Product_Click;

            return image;
        }

        private void Pic_Product_Click(object sender, EventArgs e)
        {
            string codigo = (sender as PictureBox).Name;
            Producto producto = new Producto(user, conn.GetTarjeta(codigo));
            producto.Show();
        }

        private void Categorias(string categorie)
        {
            this.pnl_Principal.Controls.Clear();

            List<Tarjeta> tarjetas = conn.GetTarjetas().FindAll(t => t.Type == categorie);
            int num = tarjetas.Count;
            if (num > 15) num = 15;
            for (int i = 0; i < num; i++)
            {
                this.pnl_Principal.Controls.Add(AddImage(tarjetas[i].Id));
            }
        }

        private void Pnl_Principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}