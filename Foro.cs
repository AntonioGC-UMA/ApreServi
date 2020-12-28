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
    public partial class Foro : Form
    {
        ForoBD foro;

        public void update()
        {
            lPosts.Items.Clear();
            tRespuesta.Text = "";

            MySqlConnection connection = BD.GetConnection();

            connection.Open();


            var sql = "select * from Post p where p.idForo = " + foro.id;

            var cmd = new MySqlCommand(sql, connection);


            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                this.lPosts.Items.Add(new PostBD((int)rdr[0], (string)rdr[1], (string)rdr[2]));
            }

            lableTitulo.Text = foro.nombre;

            rdr.Close();
            connection.Close();
        }

        public Foro(ForoBD foro)
        {
            InitializeComponent();

            this.foro = foro;

            if (Usuario.hasInstance())
            {
                this.lUsuario.Text = Usuario.getInstance().usuario;
                bCursos.Visible = true;
                lUsuario.Visible = true;
                bPerfil.Visible = true;
                pImagen.Visible = true;
                bCerrarSesion.Visible = true;
                bAtras.Visible = true;
            }
            else
            {
                bCerrar.Visible = true;
                bIniciarSesion.Visible = true;
                bRegistrarse.Visible = true;
            }

            update();
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

        private void bEnviar_Click(object sender, EventArgs e)
        {
            if (tRespuesta.Text.Trim().Length == 0) return;

            MySqlConnection connection = BD.GetConnection();

            connection.Open();
            String sql;
            if (Usuario.hasInstance())
            {
                sql = String.Format("insert into Post (autor,contenido,idForo) values ('{0}','{1}',{2})", Usuario.getInstance().usuario, tRespuesta.Text, foro.id);
            }
            else
            {
                sql = String.Format("insert into Post (autor,contenido,idForo) values ('Anónimo','{0}',{1})", tRespuesta.Text, foro.id);
            }

            var cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();

            connection.Close();

            update();
        }

        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            Usuario.cerrarSesion();
            this.Close();
        }

        private void bPerfil_Click(object sender, EventArgs e)
        {

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void bAtras_Click(object sender, EventArgs e)
        {
            ForosGenerales ventana = new ForosGenerales();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();

        }

        private void bAtrasCurso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bActividades_Click(object sender, EventArgs e)
        {
            Actividades ventana = new Actividades();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
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

        private void bPerfil_Click_1(object sender, EventArgs e)
        {
            Perfil ventana = new Perfil();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }
    }
}
