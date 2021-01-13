using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace ApreServi
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
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
                this.Visible = true;
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

        private void bIniciarSesion_Click(object sender, EventArgs e)
        {
            InicioDeSesion ventana = new InicioDeSesion();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
          
        }

        private void lForos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var foro_seleccionado = (ForoBD)lForos.SelectedItem;

            if (foro_seleccionado == null) return;

            Foro ventana = new Foro(foro_seleccionado);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void cargarForos()
        {
            lForos.Items.Clear();
            foreach(var elem in BD.Select("select * from Foro f where f.idCurso is null and f.idActividad is null"))
            {
                lForos.Items.Add(new ForoBD((int)elem[0], (string)elem[1], (string)elem[2], elem[3] == System.DBNull.Value ? 0 : (int) elem[3], 0, 0));
            }
        }

        private void bRegistrarse_Click(object sender, EventArgs e)
        {
            Registro ventana = new Registro();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {

        }

        private void bNoticias_Click(object sender, EventArgs e)
        {
            Noticias ventana = new Noticias();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void bCursos_Click(object sender, EventArgs e)
        {
            Cursos ventana = new Cursos();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void bActividades_Click(object sender, EventArgs e)
        {
            Actividades ventana = new Actividades();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void bAyuda_Click(object sender, EventArgs e)
        {

        }

        private void pApreservi_Click(object sender, EventArgs e)
        {
            PantallaInicio ventana = new PantallaInicio();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }
    }
}
