﻿using MySql.Data.MySqlClient;
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
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }
    }
}
