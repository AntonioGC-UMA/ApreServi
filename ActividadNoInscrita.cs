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
        ActividadBD actividad;

        public ActividadNoInscrita(ActividadBD actividad)
        {
            InitializeComponent();
            this.actividad = actividad;

            this.tDescripcion.Text = actividad.descripcion;

            if (Usuario.hasInstance())
            {
                var i = BD.Select("SELECT imagen FROM ImagenPerfil WHERE nombreUsuario = '" + Usuario.getInstance().usuario + "';");

                if (i.Count > 0)
                {
                    pImagen.Image = Noticias.GetImageFromByteArray((byte[])(i[0][0]));
                }
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

            foreach (var a in Usuario.get_eventos())
            {
                mCalendario.AddBoldedDate(a.dia);
            }
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
            // TODO
        }

        private void bInscribirse_Click(object sender, EventArgs e)
        {
            if (Usuario.hasInstance())
            {
                BD.Insert("insert into Inscripcion (nombreUsuario, idActividad) values ('" + Usuario.getInstance().usuario + "', " + actividad.id + ")");

                Actividad ventana = new Actividad(actividad);
                this.Visible = false;
                ventana.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Necesita estar registrado para\npoder inscribirse en una actividad");
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

        private void bPerfil_Click(object sender, EventArgs e)
        {
            Perfil ventana = new Perfil();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
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
