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
    public partial class Noticias : Form
    {
        public Noticias()
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

            cargarNoticias();
        }

        private void cargarNoticia(NoticiaBD n)
        {
            var template = new TableLayoutPanel();
            template.RowCount = 2;
            template.ColumnCount = 1;
            template.Width = 200;
            template.Height = 200;
            template.Margin = new Padding(30, 3, 3, 3);
            template.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            template.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));

            var picture = new PictureBox();
            picture.Image = n.image;

            var lable = new Label();
            lable.Text = n.titulo;

            template.Controls.Add(picture);
            template.Controls.Add(lable);
            template.SetCellPosition(picture, new TableLayoutPanelCellPosition(0, 0));
            template.SetCellPosition(lable, new TableLayoutPanelCellPosition(0, 1));
            fNoticias.Controls.Add(template);
        }

        private void cargarNoticias()
        {
            throw new Exception("TODO"); // TODO
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
            // TODO
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
            /*
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
            */
        }

        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            Usuario.cerrarSesion();
            this.Close();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            /*
            if (lForos.SelectedIndex != -1)
            {
                var foro = (ForoBD)lForos.SelectedItem;

                BD.Delete("Foro", foro.id);

                cargarNoticias();
            }*/
        }

        private void bAñadir_Click(object sender, EventArgs e)
        {
            CrearForo ventana = new CrearForo();
            this.Visible = false;
            ventana.ShowDialog();
            cargarNoticias();
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
    }
}
