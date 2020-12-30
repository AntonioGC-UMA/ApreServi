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
    public partial class CrearForo : Form
    {

        private int curso;
        private int actividad;
        public CrearForo()
        {
            InitializeComponent();
        }

        public CrearForo(int curso, int actividad)
        {
            InitializeComponent();
            this.curso = curso;
            this.actividad = actividad;
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            if (tNombreForo.Text.Length == 0)
            {
                MessageBox.Show("El nombre del foro es obligatorio");
                return;
            }
            if (tContenido.Text.Length == 0)
            {
                MessageBox.Show("El contenido del foro es obligatorio");
                return;
            }
            if (cCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Es necesario seleccionar una categoría");
                return;
            }

            BD.Insert(new ForoBD(-1, tNombreForo.Text, tContenido.Text, cCategoria.SelectedIndex, curso, actividad));
            this.Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tNombreForo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
