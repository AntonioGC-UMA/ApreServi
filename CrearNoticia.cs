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
        public CrearNoticia()
        {
            InitializeComponent();
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

            BD.Insert(new NoticiaBD(-1, tCuerpo.Text, tTitular.Text, Usuario.getInstance().usuario, pImagen.Image, DateTime.Now));


           // BD.Insert(new CursoBD(-1, tNombreCurso.Text, tDescripcion.Text, dInicio.Value, dFin.Value, Usuario.getInstance().usuario));
            
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
