using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ApreServi
{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }


        private void bIniciar_Click(object sender, EventArgs e)
        {
            var nombre = tUsuario.Text;
            var contraseña = tPassword.Text;

            if (nombre.Length == 0)
            {
                MessageBox.Show("El nombre de usuario es obligatorio");
                return;
            }
            if (contraseña.Length == 0)
            {
                MessageBox.Show("La contraseña es obligatoria");
                return;
            }

            var list = BD.Select("select * from Usuario where nombreUsuario = BINARY '" + nombre + "'");

            if (list.Count > 0)
            {
                var elem = list[0];
                if(((string)elem[2]).Equals(contraseña))
                {
                    var instance = Usuario.getInstance();
                    instance.usuario = (string)elem[0];
                    instance.correo = (string)elem[1];
                    instance.contraseña = (string)elem[2];
                    instance.nombre = (string)elem[3];
                    instance.apellido = (string)elem[4];
                    instance.rol = new Rol((string)elem[5]);

                    PantallaInicioSesionIniciada ventana = new PantallaInicioSesionIniciada();
                    this.Visible = false;
                    ventana.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("No existe ninguna cuenta con ese usuario");
            }            
        }

        private void bOlvido_Click(object sender, EventArgs e)
        {
            var nombre = tUsuario.Text;

            if (nombre.Length == 0)
            {
                MessageBox.Show("Introduce el nombre de usuario de la cuenta cuya contraseña qieres recuperar");
                return;
            }

            var list = BD.Select("select * from Usuario where nombreUsuario = '" + nombre + "'");

            if (list.Count > 0)
            {
                var elem = list[0];
                var correo = (string)elem[1];
                var contraseña = (string)elem[2];

                Correo.Enviar(correo, "Recuperar contraseña", "La contraseña es : " + contraseña);

                MessageBox.Show("Se ha enviado la contraseña a la cuenta de correo asociada");
            }
            else
            {
                MessageBox.Show("No existe ninguna cuenta con ese usuario");
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Enter)))
            {
                this.bIniciar_Click(sender,e);
            }
        }
    }
}
