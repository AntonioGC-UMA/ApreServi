using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ApreServi
{
    public partial class PantallaInicioSesionIniciada : Form
    {
        public PantallaInicioSesionIniciada()
        {
            InitializeComponent();

            lUsuario.Text = Usuario.getInstance().usuario;
            var i = BD.Select("SELECT imagen FROM ImagenPerfil WHERE nombreUsuario = '" + Usuario.getInstance().usuario + "';");

            if (i.Count > 0)
            {
                pictureBox1.Image = Noticias.GetImageFromByteArray((byte[])(i[0][0]));
            }

            foreach (var a in Usuario.get_eventos())
            {
                mCalendario.AddBoldedDate(a.dia);
            }

            cargarForos();
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
            //TODO  template.BackColor = Color.AntiqueWhite;

            var picture = new PictureBox();
            picture.Image = n.image;
            picture.BackgroundImageLayout = ImageLayout.Stretch;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Width = 200;
            picture.Height = 180;

            picture.Click += (object sender, EventArgs e) =>
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
            foreach (var n in BD.Select("SELECT * FROM Noticia ORDER BY fechaPublicacion LIMIT 4"))
            {
                cargarNoticia(new NoticiaBD((int)n[0], (string)n[2], (string)n[1], (string)n[5], GetImageFromByteArray((byte[])n[3]), (DateTime)n[4]));
            }
        }

        private void lForos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var foro_seleccionado = (ForoBD)lForos.SelectedItem;

            if (foro_seleccionado == null) return;

            Foro ventana = new Foro(foro_seleccionado);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void cargarForos()
        {
            lForos.Items.Clear();
            foreach (var elem in BD.Select("select * from Foro f where f.idCurso is null and f.idActividad is null"))
            {
                lForos.Items.Add(new ForoBD((int)elem[0], (string)elem[1], (string)elem[2], elem[3] == System.DBNull.Value ? 0 : (int)elem[3], 0, 0));
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

        private void bPerfil_Click(object sender, EventArgs e)
        {
            Perfil ventana = new Perfil();
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
            PantallaInicioSesionIniciada ventana = new PantallaInicioSesionIniciada();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bPerfil_Click_1(object sender, EventArgs e)
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
                if(e.Start == a.dia)
                    lista += a.descripcion + "\n";
            }
            if(lista != "")
                MessageBox.Show(lista);
        }

        private void bMensajes_Click(object sender, EventArgs e)
        {
            Mensajes ventana = new Mensajes();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }
    }
}
