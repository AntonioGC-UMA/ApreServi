using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApreServi
{
    public partial class CrearCurso : Form
    {
        public CrearCurso()
        {
            InitializeComponent();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            if(tNombreCurso.Text.Length == 0)
            {
                MessageBox.Show("El nombre del curso es obligatorio");
                return;
            }

            if(tDescripcion.Text.Length == 0)
            {
                MessageBox.Show("La descripción es obligatoria");
                return;
            }

            if(dInicio.Value > dFin.Value)
            {
                MessageBox.Show("El curso no puede tener duración negativa");
                return;
            }

            if(dInicio.Value < System.DateTime.Now || dFin.Value < System.DateTime.Now)
            {
                MessageBox.Show("No puedes iniciar un curso en el pasado");
                return;
            }
            BD.Insert(new CursoBD(-1, tNombreCurso.Text, tDescripcion.Text, dInicio.Value, dFin.Value, Usuario.getInstance().usuario));

            var personas = BD.Select("SELECT * FROM Usuario WHERE admin = 0");

            var worker = new System.ComponentModel.BackgroundWorker();
            worker.DoWork += (sender, e) => mandarCorreos(personas);
            worker.RunWorkerAsync();

            this.Close();
        }

        public void mandarCorreos(List<object[]> personas)
        { 
            foreach (var persona in personas)
            {
                Correo.Enviar((string)persona[1], "Nuevo curso disponible",
                    "Saludos,\nEn Apreservi se acaba de introducir un nuevo curso que podría ser de su interés: " + tNombreCurso.Text
                    + ".\nEste curso empieza el " + dInicio.Value + ". Si es de su interés, acceda a Apreservi y regístrese sin ningún problema. Esperamos que sea de su agrado.\n\n"
                    + tDescripcion.Text);
                Console.WriteLine(persona[1] + "\n");
            }
        }

        private void CrearCurso_Load(object sender, EventArgs e)
        {

        }

        private void tNombreCurso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
