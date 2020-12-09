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
    public partial class Foro : Form
    {
        ForoBD foro;

        public void update()
        {
            lPosts.Items.Clear();
            tRespuesta.Text = "";

            string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
            MySqlConnection connection = new MySqlConnection(MyConString);

            connection.Open();


            var sql = "select * from Post p where p.idForo = " + foro.id;

            var cmd = new MySqlCommand(sql, connection);


            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                this.lPosts.Items.Add(new PostBD((int)rdr[0], (string)rdr[1], (string)rdr[2]));
            }

            lableTitulo.Text = foro.nombre;

            rdr.Close();
            connection.Close();
        }

        public Foro(ForoBD foro)
        {
            InitializeComponent();

            this.foro = foro;

            update();
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

        private void bEnviar_Click(object sender, EventArgs e)
        {
            if (tRespuesta.Text.Trim().Length == 0) return;

            string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
            MySqlConnection connection = new MySqlConnection(MyConString);

            connection.Open();

            var sql = String.Format("insert into Post (autor,contenido,idForo) values ('{0}','{1}',{2})", Usuario.getInstance().usuario, tRespuesta.Text, foro.id);
            var cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();

            connection.Close();

            update();
        }
    }
}
