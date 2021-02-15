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
    public partial class Cuenta : Form
    {
        SQLiteConn conn;
        Usuario user;

        public Cuenta(Usuario usuario)
        {
            InitializeComponent();
            conn = new SQLiteConn("DataBase.db", true);
            user = usuario;
            nombre.Text = usuario.FullName;
            direccion.Text = usuario.Address;
            correo.Text = usuario.Email;
            if (!usuario.Active) panel1.Hide();
        }

        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            Iniciar iniciar = new Iniciar();
            this.Close();
            iniciar.Show();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            conn.ExecuteNonQuery($"UPDATE Usuario SET active = 0 WHERE id = {user.Id}");
            this.Close();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Actualizar actualizar = new Actualizar(conn, user);
            this.Close();
            actualizar.Show();
        }
    }
}