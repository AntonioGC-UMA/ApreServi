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
    public partial class Integrantes : Form
    {
        CursoBD curso;
        ActividadBD actividad;

        public Integrantes(CursoBD curso, ActividadBD actividad)
        {
            InitializeComponent();
            this.curso = curso;
            this.actividad = actividad;
            this.lUsuario.Text = Usuario.getInstance().usuario;
            var i = BD.Select("SELECT imagen FROM ImagenPerfil WHERE nombreUsuario = '" + Usuario.getInstance().usuario + "';");

            if (i.Count > 0)
            {
                pictureBox1.Image = Noticias.GetImageFromByteArray((byte[])(i[0][0]));
            }

            if (curso == null)
            {
                lCalificacion.Visible = false;
                label9.Visible = false;
            }

            cargarIntegrantes("");

            lUser.Text = "";
            lNombre.Text = "";
            lApellidos.Text = "";
            lCorreo.Text = "";
        }

        private void cargarIntegrantes(string filtro)
        {
            lIntegrantes.Items.Clear();
            string sql = "";

            if (curso != null)
                sql = "SELECT * FROM Usuario WHERE nombreUsuario IN (SELECT nombreUsuario FROM Matricula WHERE idCurso = " + curso.id + ") AND admin = 0";
            else if (actividad != null)
                sql = "SELECT * FROM Usuario WHERE nombreUsuario IN (SELECT nombreUsuario FROM Inscripcion WHERE idActividad = " + actividad.id + ") AND admin = 0";
            else
                throw new Exception("Error");

            if (filtro != "")
            {

                sql += "  AND nombreUsuario LIKE '" + filtro + "%';";
            }

            foreach (var persona in BD.Select(sql))
            {
                lIntegrantes.Items.Add(new PersonaBD((string) persona[0], (string) persona[1], (string) persona[2], (string) persona[3], (string) persona[4], (SByte) persona[5] != 0));
            }
        }
        private void lIntegrantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lIntegrantes.SelectedIndex == -1) return;

            PersonaBD persona = (PersonaBD)lIntegrantes.Items[lIntegrantes.SelectedIndex];

            lUser.Text = persona.usuario;
            lNombre.Text = persona.nombre;
            lApellidos.Text = persona.apellido;
            lCorreo.Text = persona.correo;

            if(curso != null)
                lCalificacion.Text = BD.Select(String.Format("SELECT AVG(p.nota) FROM Puntuacion p JOIN Test t ON p.idTest = t.idTest  WHERE p.nombreUsuario = '{0}' AND t.idCurso = {1};", persona.usuario, curso.id))[0][0].ToString(); 
        }




        //BOTONES
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

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (lIntegrantes.SelectedIndex == -1) return;

            DialogResult result = MessageBox.Show("¿Seguro que quiere expulsar al usuario?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            { 
                var persona = (PersonaBD)lIntegrantes.Items[lIntegrantes.SelectedIndex];


                if (curso != null)
                    BD.Delete("DELETE FROM Matricula WHERE nombreUsuario = '" + persona.usuario + "' AND idCurso = " + this.curso.id);
                else if (actividad != null)
                    BD.Delete("DELETE FROM Inscripcion WHERE nombreUsuario = '" + persona.usuario + "' AND idActividad = " + this.actividad.id);
                else
                    throw new Exception("Error");

                cargarIntegrantes(tBuscar.Text);

                lUser.Text = "";
                lNombre.Text = "";
                lApellidos.Text = "";
                lCorreo.Text = "";
            }
        }

        private void tBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = tBuscar.Text;

            cargarIntegrantes(texto);
        }

        private void bCorreo_Click(object sender, EventArgs e)
        {
            List<string> correos = new List<string>();

            if (curso != null)
                foreach (var a in BD.Select("SELECT * FROM Usuario WHERE nombreUsuario IN (SELECT nombreUsuario FROM Matricula WHERE idCurso = " + curso.id + ") AND admin = 0"))
                    correos.Add((string)a[1]);
            else if (actividad != null)
                foreach (var a in BD.Select("SELECT * FROM Usuario WHERE nombreUsuario IN (SELECT nombreUsuario FROM Inscripcion WHERE idActividad = " + actividad.id + ") AND admin = 0"))
                    correos.Add((string)a[1]);
            else
                throw new Exception("Error");

            CorreoGrupal ventana = new CorreoGrupal(correos);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }
    }
}
