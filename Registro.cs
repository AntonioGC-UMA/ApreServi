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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            var nombreUsuario = tNombreUsuario.Text;
            var nombre = tNombre.Text;
            var apellido = tApellidos.Text;
            var correo = tCorreo.Text;
            var contraseña = tPassword.Text;
            var contraseña2 = tConfirmPassword.Text;


            if(nombreUsuario.Length == 0)
            {
                MessageBox.Show("El nombre de usuario es obligatorio");
                return;
            }
            if(nombre.Length == 0)
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }
            if(apellido.Length == 0)
            {
                MessageBox.Show("El apellido es obligatorio");
                return;
            }
            if(correo.Length == 0)
            {
                MessageBox.Show("El correo es obligatorio");
                return;
            }
            if(contraseña.Length == 0)
            {
                MessageBox.Show("La contraseña es obligatoria");
                return;
            }

            if (!contraseña.Equals(contraseña2))
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }


            string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
            MySqlConnection connection = new MySqlConnection(MyConString);

            connection.Open();


            var sql = "select * from Usuario where nombreUsuario = '" + nombre + "'";

            var cmd = new MySqlCommand(sql, connection);


            MySqlDataReader rdr = cmd.ExecuteReader();


            if (rdr.HasRows)
            {
                MessageBox.Show("Ya existe una cuenta con ese nombre de usuario");
                return;
            }

            rdr.Close();

            sql = String.Format("insert into Usuario values ('{0}','{1}','{2}','{3}','{4}', 'usuario')", nombreUsuario, correo, contraseña, nombre, apellido);
            cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();

            connection.Close();

            var instance = Usuario.getInstance();
            instance.usuario = nombreUsuario;
            instance.correo = correo;
            instance.contraseña = contraseña;
            instance.nombre = nombre;
            instance.apellido = apellido;

            PantallaInicioSesionIniciada ventana = new PantallaInicioSesionIniciada();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }
    }
}
