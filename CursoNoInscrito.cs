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
    public partial class CursoNoInscrito : Form
    {

        CursoBD curso;

        public CursoNoInscrito(CursoBD curso)
        {
            InitializeComponent();
            this.curso = curso;

            this.lUsuario.Text = Usuario.getInstance().usuario;

            this.tDescripcion.Text = curso.descripcion;
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

        private void bInscribirse_Click(object sender, EventArgs e)
        {
            string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
            MySqlConnection connection = new MySqlConnection(MyConString);

            connection.Open();

            var sql = "insert into Matricula values ('" + Usuario.getInstance().usuario + "', " + curso.id + ")";

            var cmd = new MySqlCommand(sql, connection);

            cmd.ExecuteNonQuery();

            connection.Close();

            Curso ventana = new Curso(curso);
            ventana.MdiParent = this.MdiParent;
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            Usuario.cerrarSesion();
            this.Close();
        }

        private void bInscribirse_Click_1(object sender, EventArgs e)
        {

        }
    }
}
