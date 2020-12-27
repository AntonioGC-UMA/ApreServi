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
    public partial class Actividades : Form
    {
        public Actividades()
        {
            InitializeComponent();

            if (Usuario.hasInstance())
            {
                cargarActividades();

                if (Usuario.getInstance().rol.admin)
                {
                    bCrearActividad.Visible = true;
                    bEliminarActividad.Visible = true;
                }

                this.lUsuario.Text = Usuario.getInstance().usuario;
                bCursos.Visible = true;
                lUsuario.Visible = true;
                bPerfil.Visible = true;
                pImagen.Visible = true;
                bCerrarSesion.Visible = true;
            }
            else
            {
                cargarTodasLasActividades();

                bIniciarSesion.Visible = true;
                bRegistrarse.Visible = true;
            }
        }

        private void lMisCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var actividad_seleccionada = (ActividadBD)lMisActividades.SelectedItem;

            if (actividad_seleccionada == null) return;

            Actividad ventana = new Actividad(actividad_seleccionada);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void lOtrosCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var actividad_seleccionada = (ActividadBD)lOtrasActividades.SelectedItem;

            if (actividad_seleccionada == null) return;

            ActividadNoInscrita ventana = new ActividadNoInscrita(actividad_seleccionada);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }


        private void bForos_Click(object sender, EventArgs e)
        {
            ForosGenerales ventana = new ForosGenerales();
            ventana.MdiParent = this.MdiParent;
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
            ventana.MdiParent = this.MdiParent;
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

        private void cargarTodasLasActividades()
        {
            lMisActividades.Items.Clear();
            lOtrasActividades.Items.Clear();
            string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
            MySqlConnection connection = new MySqlConnection(MyConString);

            connection.Open();

            var sql = "select * from Actividad";

            var cmd = new MySqlCommand(sql, connection);

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                lOtrasActividades.Items.Add(new ActividadBD((int)rdr[0], (string)rdr[1], (string)rdr[2]));
            }
            rdr.Close();
            connection.Close();
        }

        private void cargarActividades()
        {
            lMisActividades.Items.Clear();
            lOtrasActividades.Items.Clear();
            string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
            MySqlConnection connection = new MySqlConnection(MyConString);

            connection.Open();

            var sql = "select * from Actividad a join Inscripcion i on a.id = i.idActividad where m.nombreUsuario = '" + Usuario.getInstance().usuario + "';";

            var cmd = new MySqlCommand(sql, connection);

            this.lUsuario.Text = Usuario.getInstance().usuario;

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                lMisActividades.Items.Add(new ActividadBD((int)rdr[0], (string)rdr[1], (string)rdr[2]));
            }
            rdr.Close();

            sql = "select * from Curso c where c.id not in (select c.id from Curso c join Matricula m on c.id = m.idCurso where m.nombreUsuario = '" + Usuario.getInstance().usuario + "');";

            cmd = new MySqlCommand(sql, connection);

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                lOtrasActividades.Items.Add(new ActividadBD((int)rdr[0], (string)rdr[1], (string)rdr[2]));
            }

            rdr.Close();
            connection.Close();
        }

        private void bCrearActividad_Click(object sender, EventArgs e)
        {
            CrearActividad ventana = new CrearActividad();
            this.Visible = false;
            ventana.ShowDialog();
            cargarActividades();
            this.Visible = true;
        }

        private void bEliminarActividad_Click(object sender, EventArgs e)
        {
            if(lMisActividades.SelectedIndex != -1)
            {
                var actividad = (ActividadBD)lMisActividades.SelectedItem;

                string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
                MySqlConnection connection = new MySqlConnection(MyConString);

                connection.Open();

                var sql = "delete from Actividad where id =" + actividad.id;

                var cmd = new MySqlCommand(sql, connection);

                cmd.ExecuteNonQuery();

                connection.Close();

                cargarActividades();
            }

            if (lOtrasActividades.SelectedIndex != -1)
            {
                var actividad = (ActividadBD)lOtrasActividades.SelectedItem;

                string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
                MySqlConnection connection = new MySqlConnection(MyConString);

                connection.Open();

                var sql = "delete from Actividad where id =" + actividad.id;

                var cmd = new MySqlCommand(sql, connection);

                cmd.ExecuteNonQuery();

                connection.Close();

                cargarActividades();
            }
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

        private void bIniciarSesion_Click(object sender, EventArgs e)
        {
            InicioDeSesion ventana = new InicioDeSesion();
            ventana.MdiParent = this.MdiParent;
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bRegistrarse_Click(object sender, EventArgs e)
        {
            Registro ventana = new Registro();
            ventana.MdiParent = this.MdiParent;
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }
    }
}
