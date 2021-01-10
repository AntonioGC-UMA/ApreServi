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
    public partial class Actividades : Form
    {
        public Actividades()
        {
            InitializeComponent();

            if (Usuario.hasInstance())
            {
                cargarActividades();

                var res = BD.Select("SELECT * FROM ONG WHERE nombreUsuario = '" + Usuario.getInstance().usuario + "'");

                if (res.Count != 0 || Usuario.getInstance().admin)
                {
                    bCrearActividad.Visible = true;
                    bEliminarActividad.Visible = true;
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
                cargarTodasLasActividades();

                bIniciarSesion.Visible = true;
                bRegistrarse.Visible = true;
            }

            foreach (var a in Usuario.get_eventos())
            {
                mCalendario.AddBoldedDate(a.dia);
            }
        }

        private void lMisActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            var actividad_seleccionada = (ActividadBD)lMisActividades.SelectedItem;

            if (actividad_seleccionada == null) return;

            Actividad ventana = new Actividad(actividad_seleccionada);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void lOtrasActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            var actividad_seleccionada = (ActividadBD)lOtrasActividades.SelectedItem;

            if (actividad_seleccionada == null) return;

            ActividadNoInscrita ventana = new ActividadNoInscrita(actividad_seleccionada);
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

        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            Usuario.cerrarSesion();
            this.Close();
        }

        private void cargarTodasLasActividades()
        {
            lMisActividades.Items.Clear();
            lOtrasActividades.Items.Clear();


            foreach (var elem in BD.Select("select * from Actividad"))
            {
                lOtrasActividades.Items.Add(new ActividadBD((int)elem[0], (string)elem[1], (string)elem[2], (DateTime)elem[3], (DateTime)elem[4]));
            }
        }

        private void cargarActividades()
        {
            lMisActividades.Items.Clear();
            lOtrasActividades.Items.Clear();
            this.lUsuario.Text = Usuario.getInstance().usuario;


            foreach (var elem in BD.Select("select * from Actividad a join Inscripcion i on a.id = i.idActividad where i.nombreUsuario = '" + Usuario.getInstance().usuario + "';"))
            {
                lMisActividades.Items.Add(new ActividadBD((int)elem[0], (string)elem[1], (string)elem[2], (DateTime)elem[3], (DateTime)elem[4]));
            }
            foreach (var elem in BD.Select("select * from Actividad where id not in (select a.id from Actividad a join Inscripcion i on a.id = i.idActividad where i.nombreUsuario = '" + Usuario.getInstance().usuario + "');"))
            {
                lOtrasActividades.Items.Add(new ActividadBD((int)elem[0], (string)elem[1], (string)elem[2], (DateTime)elem[3], (DateTime)elem[4]));
            }
        }

        private void bCrearActividad_Click(object sender, EventArgs e)
        {
            CrearActividad ventana = new CrearActividad();
            this.Visible = false;
            ventana.ShowDialog();
            cargarActividades();
            this.Visible = true;
        }

        private void bEliminarActividad_Click(object sender, EventArgs e)
        {
            if(lMisActividades.SelectedIndex != -1)
            {
                var actividad = (ActividadBD)lMisActividades.SelectedItem;

                BD.Delete("Actividad", actividad.id);

                cargarActividades();
            }

            if (lOtrasActividades.SelectedIndex != -1)
            {
                var actividad = (ActividadBD)lOtrasActividades.SelectedItem;

                BD.Delete("Actividad", actividad.id);

                cargarActividades();
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

        private void Actividades_Load(object sender, EventArgs e)
        {

        }

        private void mCalendario_DateChanged(object sender, DateRangeEventArgs e)
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
