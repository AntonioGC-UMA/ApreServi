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

            if(instance.admin)
            {
                lUsuarios.Visible = true;
                tBuscar.Visible = true;
                bEliminar.Visible = true;

                cargarIntegrantes("");
            }

            lUsuario.Text = instance.usuario;
            lNombre.Text = instance.nombre;
            lApellidos.Text = instance.apellido;
            lCorreo.Text = instance.correo;
        }

        private void bForos_Click(object sender, EventArgs e)
        {
            ForosGenerales ventana = new ForosGenerales();
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

            var instance = Usuario.getInstance();

            BD.Update("update Usuario set contraseña = '" + contraseña + "' where nombreUsuario = '" + instance.usuario + "'");

            instance.contraseña = contraseña;
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

        private void bMensajes_Click(object sender, EventArgs e)
        {
            Mensajes ventana = new Mensajes();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }



        private void cargarIntegrantes(string filtro)
        {
            lUsuarios.Items.Clear();
            string sql = "";

            sql = "SELECT * FROM Usuario where admin = 0 and nombreUsuario <> 'Anónimo'";

            if (filtro != "")
            {

                sql += "  AND nombreUsuario LIKE '" + filtro + "%';";
            }

            foreach (var persona in BD.Select(sql))
            {
                lUsuarios.Items.Add(new PersonaBD((string)persona[0], (string)persona[1], (string)persona[2], (string)persona[3], (string)persona[4], (SByte)persona[5] != 0));
            }
        }


        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (lUsuarios.SelectedIndex == -1) return;

            DialogResult result = MessageBox.Show("¿Seguro que quiere eliminar al usuario?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var persona = (PersonaBD)lUsuarios.Items[lUsuarios.SelectedIndex];

                BD.Delete("DELETE FROM Usuario WHERE nombreUsuario = '" + persona.usuario + "'");

                cargarIntegrantes(tBuscar.Text);
            }
        }

        private void tBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarIntegrantes(tBuscar.Text);
        }
    }
}
