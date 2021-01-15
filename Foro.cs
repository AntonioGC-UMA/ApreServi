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

            foreach(var elem in BD.Select("select * from Post p where p.idForo = " + foro.id))
            {
                this.lPosts.Items.Add(new PostBD((int)elem[0], (string)elem[1], (string)elem[2]));
            }

            lableTitulo.Text = foro.nombre;

            foreach (var a in Usuario.get_eventos())
            {
                mCalendario.AddBoldedDate(a.dia);
            }
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
                var i = BD.Select("SELECT imagen FROM ImagenPerfil WHERE nombreUsuario = '" + Usuario.getInstance().usuario + "';");

                if (i.Count > 0)
                {
                    pImagen.Image = Noticias.GetImageFromByteArray((byte[])(i[0][0]));
                }
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
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bNoticias_Click(object sender, EventArgs e)
        {
            Noticias ventana = new Noticias();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
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
            Ayuda ventana = new Ayuda();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            if (tRespuesta.Text.Trim().Length == 0) return;


            String sql;
            if (Usuario.hasInstance())
            {
                sql = String.Format("insert into Post (autor,contenido,idForo) values ('{0}','{1}',{2})", Usuario.getInstance().usuario, tRespuesta.Text, foro.id);
            }
            else
            {
                sql = String.Format("insert into Post (autor,contenido,idForo) values ('Anónimo','{0}',{1})", tRespuesta.Text, foro.id);
            }

            BD.Insert(sql);

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

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            var lista = "";
            foreach (var a in Usuario.get_eventos())
            {
                if (e.Start == a.dia)
                    lista += a.descripcion + "\n";
            }
            if (lista != "")
                MessageBox.Show(lista);
        }
    }
}
