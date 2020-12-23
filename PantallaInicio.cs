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
using System.Net.Mail;
using System.Net;

namespace ApreServi
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
            cargarForos();

            // Ejemplo de como enviar un correo electronico. La cuenta de apreservi si existe, la he creado yo

            var fromAddress = new MailAddress("apreservi@gmail.com", "From Name");
            var toAddress = new MailAddress("xoseb53885@j24blog.com", "To Name");
            const string fromPassword = "ApreServi1234";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = "Subject",
                Body = "Body 2"
            })
            {
                smtp.Send(message);
            }
        }

        private void bIniciarSesion_Click(object sender, EventArgs e)
        {
            InicioDeSesion ventana = new InicioDeSesion();
            ventana.MdiParent = this.MdiParent;
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
          
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
            MySqlConnection connection = BD.GetConnection();

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
    }
}
