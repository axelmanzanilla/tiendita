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
    public partial class Pagar : Form
    {
        SQLiteConn conn;
        Usuario user;
        public Pagar(Usuario usuario, decimal costo)
        {
            InitializeComponent();
            conn = new SQLiteConn("DataBase.db", true);
            user = usuario;
            if (conn.GetCreditCards().Exists(t => t.IdUser == user.Id))
            {
                tarjetas.DataSource = conn.GetCreditCardsById(user.Id);
                tarjetas.DisplayMember = "Number";
            }

            nombre.Text = user.FullName;
            direccion.Text = user.Address;
            importe.Text = $"{costo:C}";
            folio.Text = $"G{user.Id}-{user.CP}";
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar(user);
            agregar.Show();
        }

        private void Btn_Pagar_Click(object sender, EventArgs e)
        {
            if (check.Checked)
            {
                List<Carrito> carrito = conn.GetComprasById(user.Id);
                for(int i = 0; i < carrito.Count; i++)
                {
                    conn.ExecuteNonQuery($"UPDATE Productos SET " +
                                         $"cantidad = {conn.GetTarjeta(carrito[i].IdProducto).Quan - carrito[i].Cantidad}, " +
                                         $"WHERE id = '{carrito[i].IdProducto}';");
                }
                MessageBox.Show("Compra realizada correctamente!");
                this.Close();
            }
        }
    }
}
