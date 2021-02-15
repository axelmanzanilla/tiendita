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
    public partial class Actualizar : Form
    {
        SQLiteConn conn;
        Usuario user;

        public Actualizar(SQLiteConn con, Usuario usuario)
        {
            InitializeComponent();
            conn = con;
            user = usuario;

            nombre.Text = user.FName;
            apellido.Text = user.LName;
            correo.Text = user.Email;
            direccion.Text = user.Street;
            codigo.Text = $"{user.CP}";
            pass.Text = user.Password;
            repass.Text = user.Password;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (pass.Text == repass.Text)
            {
                conn.ExecuteNonQuery($"UPDATE Usuario SET " +
                                     $"fname = '{nombre.Text}', " +
                                     $"lname = '{apellido.Text}', " +
                                     $"correo = '{correo.Text}', " +
                                     $"contraseña = '{pass.Text}' " +
                                     $"WHERE id = '{user.Id}';");

                conn.ExecuteNonQuery($"UPDATE Direcciones SET " +
                                     $"direccion = '{direccion.Text}', " +
                                     $"codigopostal = {codigo.Text} " +
                                     $"WHERE id = {user.Id};");

                MessageBox.Show("Datos guardados con exito!");
            }
            else MessageBox.Show("Las contraseñas no coinciden");
        }
    }
}