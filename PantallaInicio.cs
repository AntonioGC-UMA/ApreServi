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
            ventana.MdiParent = this.MdiParent;
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
            /*

            string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
            MySqlConnection connection = new MySqlConnection(MyConString);

            connection.Open();

          
            var sql = "select * from Prueba";
            
            var cmd = new MySqlCommand(sql, connection);


            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                this.listBox1.Items.Add(rdr[0]);
                Console.WriteLine(rdr[0]);
            }
            rdr.Close();
            

            connection.Close();

            */
        }

        private void lForos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var foro_seleccionado = (ForoBD)lForos.SelectedItem;

            if (foro_seleccionado == null) return;

            Foro ventana = new Foro(foro_seleccionado);
            ventana.MdiParent = this.MdiParent;
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
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

        private void bRegistrarse_Click(object sender, EventArgs e)
        {
            Registro ventana = new Registro();
            ventana.MdiParent = this.MdiParent;
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
            ventana.MdiParent = this.MdiParent;
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bActividades_Click(object sender, EventArgs e)
        {

        }

        private void bAyuda_Click(object sender, EventArgs e)
        {

        }
    }
}
