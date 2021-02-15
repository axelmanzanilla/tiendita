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
    public partial class Compras : Form
    {
        SQLiteConn conn;
        Usuario user;
        decimal Total = 0;

        public Compras(Usuario usuario)
        {
            InitializeComponent();
            conn = new SQLiteConn("DataBase.db", true);
            user = usuario;
            lbl_Nombre.Text = user.FName;
            if (conn.GetCompras().Exists(c => c.IdUser == user.Id))
            {
                List<Carrito> carrito = conn.GetComprasById(usuario.Id);

                for (int i = 0; i < carrito.Count; i++)
                {
                    int cantidad = carrito[i].Cantidad;
                    string code = conn.GetTarjeta(carrito[i].IdProducto).Id;
                    string name = conn.GetTarjeta(carrito[i].IdProducto).Description;
                    decimal precio = Convert.ToDecimal(conn.GetTarjeta(carrito[i].IdProducto).Price);
                    decimal total = cantidad * precio;
                    Total += total;
                    grid_carrito.Rows.Add(code, name, cantidad, precio, total);
                    grid_carrito.Rows[i].Tag = code;
                }
                text_Total.Text = $"{Total:C}";
            }
        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            if (grid_carrito.RowCount > 1)
            {
                string id = grid_carrito.CurrentRow.Tag.ToString();
                conn.ExecuteNonQuery($"DELETE FROM Carrito WHERE id_producto = {id}");
            }
            else MessageBox.Show("No quedan objetos!");
        }

        private void Btn_Comprar_Click(object sender, EventArgs e)
        {
            Pagar pagar = new Pagar(user, Total);
            pagar.Show();
        }
    }
}
