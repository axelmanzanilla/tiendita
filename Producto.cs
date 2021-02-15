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
    public partial class Producto : Form
    {
        Tarjeta tarjet;
        SQLiteConn conn;
        Usuario user;

        public Producto(Usuario usuario, Tarjeta tarjeta)
        {
            InitializeComponent();
            user = usuario;
            conn = new SQLiteConn("DataBase.db", true);
            tarjet = tarjeta;

            pic_Product.BackgroundImage = Image.FromFile($"imagenes/{tarjeta.Id}.jpg");
            txt_Nombre.Text = $"{tarjet.Description}";
            txt_Precio.Text = $"{tarjet.Price:C}";
            txt_Restante.Text = $"{tarjet.Quan}";
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cmb_Cantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int restante = tarjet.Quan - Convert.ToInt32(cmb_Cantidad.Text);
            if(restante > 0)
            {
                txt_Restante.Text = $"{restante}";
                txt_Total.Text = $"{(Convert.ToInt32(cmb_Cantidad.Text) * tarjet.Price):C}";
            }
            else MessageBox.Show("La cantidad seleccionada es mayor que la disponible");
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            conn.ExecuteNonQuery($"INSERT INTO Carrito (id_user, id_producto, cantidad) " +
                                 $"VALUES ('{user.Id}', " +
                                 $"'{tarjet.Id}', " +
                                 $"{cmb_Cantidad.Text});");
            MessageBox.Show("Agregado al carrito!");
        }

        private void Producto_Load(object sender, EventArgs e)
        {

        }
    }
}