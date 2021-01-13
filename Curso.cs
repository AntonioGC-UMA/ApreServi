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

            var lista = BD.Select("select * from Curso c where c.propietario ='" + Usuario.getInstance().usuario + "' and c.id =" + curso.id);

            if (lista.Count > 0 || Usuario.getInstance().admin)
            {
                bAñadirTest.Visible = true;
                bBorrarTest.Visible = true;
                bGuardar.Visible = true;
                bAbandonar.Visible = false;

                bAñadirForo.Visible = true;
                bBorrarForo.Visible = true;

                tDescripcion.ReadOnly = false;
                bIntegrantes.Visible = true;
            }

            cargarForos();
            cargarTests();

            foreach (var a in Usuario.get_eventos())
            {
                mCalendario.AddBoldedDate(a.dia);
            }
        }

        private void cargarForos()
        {
            lForos.Items.Clear();

            var list = BD.Select("select * from Foro f where f.idCurso = " + curso.id);


            foreach(var elm in list)
            {
                lForos.Items.Add(new ForoBD((int)elm[0], (string)elm[1], (string)elm[2], (int)elm[3], elm[4] == System.DBNull.Value ? 0 : (int)elm[4], elm[5] == System.DBNull.Value ? 0 : (int)elm[5]));
            }
        }

        private void cargarTests()
        {
            lTest.Items.Clear();

            var list = BD.Select("select * from Test t where t.idCurso = " + curso.id);

            foreach (var elm in list)
            {
                var preguntas = new List<PreguntaBD>();
                foreach(var p in BD.Select("select * from Pregunta p where p.idTest = " + (int)elm[0]))
                {
                    var opciones = new List<string>();
                    foreach (var o in BD.Select("select * from Opcion o where o.numPregunta = " + (int)p[0]))
                        opciones.Add((string)o[3]);

                    preguntas.Add(new PreguntaBD((int)p[0], (int)p[1], (string)p[2], opciones, (int)p[3]));
                }

                lTest.Items.Add(new TestBD((int)elm[0], curso.id, (string)elm[2], preguntas));
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

        private void bAbandonar_Click(object sender, EventArgs e)
        {
            BD.Delete("delete from Matricula m where m.nombreUsuario = '" + Usuario.getInstance().usuario + "' and m.idCurso = " + curso.id);

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
            if (!Usuario.hasInstance())
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
            }
        }

        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            Usuario.cerrarSesion();
            this.Close();
        }

        private void bAñadir_Click(object sender, EventArgs e)
        {
            CrearTest ventana = new CrearTest(curso);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;

            cargarTests();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            BD.Update("update Curso set descripcion ='" + tDescripcion.Text + "' where id =" + curso.id);
        }

        private void bAñadirForo_Click(object sender, EventArgs e)
        {
            CrearForo ventana = new CrearForo(curso.id, 0);
            this.Visible = false;
            ventana.ShowDialog();
            cargarForos();
            this.Visible = true;
        }

        private void bBorrarForo_Click(object sender, EventArgs e)
        {
            BD.Delete("Foro", ((ForoBD)lForos.SelectedItem).id);

            cargarForos();
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
            PantallaInicioSesionIniciada ventana = new PantallaInicioSesionIniciada();
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

        private void lTest_SelectedIndexChanged(object sender, EventArgs e)
        {
           var test_seleccionado = (TestBD)lTest.SelectedItem;

            if (test_seleccionado == null) return;

            if (BD.Select("SELECT * FROM Puntuacion WHERE idTest = " + test_seleccionado.id + " AND nombreUsuario = '" + Usuario.getInstance().usuario + "';").Count > 0)
            {
                MessageBox.Show("Ya has realizado este cuestionario");
                return;
            }

            Test ventana = new Test(test_seleccionado);
            this.Visible = false;
            ventana.ShowDialog();
            if (!Usuario.hasInstance())
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
            }
        }

        private void bBorrarTest_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quiere borrar el cuestionario?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                BD.Delete("Test", ((TestBD)lTest.SelectedItem).id);

                cargarTests();
            }
        }

        private void bIntegrantes_Click(object sender, EventArgs e)
        {
            Integrantes ventana = new Integrantes(curso, null);
            this.Visible = false;
            ventana.ShowDialog();
            if (!Usuario.hasInstance())
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
            }
        }

        private void bCalificaciones_Click(object sender, EventArgs e)
        {
            string message = "CALIFICACIONES\n";
            var tests = BD.Select("SELECT t.nombre, p.nota FROM Puntuacion p JOIN Test t ON p.idTest = t.idTest WHERE t.idCurso = "+ curso.id + " and p.nombreUsuario = '" + Usuario.getInstance().usuario + "';");

            foreach (var test in tests)
            {
                message += (string)test[0] + " " + test[1].ToString() + "\n";
            }

            MessageBox.Show(message);
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            if (cValoración.Text == "" || cProfesor.Text == "" || tOpinion.Text == "" || tMejora.Text == "")
            {
                MessageBox.Show("Rellene los campos necesarios");
                return;
            }

            string profesor = BD.Select("SELECT email FROM Usuario WHERE nombreUsuario = '" + curso.dueño + "';")[0].ToString();
            Correo.Enviar(profesor,"Cuestionario de satisfacción del curso: " + curso.nombre, "Puntuación del curso: "+ cValoración.Text
                + "\nPuntuación del profesor: " + cProfesor.Text + "\nOpinión sobre el curso: " + tOpinion.Text + "\nMejoras para el curso:"
                + tMejora.Text);

            cValoración.SelectedIndex = -1;
            cProfesor.SelectedIndex = -1;
            tOpinion.Text = "";
            tMejora.Text = "";
        }
    }
}
