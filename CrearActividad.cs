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
    public partial class CrearActividad : Form
    {
        public CrearActividad()
        {
            InitializeComponent();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            if(tNombreCurso.Text.Length == 0)
            {
                MessageBox.Show("El nombre del curso es obligatorio");
                return;
            }

            if(tDescripcion.Text.Length == 0)
            {
                MessageBox.Show("La descripción es obligatoria");
                return;
            }

            if(dInicio.Value > dFin.Value)
            {
                MessageBox.Show("El curso no puede tener duración negativa");
                return;
            }

            if(dInicio.Value < System.DateTime.Now || dFin.Value < System.DateTime.Now)
            {
                MessageBox.Show("No puedes iniciar un curso en el pasado");
                return;
            }

            string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
            MySqlConnection connection = new MySqlConnection(MyConString);

            connection.Open();

            var sql = String.Format("insert into Curso (nombre,descripcion,fechaInicio,fechaFin) values ('{0}','{1}','{2}','{3}')", tNombreCurso.Text, tDescripcion.Text, dInicio.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"), dFin.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            var cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            
            connection.Close();

            this.Close();
        }

        private void CrearCurso_Load(object sender, EventArgs e)
        {

        }

        private void tNombreCurso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
