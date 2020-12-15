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
        public CrearForo()
        {
            InitializeComponent();
        }

        public CrearForo(int curso)
        {
            InitializeComponent();
            this.curso = curso;
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

            MySqlConnection connection = BD.GetConnection();
            connection.Open();
            String sql = null;

            if (curso == 0)
            {
                sql = String.Format("insert into Foro (nombre, descripcion, categoria) values ('{0}','{1}','{2}')", tNombreForo.Text, tContenido.Text, cCategoria.SelectedItem.ToString());
            }
            else
            {
                sql = String.Format("insert into Foro (nombre, descripcion, categoria, idCurso) values ('{0}','{1}','{2}', {3})", tNombreForo.Text, tContenido.Text, cCategoria.SelectedItem.ToString(), curso);
            }
            
            var cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
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
