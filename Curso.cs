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
    public partial class Curso : Form
    {
        CursoBD curso;

        public Curso(CursoBD curso)
        {
            InitializeComponent();

            this.curso = curso;
            this.lUsuario.Text = Usuario.getInstance().usuario;
            this.tDescripcion.Text = curso.descripcion;


            string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
            MySqlConnection connection = new MySqlConnection(MyConString);

            connection.Open();


            var sql = "select * from Foro f where f.idCurso = " + curso.id;

            var cmd = new MySqlCommand(sql, connection);


            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                this.lForos.Items.Add(new ForoBD((int)rdr[0], (string)rdr[1], (string)rdr[2]));
            }

            rdr.Close();
            connection.Close();
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

        private void bAbandonar_Click(object sender, EventArgs e)
        {
            string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
            MySqlConnection connection = new MySqlConnection(MyConString);

            connection.Open();

            var sql = "delete from Matricula m where m.nombreUsuario = '" + Usuario.getInstance().usuario + "' and m.idCurso = " + curso.id;

            var cmd = new MySqlCommand(sql, connection);

            cmd.ExecuteNonQuery();

            connection.Close();

            Cursos ventana = new Cursos();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void lForos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var foro_seleccionado = (ForoBD)lForos.SelectedItem;

            if (foro_seleccionado == null) return;

            Foro ventana = new Foro(foro_seleccionado);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            Usuario.cerrarSesion();
            this.Close();
        }
    }
}
