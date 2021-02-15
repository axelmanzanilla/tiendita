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
    public partial class Inicio : Form
    {
        SQLiteConn conn;
        Usuario user;
        public int numProductos = 25;
        List<Tarjeta> tarjetas = new List<Tarjeta>();

        public Inicio(Usuario usuario)
        {
            user = usuario;
            conn = new SQLiteConn("DataBase.db", true);
            tarjetas = conn.GetTarjetas();

            InitializeComponent();
            List<PictureBox> images = new List<PictureBox>();

            for(int i = 0; i < numProductos; i++)
            {
                this.pnl_Inicio.Controls.Add(AddImage(i));
            }
        }

        private PictureBox AddImage(int i)
        {
            PictureBox image = new PictureBox();
            string codigo = $"{123456 + i}";

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
    }
}
