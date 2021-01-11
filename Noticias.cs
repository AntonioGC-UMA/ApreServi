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
        NoticiaBD seleccionada;
        TableLayoutPanel selected;

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

            foreach (var a in Usuario.get_eventos())
            {
                mCalendario.AddBoldedDate(a.dia);
            }
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
            //TODO  template.BackColor = Color.AntiqueWhite;

            var picture = new PictureBox();
            picture.Image = n.image;
            picture.BackgroundImageLayout = ImageLayout.Stretch;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Width = 200;
            picture.Height = 180;
            

            picture.Click += (object sender, EventArgs e) =>
            {
                template.BackColor = Color.AliceBlue;
                if (selected != null)
                {
                    selected.BackColor = Color.Transparent;
                }
                selected = template;
                seleccionada = n;
            };

            picture.DoubleClick += (object sender, EventArgs e) =>
            {
                Noticia ventana = new Noticia(n);
                this.Visible = false;
                ventana.ShowDialog();
                this.Close();
            };

            var lable = new Label();
            lable.Text = n.titulo;
            lable.Width = 200;

            template.Controls.Add(picture);
            template.Controls.Add(lable);
            template.SetCellPosition(picture, new TableLayoutPanelCellPosition(0, 0));
            template.SetCellPosition(lable, new TableLayoutPanelCellPosition(0, 1));
            fNoticias.Controls.Add(template);
        }

        public static Bitmap GetImageFromByteArray(byte[] byteArray)
        {
            Bitmap bm = (Bitmap)new ImageConverter().ConvertFrom(byteArray);

            if (bm != null && (bm.HorizontalResolution != (int)bm.HorizontalResolution ||
                               bm.VerticalResolution != (int)bm.VerticalResolution))
            {
                // Correct a strange glitch that has been observed in the test program when converting 
                //  from a PNG file image created by CopyImageToByteArray() - the dpi value "drifts" 
                //  slightly away from the nominal integer value
                bm.SetResolution((int)(bm.HorizontalResolution + 0.5f),
                                 (int)(bm.VerticalResolution + 0.5f));
            }

            return bm;
        }

        private void cargarNoticias()
        {
            fNoticias.Controls.Clear();
            foreach (var n in BD.Select("SELECT * FROM Noticia ORDER BY fechaPublicacion LIMIT 6"))
            {
                cargarNoticia(new NoticiaBD((int)n[0], (string)n[2], (string)n[1], (string)n[5], GetImageFromByteArray((byte[])n[3]), (DateTime)n[4]));
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

        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            Usuario.cerrarSesion();
            this.Close();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {   
            if (seleccionada != null){
                BD.Delete("Noticia", seleccionada.id);

                cargarNoticias();
            }

            seleccionada = null;
            selected = null;
        }

        private void bAñadir_Click(object sender, EventArgs e)
        {
            CrearNoticia ventana = new CrearNoticia();
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
