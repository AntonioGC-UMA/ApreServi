using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ApreServi
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();

            var instance = Usuario.getInstance();

            lUsuario.Text = instance.usuario;
            lNombre.Text = instance.nombre;
            lApellidos.Text = instance.apellido;
            lCorreo.Text = instance.correo;
        }

        private void bForos_Click(object sender, EventArgs e)
        {
            ForosGenerales ventana = new ForosGenerales();
            ventana.MdiParent = this.MdiParent;
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bNoticias_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void bCursos_Click(object sender, EventArgs e)
        {
            Cursos ventana = new Cursos();
            ventana.MdiParent = this.MdiParent;
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bAyuda_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            Usuario.cerrarSesion();
            this.Close();
        }


        private void bPerfil_Click(object sender, EventArgs e)
        {

        }

        private void bCambiarContraseña_Click(object sender, EventArgs e)
        {
            var contraseña = tContraseña.Text;


            if (contraseña.Length == 0)
            {
                MessageBox.Show("La nueva contraseña no puede ser nula");
                return;
            }

            MySqlConnection connection = BD.GetConnection();

            connection.Open();

            var instance = Usuario.getInstance();

            var sql = "update Usuario set contraseña = '" + contraseña + "' where nombreUsuario = '" + instance.usuario + "'";

            var cmd = new MySqlCommand(sql, connection);

            cmd.ExecuteNonQuery();

            instance.contraseña = contraseña;

            connection.Close();
        }

        private void pApreservi_Click(object sender, EventArgs e)
        {
            if (Usuario.hasInstance())
            {
                PantallaInicioSesionIniciada ventana = new PantallaInicioSesionIniciada();
                this.Visible = false;
                ventana.ShowDialog();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void bActividades_Click(object sender, EventArgs e)
        {
            Actividades ventana = new Actividades();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }
    }
}
