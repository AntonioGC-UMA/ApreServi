﻿using MySql.Data.MySqlClient;
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


            MySqlConnection connection = BD.GetConnection();

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
                    instance.rol = new Rol((string)rdr[5]);
                    rdr.Close();
                    connection.Close();
                    PantallaInicioSesionIniciada ventana = new PantallaInicioSesionIniciada();
                    ventana.MdiParent = this.MdiParent;
                    this.Visible = false;
                    ventana.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                    rdr.Close();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("No existe ninguna cuenta con ese usuario");
                rdr.Close();
                connection.Close();
            }

            
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
