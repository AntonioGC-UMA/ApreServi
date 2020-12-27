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
    public partial class ActividadNoInscrita : Form
    {
        ActividadBD curso;

        public ActividadNoInscrita(ActividadBD curso)
        {
            InitializeComponent();
            this.curso = curso;

            this.tDescripcion.Text = curso.descripcion;

            if (Usuario.hasInstance())
            {
                this.lUsuario.Text = Usuario.getInstance().usuario;

                bCerrarSesion.Visible = true;
                lUsuario.Visible = true;
                pImagen.Visible = true;
                bPerfil.Visible = true;
            }
            else
            {
                bIniciarSesion.Visible = true;
                bRegistrarse.Visible = true;
            }
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
            if (Usuario.hasInstance())
            {
                string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
                MySqlConnection connection = new MySqlConnection(MyConString);

                connection.Open();

                var sql = "insert into Matricula values ('" + Usuario.getInstance().usuario + "', " + curso.id + ")";

                var cmd = new MySqlCommand(sql, connection);

                cmd.ExecuteNonQuery();

                connection.Close();

                Actividad ventana = new Actividad(curso);
                ventana.MdiParent = this.MdiParent;
                this.Visible = false;
                ventana.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Necesita estar registrado para\npoder inscribirse en un curso");
            }
        }

        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            Usuario.cerrarSesion();
            this.Close();
        }
        private void bIniciarSesion_Click(object sender, EventArgs e)
        {
            InicioDeSesion ventana = new InicioDeSesion();
            ventana.MdiParent = this.MdiParent;
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bRegistrarse_Click(object sender, EventArgs e)
        {
            Registro ventana = new Registro();
            ventana.MdiParent = this.MdiParent;
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bActividades_Click(object sender, EventArgs e)
        {

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

        private void CursoNoInscrito_Load(object sender, EventArgs e)
        {

        }
    }
}
