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
    public partial class Mensajes : Form
    {
        public Mensajes()
        {
            InitializeComponent();

            if (Usuario.hasInstance())
            {
                this.lUsuario.Text = Usuario.getInstance().usuario;
                bCursos.Visible = true;
                lUsuario.Visible = true;
                bPerfil.Visible = true;
                pImagen.Visible = true;
                bCerrarSesion.Visible = true;
                var i = BD.Select("SELECT imagen FROM ImagenPerfil WHERE nombreUsuario = '" + Usuario.getInstance().usuario + "';");

                if (i.Count > 0)
                {
                    pImagen.Image = Noticias.GetImageFromByteArray((byte[])(i[0][0]));
                }

                if (Usuario.getInstance().admin)
                {
                    bBloquear.Visible = true;
                    bEnviar.Visible = true;
                }
            }
            else
            {
                bCerrar.Visible = true;
                bIniciarSesion.Visible = true;
                bRegistrarse.Visible = true;
            }

            cargarGente("");
        }

        private void cargarGente(string filtro)
        {
            lPersonas.Items.Clear();
            string aux = String.Format("select * from Usuario where nombreUsuario <> '{0}' AND nombreUsuario <> 'Anónimo'", Usuario.getInstance().usuario);
            if (filtro != "")
            {
                aux += " and nombreUsuario LIKE '" + filtro + "%';";
            }
            
           
            foreach (var persona in BD.Select(aux))
            {
                lPersonas.Items.Add(new PersonaBD((string)persona[0], (string)persona[1], (string)persona[2], (string)persona[3], (string)persona[4], (SByte)persona[5] != 0));
            }
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
            Ayuda ventana = new Ayuda();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }


        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            Usuario.cerrarSesion();
            this.Close();
        }

        private void bIniciarSesion_Click(object sender, EventArgs e)
        {
            InicioDeSesion ventana = new InicioDeSesion();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bRegistrarse_Click(object sender, EventArgs e)
        {
            Registro ventana = new Registro();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
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
            if (Usuario.hasInstance())
            {
                PantallaInicioSesionIniciada ventana = new PantallaInicioSesionIniciada();
                this.Visible = false;
                ventana.ShowDialog();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void bPerfil_Click(object sender, EventArgs e)
        {
            Perfil ventana = new Perfil();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        void cargarMensajes(PersonaBD p)
        {
            tMensajes.Text = "";

            var id1 = Usuario.getInstance().usuario;
            var id2 = p.usuario;

            var con = BD.Select(String.Format("select * from Conversacion where (usuario1 = '{0}' and usuario2 = '{1}') or (usuario1 = '{1}' and usuario2 = '{0}')", id1, id2));
            if(con.Count != 0)
            {
                tMensajes.Text = (string)con[0][2];
            }
            else
            {
                BD.Insert(String.Format("insert into Conversacion Values ('{0}','{1}','')",id1,id2));
            }

            //pCara = ; // TODO

            var esta_bloqueado = BD.Select(String.Format("select * from Bloqueado where bloqueador = '{0}' and bloqueado = '{1}'", id1, id2));
            var estoy_bloqueado = BD.Select(String.Format("select * from Bloqueado where bloqueador = '{0}' and bloqueado = '{1}'", id2, id1));

           
            
            bEnviar.Enabled = !(estoy_bloqueado.Count != 0 || esta_bloqueado.Count != 0);
               
            

            if(esta_bloqueado.Count != 0)
            {
                bBloquear.Text = "Desbloquear";
            }
            else
            {
                bBloquear.Text = "Bloquear";
            }
        }

        private void lPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lPersonas.SelectedIndex != -1)
            {
                var per = (PersonaBD)lPersonas.Items[lPersonas.SelectedIndex];
                cargarMensajes(per);

                var i = BD.Select("SELECT imagen FROM ImagenPerfil WHERE nombreUsuario = '" + per.usuario + "';");

                if (i.Count > 0)
                {
                    pCara.Image = Noticias.GetImageFromByteArray((byte[])(i[0][0]));
                }
                else
                {
                    pCara.Image = Properties.Resources.guest;
                }

                tMensaje.Text = "";
            }
        }

        private void bBloquear_Click(object sender, EventArgs e)
        {
            if (lPersonas.SelectedIndex == -1) return;

            var id1 = Usuario.getInstance().usuario;
            var id2 = ((PersonaBD)lPersonas.Items[lPersonas.SelectedIndex]).usuario;

            if (bBloquear.Text == "Desbloquear")
            {
                BD.Delete(String.Format("delete from Bloqueado where bloqueador = '{0}' and bloqueado = '{1}'", id1, id2));
                bBloquear.Text = "Bloquear";
                bEnviar.Enabled = true;
            }
            else if (bBloquear.Text == "Bloquear")
            {
                BD.Insert(String.Format("insert into Bloqueado values ('{0}', '{1}')", id1, id2));
                bBloquear.Text = "Desbloquear";
                bEnviar.Enabled = false;
            }
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            if (lPersonas.SelectedIndex == -1) return;

            tMensajes.Text += Usuario.getInstance().usuario +  ": " + tMensaje.Text + (char)13 + (char)10;

            var id1 = Usuario.getInstance().usuario;
            var id2 = ((PersonaBD)lPersonas.Items[lPersonas.SelectedIndex]).usuario;

            tMensaje.Text = "";
            BD.Update(String.Format("update Conversacion set cuerpo = '{2}' where  (usuario1 = '{0}' and usuario2 = '{1}') or (usuario1 = '{1}' and usuario2 = '{0}')", id1, id2, tMensajes.Text));
        }

        private void tBusqueda_TextChanged(object sender, EventArgs e)
        {
            cargarGente(tBusqueda.Text);
        }
    }
}
