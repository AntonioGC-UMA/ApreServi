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

            var i = BD.Select("SELECT imagen FROM ImagenPerfil WHERE nombreUsuario = '" + instance.usuario + "';");

            if(i.Count > 0)
            {
                pCara.Image = Noticias.GetImageFromByteArray((byte[])(i[0][0]));
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
            Noticias ventana = new Noticias();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
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
            Ayuda ventana = new Ayuda();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
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
            var contraseña2 = tContraseña2.Text;

            if (contraseña.Length == 0)
            {
                MessageBox.Show("La nueva contraseña no puede ser nula");
                return;
            }

            if (!contraseña.Equals(contraseña2))
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            var instance = Usuario.getInstance();

            BD.Update("update Usuario set contraseña = '" + contraseña + "' where nombreUsuario = '" + instance.usuario + "'");

            instance.contraseña = contraseña;

            MessageBox.Show("Se ha actualizado la contraseña de tu cuenta");
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

        private void bCambiarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pCara.Image = Image.FromFile(imagen);

                    var i = BD.Select("SELECT imagen FROM ImagenPerfil WHERE nombreUsuario = '" + Usuario.getInstance().usuario + "';");

                    if (i.Count > 0)
                    {
                        var connection = BD.GetConnection();
                        connection.Open();

                        var cmd = new MySqlCommand("", connection);
                        cmd.CommandText = "UPDATE ImagenPerfil SET imagen = @userImage WHERE nombreUsuario = '" + Usuario.getInstance().usuario + "';";
                        var userImage = BD.ImageToByteArray(pCara.Image);
                        var paramUserImage = new MySqlParameter("@userImage", MySqlDbType.Blob, userImage.Length);
                        paramUserImage.Value = userImage;
                        cmd.Parameters.Add(paramUserImage);

                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    else
                    {
                        var connection = BD.GetConnection();
                        connection.Open();

                        var cmd = new MySqlCommand("", connection);
                        cmd.CommandText = "INSERT INTO ImagenPerfil VALUES('" + Usuario.getInstance().usuario + "', @userImage);";
                        var userImage = BD.ImageToByteArray(pCara.Image);
                        var paramUserImage = new MySqlParameter("@userImage", MySqlDbType.Blob, userImage.Length);
                        paramUserImage.Value = userImage;
                        cmd.Parameters.Add(paramUserImage);

                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void tContraseña_MouseLeave(object sender, EventArgs e)
        {
            if(tContraseña.Text.Length == 0)
            {
                tContraseña.ForeColor = Color.Gray;
                tContraseña.Text = "Introduzca la nueva contraseña";
                tContraseña.UseSystemPasswordChar = false;
            }
        }

        private void tContraseña2_MouseLeave(object sender, EventArgs e)
        {
            if (tContraseña2.Text.Length == 0)
            {
                tContraseña2.ForeColor = Color.Gray;
                tContraseña2.Text = "Repita la nueva contraseña";
                tContraseña2.UseSystemPasswordChar = false;
            }
        }

        private void tContraseña2_MouseEnter(object sender, EventArgs e)
        {
            if ((tContraseña2.Text).Equals("Repita la nueva contraseña"))
            {
                tContraseña2.Text = "";
                tContraseña2.ForeColor = SystemColors.WindowText;
                tContraseña2.UseSystemPasswordChar = true;
            }
        }

        private void tContraseña_MouseEnter(object sender, EventArgs e)
        {   
            if((tContraseña.Text).Equals("Introduzca la nueva contraseña"))
            {
                tContraseña.Text = "";
                tContraseña.ForeColor = SystemColors.WindowText;
                tContraseña.UseSystemPasswordChar = true;
            }
        }
    }
}
