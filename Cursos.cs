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

            if (Usuario.hasInstance())
            {
                cargarCursos();

                if (Usuario.getInstance().rol.admin)
                {
                    bCrearCurso.Visible = true;
                    bEliminarCurso.Visible = true;
                }

                this.lUsuario.Text = Usuario.getInstance().usuario;
                bCursos.Visible = true;
                lUsuario.Visible = true;
                bPerfil.Visible = true;
                pImagen.Visible = true;
                bCerrarSesion.Visible = true;
            }
            else
            {
                cargarTodosLosCursos();

                bIniciarSesion.Visible = true;
                bRegistrarse.Visible = true;
            }
        }

        private void lMisCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curso_seleccionado = (CursoBD)lMisCursos.SelectedItem;

            if (curso_seleccionado == null) return;

            Curso ventana = new Curso(curso_seleccionado);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void lOtrosCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curso_seleccionado = (CursoBD)lOtrosCursos.SelectedItem;

            if (curso_seleccionado == null) return;

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

        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            Usuario.cerrarSesion();
            this.Close();
        }

        private void cargarTodosLosCursos()
        {
            this.lUsuario.Text = "Anonimo";

            lMisCursos.Items.Clear();
            lOtrosCursos.Items.Clear();
            string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
            MySqlConnection connection = new MySqlConnection(MyConString);

            connection.Open();

            var sql = "select * from Curso c";

            var cmd = new MySqlCommand(sql, connection);

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                lOtrosCursos.Items.Add(new CursoBD((int)rdr[0], (string)rdr[1], (string)rdr[2]));
            }
            rdr.Close();
            connection.Close();
        }

        private void cargarCursos()
        {
            lMisCursos.Items.Clear();
            lOtrosCursos.Items.Clear();
            MySqlConnection connection = BD.GetConnection();

            connection.Open();

            var sql = "select * from Curso c join Matricula m on c.id = m.idCurso where m.nombreUsuario = '" + Usuario.getInstance().usuario + "';";

            var cmd = new MySqlCommand(sql, connection);

            this.lUsuario.Text = Usuario.getInstance().usuario;

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

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            CrearCurso ventana = new CrearCurso();
            this.Visible = false;
            ventana.ShowDialog();
            cargarCursos();
            this.Visible = true;
        }

        private void bEliminarCurso_Click(object sender, EventArgs e)
        {
            if(lMisCursos.SelectedIndex != -1)
            {
                var curso = (CursoBD)lMisCursos.SelectedItem;

                MySqlConnection connection = BD.GetConnection();

                connection.Open();

                var sql = "delete from Curso where id =" + curso.id;

                var cmd = new MySqlCommand(sql, connection);

                cmd.ExecuteNonQuery();

                connection.Close();

                cargarCursos();
            }

            if (lOtrosCursos.SelectedIndex != -1)
            {
                var curso = (CursoBD)lOtrosCursos.SelectedItem;

                MySqlConnection connection = BD.GetConnection();

                connection.Open();

                var sql = "delete from Curso where id =" + curso.id;

                var cmd = new MySqlCommand(sql, connection);

                cmd.ExecuteNonQuery();

                connection.Close();

                cargarCursos();
            }
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

        private void bIniciarSesion_Click(object sender, EventArgs e)
        {
            InicioDeSesion ventana = new InicioDeSesion();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bRegistrarse_Click(object sender, EventArgs e)
        {
            Registro ventana = new Registro();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bActividades_Click(object sender, EventArgs e)
        {
            Actividades ventana = new Actividades();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bPerfil_Click(object sender, EventArgs e)
        {
            Perfil ventana = new Perfil();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }
    }
}
