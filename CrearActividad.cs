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
    public partial class CrearActividad : Form
    {
        public CrearActividad()
        {
            InitializeComponent();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            if(tNombreActividad.Text.Length == 0)
            {
                MessageBox.Show("El nombre de la actividad es obligatorio");
                return;
            }

            if(tDescripcion.Text.Length == 0)
            {
                MessageBox.Show("La descripción es obligatoria");
                return;
            }

            if(dInicio.Value > dFin.Value)
            {
                MessageBox.Show("La actividad no puede tener duración negativa");
                return;
            }

            if(dInicio.Value < System.DateTime.Now || dFin.Value < System.DateTime.Now)
            {
                MessageBox.Show("No puedes iniciar una actividad en el pasado");
                return;
            }

            BD.Insert(new ActividadBD(-1, tNombreActividad.Text, tDescripcion.Text, dInicio.Value, dFin.Value));
            this.Close();
        }

        private void CrearCurso_Load(object sender, EventArgs e)
        {
            //NO USADO
        }

        private void tNombreCurso_TextChanged(object sender, EventArgs e)
        {
            //NO USADO
        }
    }
}
