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

                tAñadir.Visible = true;
                tDescripcion.ReadOnly = false;
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
                    foreach (var o in BD.Select("select * from Opcion o where o.idPreguta = " + (int)p[0]))
                        opciones.Add((string)o[1]);

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var test_seleccionado = (TestBD)lTest.SelectedItem;

            if (test_seleccionado == null) return;

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
            BD.Delete("Test", ((TestBD)lTest.SelectedItem).id);

            cargarTests();
        }
    }
}
