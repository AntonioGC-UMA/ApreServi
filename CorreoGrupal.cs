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
    public partial class CorreoGrupal : Form
    {
        List<string> personas;

        public CorreoGrupal(List<string> personas)
        {
            this.personas = personas;
            InitializeComponent();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            if(tAsunto.Text.Length == 0)
            {
                MessageBox.Show("El asunto del correo es obligatorio");
                return;
            }

            if(tCuerpo.Text.Length == 0)
            {
                MessageBox.Show("El cuerpo del correo es obligatorio");
                return;
            }


            var worker = new System.ComponentModel.BackgroundWorker();
            worker.DoWork += (sender, e) => mandarCorreos(tAsunto.Text, tCuerpo.Text);
            worker.RunWorkerAsync();


            this.Close();
        }


        public void mandarCorreos(string asunto, string cuerpo)
        {
            foreach (var persona in personas)
            {
                Correo.Enviar(persona, asunto, cuerpo);
            }
        }

    }
}
