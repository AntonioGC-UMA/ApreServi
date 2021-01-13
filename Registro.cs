using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace ApreServi
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            var nombreUsuario = tNombreUsuario.Text;
            var nombre = tNombre.Text;
            var apellido = tApellidos.Text;
            var correo = tCorreo.Text;
            var contraseña = tPassword.Text;
            var contraseña2 = tConfirmPassword.Text;

            if(nombreUsuario.Length == 0)
            {
                MessageBox.Show("El nombre de usuario es obligatorio");
                return;
            }
            if(nombre.Length == 0)
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }
            if(apellido.Length == 0)
            {
                MessageBox.Show("El apellido es obligatorio");
                return;
            }
            if(correo.Length == 0)
            {
                MessageBox.Show("El correo es obligatorio");
                return;
            }
            if(contraseña.Length == 0)
            {
                MessageBox.Show("La contraseña es obligatoria");
                return;
            }

            if (!contraseña.Equals(contraseña2))
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            if (BD.Select("select * from Usuario where nombreUsuario = '" + nombre + "'").Count > 0)
            {
                MessageBox.Show("Ya existe una cuenta con ese nombre de usuario");
                return;
            }

            try
            {
                var a = new MailAddress(correo, "To User");
            }
            catch (Exception ex) {
                MessageBox.Show("El correo no es válido");
                return;
            }

            var instance = Usuario.getInstance();
            instance.usuario = nombreUsuario;
            instance.correo = correo;
            instance.contraseña = contraseña;
            instance.nombre = nombre;
            instance.apellido = apellido;
                        
            BD.Insert(instance);

            if (cbRol.SelectedIndex == 1) BD.Insert("INSERT INTO Profesor (nombreUsuario) VALUES( '" + nombreUsuario + "')");
            if (cbRol.SelectedIndex == 2) BD.Insert("INSERT INTO ONG (nombreUsuario) VALUES( '" + nombreUsuario + "')");

            PantallaInicioSesionIniciada ventana = new PantallaInicioSesionIniciada();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
