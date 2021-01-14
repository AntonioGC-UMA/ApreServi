
namespace ApreServi
{
    partial class PantallaInicioSesionIniciada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicioSesionIniciada));
            this.bPerfil = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mCalendario = new System.Windows.Forms.MonthCalendar();
            this.lUsuario = new System.Windows.Forms.Label();
            this.bCerrarSesion = new System.Windows.Forms.Button();
            this.pApreservi = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bAyuda = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.bActividades = new System.Windows.Forms.Button();
            this.fNoticias = new System.Windows.Forms.FlowLayoutPanel();
            this.lForos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bMensajes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pApreservi)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bPerfil
            // 
            this.bPerfil.BackColor = System.Drawing.Color.SteelBlue;
            this.bPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPerfil.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bPerfil.ForeColor = System.Drawing.Color.White;
            this.bPerfil.Location = new System.Drawing.Point(1084, 121);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(106, 36);
            this.bPerfil.TabIndex = 13;
            this.bPerfil.Text = "Mi perfil";
            this.bPerfil.UseVisualStyleBackColor = false;
            this.bPerfil.Click += new System.EventHandler(this.bPerfil_Click_1);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Navy;
            this.titulo.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.Location = new System.Drawing.Point(1, -1);
            this.titulo.Name = "titulo";
            this.titulo.Padding = new System.Windows.Forms.Padding(0, 25, 1050, 25);
            this.titulo.Size = new System.Drawing.Size(1228, 92);
            this.titulo.TabIndex = 8;
            this.titulo.Text = " preServi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1084, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(564, 120);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 10, 17, 10);
            this.label1.Size = new System.Drawing.Size(187, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Calendario de eventos";
            // 
            // mCalendario
            // 
            this.mCalendario.Location = new System.Drawing.Point(559, 163);
            this.mCalendario.Name = "mCalendario";
            this.mCalendario.TabIndex = 19;
            this.mCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.BackColor = System.Drawing.Color.Navy;
            this.lUsuario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lUsuario.ForeColor = System.Drawing.Color.White;
            this.lUsuario.Location = new System.Drawing.Point(909, 38);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(68, 23);
            this.lUsuario.TabIndex = 20;
            this.lUsuario.Text = "label2";
            // 
            // bCerrarSesion
            // 
            this.bCerrarSesion.BackColor = System.Drawing.Color.SteelBlue;
            this.bCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCerrarSesion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.bCerrarSesion.Location = new System.Drawing.Point(738, 35);
            this.bCerrarSesion.Name = "bCerrarSesion";
            this.bCerrarSesion.Size = new System.Drawing.Size(109, 35);
            this.bCerrarSesion.TabIndex = 21;
            this.bCerrarSesion.Text = "Cerrar Sesión";
            this.bCerrarSesion.UseVisualStyleBackColor = false;
            this.bCerrarSesion.Click += new System.EventHandler(this.bCerrarSesion_Click);
            // 
            // pApreservi
            // 
            this.pApreservi.BackColor = System.Drawing.Color.Navy;
            this.pApreservi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pApreservi.BackgroundImage")));
            this.pApreservi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pApreservi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pApreservi.Location = new System.Drawing.Point(12, 20);
            this.pApreservi.Name = "pApreservi";
            this.pApreservi.Size = new System.Drawing.Size(198, 50);
            this.pApreservi.TabIndex = 49;
            this.pApreservi.TabStop = false;
            this.pApreservi.Click += new System.EventHandler(this.pApreservi_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Navy;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.Controls.Add(this.bAyuda, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.bCursos, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.bNoticias, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bForos, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bActividades, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(240, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(376, 41);
            this.tableLayoutPanel2.TabIndex = 50;
            // 
            // bAyuda
            // 
            this.bAyuda.BackColor = System.Drawing.Color.SteelBlue;
            this.bAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAyuda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAyuda.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAyuda.ForeColor = System.Drawing.Color.White;
            this.bAyuda.Location = new System.Drawing.Point(310, 3);
            this.bAyuda.Name = "bAyuda";
            this.bAyuda.Size = new System.Drawing.Size(63, 35);
            this.bAyuda.TabIndex = 3;
            this.bAyuda.Text = "Ayuda";
            this.bAyuda.UseVisualStyleBackColor = false;
            this.bAyuda.Visible = false;
            this.bAyuda.Click += new System.EventHandler(this.bAyuda_Click);
            // 
            // bCursos
            // 
            this.bCursos.BackColor = System.Drawing.Color.SteelBlue;
            this.bCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCursos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCursos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCursos.ForeColor = System.Drawing.Color.White;
            this.bCursos.Location = new System.Drawing.Point(138, 3);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(61, 35);
            this.bCursos.TabIndex = 2;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = false;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bNoticias
            // 
            this.bNoticias.BackColor = System.Drawing.Color.SteelBlue;
            this.bNoticias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNoticias.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bNoticias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNoticias.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bNoticias.ForeColor = System.Drawing.Color.White;
            this.bNoticias.Location = new System.Drawing.Point(63, 3);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(69, 35);
            this.bNoticias.TabIndex = 1;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = false;
            this.bNoticias.Click += new System.EventHandler(this.bNoticias_Click);
            // 
            // bForos
            // 
            this.bForos.BackColor = System.Drawing.Color.SteelBlue;
            this.bForos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bForos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bForos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bForos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bForos.ForeColor = System.Drawing.Color.White;
            this.bForos.Location = new System.Drawing.Point(3, 3);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(54, 35);
            this.bForos.TabIndex = 0;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = false;
            this.bForos.Click += new System.EventHandler(this.bForos_Click);
            // 
            // bActividades
            // 
            this.bActividades.BackColor = System.Drawing.Color.SteelBlue;
            this.bActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bActividades.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bActividades.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bActividades.ForeColor = System.Drawing.Color.White;
            this.bActividades.Location = new System.Drawing.Point(205, 3);
            this.bActividades.Name = "bActividades";
            this.bActividades.Size = new System.Drawing.Size(99, 35);
            this.bActividades.TabIndex = 4;
            this.bActividades.Text = "Actividades";
            this.bActividades.UseVisualStyleBackColor = false;
            this.bActividades.Click += new System.EventHandler(this.bActividades_Click);
            // 
            // fNoticias
            // 
            this.fNoticias.BackColor = System.Drawing.Color.White;
            this.fNoticias.Location = new System.Drawing.Point(12, 199);
            this.fNoticias.Name = "fNoticias";
            this.fNoticias.Size = new System.Drawing.Size(480, 417);
            this.fNoticias.TabIndex = 79;
            // 
            // lForos
            // 
            this.lForos.BackColor = System.Drawing.Color.White;
            this.lForos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lForos.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lForos.FormattingEnabled = true;
            this.lForos.ItemHeight = 23;
            this.lForos.Location = new System.Drawing.Point(523, 399);
            this.lForos.Name = "lForos";
            this.lForos.Size = new System.Drawing.Size(596, 257);
            this.lForos.TabIndex = 78;
            this.lForos.SelectedIndexChanged += new System.EventHandler(this.lForos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(514, 355);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(188, 0, 189, 10);
            this.label3.Size = new System.Drawing.Size(605, 42);
            this.label3.TabIndex = 76;
            this.label3.Text = "Foros generales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(74, 0, 74, 0);
            this.label4.Size = new System.Drawing.Size(428, 32);
            this.label4.TabIndex = 75;
            this.label4.Text = "Noticias destacadas";
            // 
            // bMensajes
            // 
            this.bMensajes.BackColor = System.Drawing.Color.SteelBlue;
            this.bMensajes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMensajes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bMensajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMensajes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bMensajes.ForeColor = System.Drawing.Color.White;
            this.bMensajes.Location = new System.Drawing.Point(902, 194);
            this.bMensajes.Name = "bMensajes";
            this.bMensajes.Size = new System.Drawing.Size(250, 135);
            this.bMensajes.TabIndex = 80;
            this.bMensajes.Text = "Mensajes";
            this.bMensajes.UseVisualStyleBackColor = false;
            this.bMensajes.Click += new System.EventHandler(this.bMensajes_Click);
            // 
            // PantallaInicioSesionIniciada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1228, 661);
            this.Controls.Add(this.bMensajes);
            this.Controls.Add(this.fNoticias);
            this.Controls.Add(this.lForos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pApreservi);
            this.Controls.Add(this.bCerrarSesion);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.mCalendario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.MaximizeBox = false;
            this.Name = "PantallaInicioSesionIniciada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApreServi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pApreservi)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mCalendario;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Button bCerrarSesion;
        private System.Windows.Forms.PictureBox pApreservi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bAyuda;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.Button bForos;
        private System.Windows.Forms.Button bActividades;
        private System.Windows.Forms.FlowLayoutPanel fNoticias;
        private System.Windows.Forms.ListBox lForos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bMensajes;
    }
}