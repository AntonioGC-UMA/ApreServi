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
    public partial class CrearNoticia : Form
    {
        NoticiaBD noticia;

        public CrearNoticia(NoticiaBD n)
        {
            InitializeComponent();

            noticia = n;

            if(noticia != null)
            {
                tCuerpo.Text = noticia.cuerpo;
                tTitular.Text = noticia.titulo;
                pImagen.Image = n.image;
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            if(tTitular.Text.Length == 0)
            {
                MessageBox.Show("El nombre del curso es obligatorio");
                return;
            }

            if(tCuerpo.Text.Length == 0)
            {
                MessageBox.Show("La descripción es obligatoria");
                return;
            }

            if(noticia != null)
            {
                var connection = BD.GetConnection();
                connection.Open();

                var cmd = new MySqlCommand("", connection);
                cmd.CommandText = String.Format("UPDATE Noticia SET titular = '{0}', cuerpo = '{1}', imagen = @userImage, fechaPublicacion = '{2}' WHERE id = '{3}';", tTitular.Text, tCuerpo.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), noticia.id);
                var userImage = BD.ImageToByteArray(pImagen.Image);
                var paramUserImage = new MySqlParameter("@userImage", MySqlDbType.Blob, userImage.Length);
                paramUserImage.Value = userImage;
                cmd.Parameters.Add(paramUserImage);

                cmd.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                BD.Insert(new NoticiaBD(-1, tCuerpo.Text, tTitular.Text, Usuario.getInstance().usuario, pImagen.Image, DateTime.Now));
            }
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pImagen.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}
