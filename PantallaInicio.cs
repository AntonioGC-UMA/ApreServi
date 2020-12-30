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
