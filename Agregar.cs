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
    public partial class Agregar : Form
    {
        SQLiteConn conn;
        Usuario user;

        public Agregar(Usuario usuario)
        {
            InitializeComponent();
            conn = new SQLiteConn("DataBase.db", true);
            user = usuario;
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            conn.ExecuteNonQuery($"INSERT INTO [Tarjetas] " +
                                 $"VALUES ('{Convert.ToInt32(conn.GetCreditCards()[conn.GetCreditCards().Count - 1].Id) + 1}', " +
                                 $"'{user.Id}', " +
                                 $"'{numero.Text}', " +
                                 $"{Mes.SelectedItem.ToString()}, " +
                                 $"{Year.SelectedItem.ToString()}, " +
                                 $"{cvv.Text});");
            MessageBox.Show("Tarjeta agregada correctamente!");
            this.Close();
        }
    }
}