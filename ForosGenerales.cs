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

                if (Usuario.getInstance().rol.admin)
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
        }

        private void cargarForos()
        {
            lForos.Items.Clear();
            string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
            MySqlConnection connection = new MySqlConnection(MyConString);

            connection.Open();


            var sql = "select * from Foro f where f.idCurso is null ";

            var cmd = new MySqlCommand(sql, connection);


            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                lForos.Items.Add(new ForoBD((int)rdr[0], (string)rdr[1], (string)rdr[2], rdr[3] == System.DBNull.Value ? 0 : (int)rdr[3]));
            }

            rdr.Close();
            connection.Close();
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

        private void lForos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var foro_seleccionado = (ForoBD)lForos.SelectedItem;

            if (foro_seleccionado == null) return;

            Foro ventana = new Foro(foro_seleccionado);
            ventana.MdiParent = this.MdiParent;
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
            if (lForos.SelectedIndex != -1)
            {
                var foro = (ForoBD)lForos.SelectedItem;

                string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
                MySqlConnection connection = new MySqlConnection(MyConString);

                connection.Open();

                var sql = "delete from Foro where id =" + foro.id;

                var cmd = new MySqlCommand(sql, connection);

                cmd.ExecuteNonQuery();

                connection.Close();

                cargarForos();
            }
        }

        private void bAñadir_Click(object sender, EventArgs e)
        {
            CrearForo ventana = new CrearForo();
            ventana.MdiParent = this.MdiParent;
            this.Visible = false;
            ventana.ShowDialog();
            cargarForos();
            this.Visible = true;
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

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
