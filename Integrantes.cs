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
    public partial class Integrantes : Form
    {
        CursoBD curso;

        public Integrantes(CursoBD curso)
        {
            InitializeComponent();

            this.curso = curso;
            this.lUsuario.Text = Usuario.getInstance().usuario;

            cargarIntegrantes("");

            lUser.Text = "";
            lNombre.Text = "";
            lApellidos.Text = "";
            lCorreo.Text = "";
        }

        private void cargarIntegrantes(string filtro)
        {
            lIntegrantes.Items.Clear();

            List<object[]> participantes;

            if(filtro == "")
            {
                participantes = BD.Select("SELECT * FROM Usuario WHERE nombreUsuario IN (SELECT nombreUsuario FROM Matricula WHERE idCurso = " + curso.id + ") AND admin = 0;");
            }
            else
            {
                participantes = BD.Select("SELECT * FROM Usuario WHERE nombreUsuario IN (SELECT nombreUsuario FROM Matricula WHERE idCurso = " + curso.id + ") AND admin = 0 AND nombreUsuario LIKE '" + filtro + "%';");
            }
            

            foreach (var persona in participantes)
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

            //TODO CALIFICACIONES
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

                BD.Delete("DELETE FROM Matricula WHERE nombreUsuario = '" + persona.usuario + "' AND idCurso = " + this.curso.id);
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
    }
}
