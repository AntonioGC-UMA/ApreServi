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
    public partial class Actividad : Form
    {
        ActividadBD actividad;

        public Actividad(ActividadBD actividad)
        {
            InitializeComponent();

            this.actividad = actividad;
            this.lUsuario.Text = Usuario.getInstance().usuario;
            this.tDescripcion.Text = actividad.descripcion;

            var list = BD.Select("select * from Actividad a where a.propietario ='" + Usuario.getInstance().usuario + "' and a.id =" + actividad.id);

            if (list.Count > 0 || Usuario.getInstance().rol.admin)
            {
                bAñadir.Visible = true;
                bBorrar.Visible = true;
                bGuardar.Visible = true;
                bAbandonar.Visible = false;

                bAñadirForo.Visible = true;
                bBorrarForo.Visible = true;

                tAñadir.Visible = true;
                tDescripcion.ReadOnly = false;
            }

            cargarForos();
        }

        private void cargarForos()
        {
            lForos.Items.Clear();

            foreach (var elem in BD.Select("select * from Foro f where f.idActividad = " + actividad.id))
            {
                this.lForos.Items.Add(new ForoBD((int)elem[0], (string)elem[1], (string)elem[2], (int)elem[3], elem[4] == System.DBNull.Value ? 0 : (int)elem[4], elem[5] == System.DBNull.Value ? 0 : (int)elem[5]));
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

        private void bAbandonar_Click(object sender, EventArgs e)
        {
            BD.Delete("delete from Inscripcion i where i.nombreUsuario = '" + Usuario.getInstance().usuario + "' and i.idActividad = " + actividad.id);
           
            Actividades ventana = new Actividades();
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

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            BD.Update("update Actividad set descripcion ='" + tDescripcion.Text + "' where id =" + actividad.id);
        }

        private void bAñadirForo_Click(object sender, EventArgs e)
        {
            CrearForo ventana = new CrearForo(0, actividad.id);
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

        private void tPestañas_SelectedIndexChanged(object sender, EventArgs e)
        {

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
