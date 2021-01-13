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

                var res = BD.Select("SELECT * FROM Profesor WHERE nombreUsuario = '" + Usuario.getInstance().usuario + "'");

                if (res.Count != 0 || Usuario.getInstance().admin)
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

            foreach (var a in Usuario.get_eventos())
            {
                mCalendario.AddBoldedDate(a.dia);
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

        private void cargarTodosLosCursos()
        {
            this.lUsuario.Text = "Anonimo";

            lMisCursos.Items.Clear();
            lOtrosCursos.Items.Clear();

            foreach(var elem in BD.Select("select * from Curso"))
            {
                lOtrosCursos.Items.Add(new CursoBD((int)elem[0], (string)elem[1], (string)elem[2], (DateTime)elem[3], (DateTime)elem[4], (string)elem[5]));
            }
        }

        private void cargarCursos()
        {
            lMisCursos.Items.Clear();
            lOtrosCursos.Items.Clear();

            var nombre = Usuario.getInstance().usuario;

            foreach (var elem in BD.Select("select * from Curso c WHERE c.id IN (SELECT idCurso from Matricula WHERE nombreUsuario = '" + nombre + "') OR c.propietario = 'nieto';"))
            {
                lMisCursos.Items.Add(new CursoBD((int)elem[0], (string)elem[1], (string)elem[2], (DateTime)elem[3], (DateTime)elem[4], (string)elem[5]));
            }
            foreach (var elem in BD.Select("select * from Curso c WHERE c.id NOT IN (SELECT idCurso from Matricula WHERE nombreUsuario = '" + nombre + "') AND c.propietario != '" + nombre + "';"))
            {
                lOtrosCursos.Items.Add(new CursoBD((int)elem[0], (string)elem[1], (string)elem[2], (DateTime)elem[3], (DateTime)elem[4], (string)elem[5]));
            }
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
            DialogResult result = MessageBox.Show("¿Seguro que quiere borrar el curso?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (lMisCursos.SelectedIndex != -1)
                {
                    var curso = (CursoBD)lMisCursos.SelectedItem;

                    BD.Delete("Curso", curso.id);

                    cargarCursos();
                }

                if (lOtrosCursos.SelectedIndex != -1)
                {
                    var curso = (CursoBD)lOtrosCursos.SelectedItem;

                    BD.Delete("Curso", curso.id);

                    cargarCursos();
                }
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
