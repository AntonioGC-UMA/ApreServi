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
    public partial class ForosGenerales : Form
    {
        public ForosGenerales()
        {
            InitializeComponent();

            if (Usuario.hasInstance())
            {
                this.lUsuario.Text = Usuario.getInstance().usuario;
                bCursos.Visible = true;
                lUsuario.Visible = true;
                bPerfil.Visible = true;
                pImagen.Visible = true;
                bCerrarSesion.Visible = true;

                if (Usuario.getInstance().admin)
                {
                    bAñadir.Visible = true;
                    bBorrar.Visible = true;
                }
            }
            else
            {
                bCerrar.Visible = true;
                bIniciarSesion.Visible = true;
                bRegistrarse.Visible = true;
            }

            cargarForos();

            foreach (var a in Usuario.get_eventos())
            {
                mCalendario.AddBoldedDate(a.dia);
            }
        }

        private void cargarForos()
        {
            lForos.Items.Clear();
            foreach(var elem in BD.Select("select * from Foro f where f.idCurso is null and f.idActividad is null"))
            {
                lForos.Items.Add(new ForoBD((int)elem[0], (string)elem[1], (string)elem[2], (int)elem[3] , elem[4] == System.DBNull.Value ? 0 : (int)elem[4], elem[5] == System.DBNull.Value ? 0 : (int)elem[5]));
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

        private void bBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quiere borrar el foro?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (lForos.SelectedIndex != -1)
                {
                    var foro = (ForoBD)lForos.SelectedItem;

                    BD.Delete("Foro", foro.id);

                    cargarForos();
                }
            }
        }

        private void bAñadir_Click(object sender, EventArgs e)
        {
            CrearForo ventana = new CrearForo();
            this.Visible = false;
            ventana.ShowDialog();
            cargarForos();
            this.Visible = true;
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

        private void bCerrar_Click(object sender, EventArgs e)
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
