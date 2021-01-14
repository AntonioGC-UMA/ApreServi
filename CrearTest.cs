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
    public partial class CrearTest : Form
    {
        List<PreguntaBD> preguntas = new List<PreguntaBD>();

        CursoBD curso;
        TestBD test;

        public CrearTest(CursoBD c, TestBD t)
        {
            InitializeComponent();

            curso = c;
            test = t;

            if(test != null)
            {
                preguntas = test.preguntas;

                tNombreTest.Text = test.nombre;

                foreach(var p in preguntas)
                {
                    lPreguntas.Items.Add(p);
                }
            }            
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            if(test != null)
            {
                BD.Delete("delete from Test where idTest = " + test.id);
            }

            BD.Insert(new TestBD(-1, curso.id, tNombreTest.Text, preguntas));


            var idTest = (int)BD.Select("SELECT * FROM Test t WHERE t.idCurso = " + curso.id + " AND t.nombre = '"+ tNombreTest.Text +"'")[0][0];
            int cont = 0;
            foreach (var p in preguntas)
            {
                BD.Insert(String.Format("INSERT INTO Pregunta VALUES ({0},{1},'{2}',{3});", cont, idTest, p.enunciado, p.correcta));

                var idPregunta = (int)BD.Select("SELECT * FROM Pregunta t WHERE t.idTest = " + idTest + " AND t.numeroPregunta = " + cont )[0][0];
                var count_2 = 0;
                foreach(var o in p.opciones)
                {
                    BD.Insert(String.Format("INSERT INTO Opcion VALUES ({0},{1},{2},'{3}');", count_2, idTest, cont, o));
                    count_2 += 1;
                }

                cont += 1;
            }

            this.Close();
        }


        private void bAñadirPregunta_Click(object sender, EventArgs e)
        {
            var temp = new PreguntaBD(-1, -1, tEnunciado.Text, new List<string>(), -1);
            preguntas.Add(temp);
            lPreguntas.Items.Add(temp);
            tEnunciado.Text = "";
        }

        private void bEliminarPregunta_Click(object sender, EventArgs e)
        {
            if (lPreguntas.SelectedIndex != -1) preguntas.RemoveAt(lPreguntas.SelectedIndex);
        }

        private void bAñadirOpcion_Click(object sender, EventArgs e)
        {
            if (lPreguntas.SelectedIndex == -1) return;

            preguntas[lPreguntas.SelectedIndex].opciones.Add(tOpcion.Text);
            lOpciones.Items.Add(tOpcion.Text);
            tOpcion.Text = "";
        }

        private void bMarcarSolucion_Click(object sender, EventArgs e)
        {
            if (lPreguntas.SelectedIndex == -1) return;
            if (lOpciones.SelectedIndex == -1) return;

            preguntas[lPreguntas.SelectedIndex].correcta = lOpciones.SelectedIndex;
        }

        private void lPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lPreguntas.SelectedIndex == -1) return;

            lOpciones.Items.Clear();

            foreach (var o in preguntas[lPreguntas.SelectedIndex].opciones)
            {
                lOpciones.Items.Add(o);
            }
        }
    }
}
