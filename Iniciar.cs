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
    public partial class Iniciar : Form
    {
        SQLiteConn conn = new SQLiteConn("DataBase.db", true);
        public Iniciar()
        {
            InitializeComponent();
            List<Usuario> usuarios = conn.GetUsers();
        }

        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            Usuario user = null;
            bool pass = false;

            if (txtUsuario.Text != "" && txtPass.Text != "") //Comprobar que no esté vacio
            {
                if (conn.GetUsers().Exists(u => u.Email == txtUsuario.Text))
                {//Comprobar si el usuario existe
                    user = conn.GetUsers().Find(u => u.Email == txtUsuario.Text);
                    if (user.Password == txtPass.Text) pass = true;
                    else MessageBox.Show("Contraseña incorrecta!");
                }
                else if (conn.GetUsers().Exists(u => u.Email == txtUsuario.Text))
                {//Comprobar si el correo existe
                    user = conn.GetUsers().Find(u => u.Email == txtUsuario.Text);
                    if (user.Password == txtPass.Text) pass = true;
                    else MessageBox.Show("Contraseña incorrecta!");
                }
                else MessageBox.Show("El usuario ingresado no existe!");
            }
            else MessageBox.Show("Ingrese todos los datos!");

            if (pass)
            {
                this.Close();
                conn.ExecuteNonQuery($"UPDATE Usuario SET active = 1 WHERE id = {user.Id}");
            }
        }

        private void Lbl_Registrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id = Convert.ToInt32(conn.GetUsers()[conn.GetUsers().Count - 1].Id) + 1;
            if (!conn.GetUsers().Exists(u => u.Email == txtUsuario.Text))
            {
                conn.ExecuteNonQuery($"INSERT INTO Usuario (id, fname, lname, correo, contraseña, estado, active) " +
                                                        $"VALUES ('{id}', " +
                                                        $"'{txtUsuario.Text}', " +
                                                        $"'user', " +
                                                        $"'{txtUsuario.Text}', " +
                                                        $"'{txtPass.Text}', " +
                                                        $"0, 1);");
                conn.ExecuteNonQuery($"INSERT INTO Direcciones (id, direccion, codigopostal) " +
                                     $"VALUES ({id}, " +
                                     $"'default', " +
                                     $"10000);");

                MessageBox.Show("Usuario registrado con Éxito!");
                this.Close();
            }
            else MessageBox.Show("Ya hay un usuario registrado con ese correo!");
        }
    }
}