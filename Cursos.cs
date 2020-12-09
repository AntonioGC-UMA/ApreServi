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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();

            string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
            MySqlConnection connection = new MySqlConnection(MyConString);

            connection.Open();


            var sql = "select * from Curso c join Matricula m on c.id = m.idCurso where m.nombreUsuario = '" + Usuario.getInstance().usuario + "';";

            var cmd = new MySqlCommand(sql, connection);


            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                lMisCursos.Items.Add(new CursoBD((int)rdr[0], (string)rdr[1], (string)rdr[2]));
            }

            rdr.Close();
            
            sql = "select * from Curso c where c.id not in (select c.id from Curso c join Matricula m on c.id = m.idCurso where m.nombreUsuario = '" + Usuario.getInstance().usuario + "');";

            cmd = new MySqlCommand(sql, connection);

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                lOtrosCursos.Items.Add(new CursoBD((int)rdr[0], (string)rdr[1], (string)rdr[2]));
            }
            rdr.Close();
            

            connection.Close();
        }

        private void lMisCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curso_seleccionado = (CursoBD)lMisCursos.SelectedItem;

            Curso ventana = new Curso(curso_seleccionado);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void lOtrosCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curso_seleccionado = (CursoBD)lOtrosCursos.SelectedItem;

            CursoNoInscrito ventana = new CursoNoInscrito(curso_seleccionado);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
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
    }
}
