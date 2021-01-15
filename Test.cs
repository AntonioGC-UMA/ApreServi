using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace ApreServi
{
    public partial class Test : Form
    {
        TestBD test;
        int[] respuestas;
        int actual;

        public Test(TestBD test)
        {
            InitializeComponent();

            this.test = test;

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

            lTest.Text = test.nombre;

            respuestas = new int[test.preguntas.Count];

            for (int i = 0; i < respuestas.Length; i++)
            {
                respuestas[i] = -1;
            }

            actual = 0;

            if (respuestas.Length == 1)
            {
                bDerecha.Visible = false;
            }

            cargarPregunta(0);
        }

        private void cargarPregunta(int numero)
        {
            actual = numero;
            lNumero.Text = "Pregunta número: " + (numero + 1).ToString();
            cRespuestas.Items.Clear();

            lEnunciado.Text = test.preguntas[numero].enunciado;

            foreach(var opcion in test.preguntas[numero].opciones)
            {
                cRespuestas.Items.Add(opcion);
            }

            if (respuestas[numero] != -1)
                cRespuestas.SetItemChecked(respuestas[numero], true);
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


        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            Usuario.cerrarSesion();
            this.Close();
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

        private void bIzquierda_Click(object sender, EventArgs e)
        {
            if (actual == 1)
            {
                bIzquierda.Visible = false;
            }
            bDerecha.Visible = true;
            cargarPregunta(actual - 1);
        }

        private void bDerecha_Click(object sender, EventArgs e)
        {
            if (actual == test.preguntas.Count - 2)
            {
                bDerecha.Visible = false;
            }
            bIzquierda.Visible = true;
            cargarPregunta(actual + 1);
        }

        private void cRespuestas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < cRespuestas.Items.Count; ++ix)
                if (ix != e.Index) cRespuestas.SetItemChecked(ix, false);
            respuestas[actual] = e.Index;
        }

        private void bFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quiere entregar el cuestionario?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                double nota = 0;
                for (int i = 0; i < respuestas.Length; i++)
                {
                    if (respuestas[i] == test.preguntas[i].correcta)
                    {
                        nota++;
                    }
                }

                nota /= respuestas.Length;
                nota *= 10;

                BD.Insert("INSERT INTO Puntuacion VALUES('" + Usuario.getInstance().usuario + "'," + test.id + "," + nota.ToString(new CultureInfo("en-US")) + ")");

                this.Close();
            }
        }
    }
}
