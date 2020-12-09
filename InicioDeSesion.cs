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
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }


        private void bIniciar_Click(object sender, EventArgs e)
        {
            var nombre = tUsuario.Text;
            var contraseña = tPassword.Text;


            string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
            MySqlConnection connection = new MySqlConnection(MyConString);

            connection.Open();


            var sql = "select * from Usuario where nombreUsuario = '" + nombre + "'";

            var cmd = new MySqlCommand(sql, connection);


            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                if(((string)rdr[2]).Equals(contraseña))
                {
                    var instance = Usuario.getInstance();
                    instance.usuario = (string)rdr[0];
                    instance.correo = (string)rdr[1];
                    instance.contraseña = (string)rdr[2];
                    instance.nombre = (string)rdr[3];
                    instance.apellido = (string)rdr[4];
                    //instance.rol = (string)rdr[5];

                    PantallaInicioSesionIniciada ventana = new PantallaInicioSesionIniciada();
                    this.Visible = false;
                    ventana.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("No existe ninguna cuenta con ese usuario");
            }

            rdr.Close();
            connection.Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
