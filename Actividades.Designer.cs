
namespace ApreServi
{
    partial class Actividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actividades));
            this.mCalendario = new System.Windows.Forms.MonthCalendar();
            this.pImagen = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bAyuda = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.bActividades = new System.Windows.Forms.Button();
            this.lMisActividades = new System.Windows.Forms.ListBox();
            this.bPerfil = new System.Windows.Forms.Button();
            this.lCalendario = new System.Windows.Forms.Label();
            this.noticias = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.lOtrasActividades = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bCerrarSesion = new System.Windows.Forms.Button();
            this.lUsuario = new System.Windows.Forms.Label();
            this.bCrearActividad = new System.Windows.Forms.Button();
            this.bEliminarActividad = new System.Windows.Forms.Button();
            this.pApreservi = new System.Windows.Forms.PictureBox();
            this.bIniciarSesion = new System.Windows.Forms.Button();
            this.bRegistrarse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pImagen)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pApreservi)).BeginInit();
            this.SuspendLayout();
            // 
            // mCalendario
            // 
            this.mCalendario.Location = new System.Drawing.Point(998, 216);
            this.mCalendario.Name = "mCalendario";
            this.mCalendario.TabIndex = 29;
            this.mCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mCalendario_DateChanged);
            // 
            // pImagen
            // 
            this.pImagen.Image = ((System.Drawing.Image)(resources.GetObject("pImagen.Image")));
            this.pImagen.Location = new System.Drawing.Point(1084, 24);
            this.pImagen.Name = "pImagen";
            this.pImagen.Size = new System.Drawing.Size(106, 91);
            this.pImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImagen.TabIndex = 28;
            this.pImagen.TabStop = false;
            this.pImagen.Visible = false;
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
            this.tableLayoutPanel2.TabIndex = 26;
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
            // lMisActividades
            // 
            this.lMisActividades.ColumnWidth = 60;
            this.lMisActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lMisActividades.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lMisActividades.FormattingEnabled = true;
            this.lMisActividades.ItemHeight = 25;
            this.lMisActividades.Location = new System.Drawing.Point(35, 168);
            this.lMisActividades.Name = "lMisActividades";
            this.lMisActividades.Size = new System.Drawing.Size(770, 154);
            this.lMisActividades.TabIndex = 24;
            this.lMisActividades.DoubleClick += new System.EventHandler(this.lMisActividades_SelectedIndexChanged);
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
            this.bPerfil.TabIndex = 23;
            this.bPerfil.Text = "Mi perfil";
            this.bPerfil.UseVisualStyleBackColor = false;
            this.bPerfil.Visible = false;
            this.bPerfil.Click += new System.EventHandler(this.bPerfil_Click);
            // 
            // lCalendario
            // 
            this.lCalendario.AutoSize = true;
            this.lCalendario.BackColor = System.Drawing.Color.DodgerBlue;
            this.lCalendario.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lCalendario.ForeColor = System.Drawing.Color.White;
            this.lCalendario.Location = new System.Drawing.Point(999, 179);
            this.lCalendario.Name = "lCalendario";
            this.lCalendario.Padding = new System.Windows.Forms.Padding(20, 10, 17, 10);
            this.lCalendario.Size = new System.Drawing.Size(187, 34);
            this.lCalendario.TabIndex = 22;
            this.lCalendario.Text = "Calendario de eventos";
            // 
            // noticias
            // 
            this.noticias.AutoSize = true;
            this.noticias.BackColor = System.Drawing.Color.DodgerBlue;
            this.noticias.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noticias.ForeColor = System.Drawing.Color.White;
            this.noticias.Location = new System.Drawing.Point(35, 122);
            this.noticias.Name = "noticias";
            this.noticias.Padding = new System.Windows.Forms.Padding(10, 10, 605, 10);
            this.noticias.Size = new System.Drawing.Size(771, 43);
            this.noticias.TabIndex = 21;
            this.noticias.Text = "Mis actividades";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Navy;
            this.titulo.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.Padding = new System.Windows.Forms.Padding(0, 25, 1038, 25);
            this.titulo.Size = new System.Drawing.Size(1231, 92);
            this.titulo.TabIndex = 20;
            this.titulo.Text = " ApreServ";
            // 
            // lOtrasActividades
            // 
            this.lOtrasActividades.ColumnWidth = 60;
            this.lOtrasActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lOtrasActividades.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lOtrasActividades.FormattingEnabled = true;
            this.lOtrasActividades.ItemHeight = 25;
            this.lOtrasActividades.Location = new System.Drawing.Point(35, 404);
            this.lOtrasActividades.Name = "lOtrasActividades";
            this.lOtrasActividades.Size = new System.Drawing.Size(770, 154);
            this.lOtrasActividades.TabIndex = 30;
            this.lOtrasActividades.DoubleClick += new System.EventHandler(this.lOtrasActividades_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 358);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 10, 587, 10);
            this.label2.Size = new System.Drawing.Size(772, 43);
            this.label2.TabIndex = 31;
            this.label2.Text = "Otras actividades";
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
            this.bCerrarSesion.TabIndex = 32;
            this.bCerrarSesion.Text = "Cerrar Sesión";
            this.bCerrarSesion.UseVisualStyleBackColor = false;
            this.bCerrarSesion.Visible = false;
            this.bCerrarSesion.Click += new System.EventHandler(this.bCerrarSesion_Click);
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
            this.lUsuario.TabIndex = 33;
            this.lUsuario.Text = "label3";
            this.lUsuario.Visible = false;
            // 
            // bCrearActividad
            // 
            this.bCrearActividad.BackColor = System.Drawing.Color.SteelBlue;
            this.bCrearActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCrearActividad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bCrearActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCrearActividad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCrearActividad.ForeColor = System.Drawing.Color.White;
            this.bCrearActividad.Location = new System.Drawing.Point(34, 610);
            this.bCrearActividad.Name = "bCrearActividad";
            this.bCrearActividad.Size = new System.Drawing.Size(117, 39);
            this.bCrearActividad.TabIndex = 34;
            this.bCrearActividad.Text = "Crear Actividad";
            this.bCrearActividad.UseVisualStyleBackColor = false;
            this.bCrearActividad.Visible = false;
            this.bCrearActividad.Click += new System.EventHandler(this.bCrearActividad_Click);
            // 
            // bEliminarActividad
            // 
            this.bEliminarActividad.BackColor = System.Drawing.Color.SteelBlue;
            this.bEliminarActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEliminarActividad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bEliminarActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminarActividad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bEliminarActividad.ForeColor = System.Drawing.Color.White;
            this.bEliminarActividad.Location = new System.Drawing.Point(183, 610);
            this.bEliminarActividad.Name = "bEliminarActividad";
            this.bEliminarActividad.Size = new System.Drawing.Size(129, 39);
            this.bEliminarActividad.TabIndex = 37;
            this.bEliminarActividad.Text = "Eliminar Actividad";
            this.bEliminarActividad.UseVisualStyleBackColor = false;
            this.bEliminarActividad.Visible = false;
            this.bEliminarActividad.Click += new System.EventHandler(this.bEliminarActividad_Click);
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
            // bIniciarSesion
            // 
            this.bIniciarSesion.BackColor = System.Drawing.Color.SteelBlue;
            this.bIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIniciarSesion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.bIniciarSesion.Location = new System.Drawing.Point(856, 35);
            this.bIniciarSesion.Name = "bIniciarSesion";
            this.bIniciarSesion.Size = new System.Drawing.Size(111, 33);
            this.bIniciarSesion.TabIndex = 68;
            this.bIniciarSesion.Text = "Iniciar Sesión";
            this.bIniciarSesion.UseVisualStyleBackColor = false;
            this.bIniciarSesion.Visible = false;
            this.bIniciarSesion.Click += new System.EventHandler(this.bIniciarSesion_Click);
            // 
            // bRegistrarse
            // 
            this.bRegistrarse.BackColor = System.Drawing.Color.SteelBlue;
            this.bRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRegistrarse.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bRegistrarse.ForeColor = System.Drawing.Color.White;
            this.bRegistrarse.Location = new System.Drawing.Point(973, 35);
            this.bRegistrarse.Name = "bRegistrarse";
            this.bRegistrarse.Size = new System.Drawing.Size(90, 33);
            this.bRegistrarse.TabIndex = 67;
            this.bRegistrarse.Text = "Registrarse";
            this.bRegistrarse.UseVisualStyleBackColor = false;
            this.bRegistrarse.Visible = false;
            this.bRegistrarse.Click += new System.EventHandler(this.bRegistrarse_Click);
            // 
            // Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1228, 661);
            this.Controls.Add(this.bRegistrarse);
            this.Controls.Add(this.pApreservi);
            this.Controls.Add(this.bEliminarActividad);
            this.Controls.Add(this.bCrearActividad);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.bCerrarSesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lOtrasActividades);
            this.Controls.Add(this.mCalendario);
            this.Controls.Add(this.pImagen);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lMisActividades);
            this.Controls.Add(this.bPerfil);
            this.Controls.Add(this.lCalendario);
            this.Controls.Add(this.noticias);
            this.Controls.Add(this.bIniciarSesion);
            this.Controls.Add(this.titulo);
            this.MaximizeBox = false;
            this.Name = "Actividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApreServi";
            this.Load += new System.EventHandler(this.Actividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pImagen)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pApreservi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mCalendario;
        private System.Windows.Forms.PictureBox pImagen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bAyuda;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.Button bForos;
        private System.Windows.Forms.ListBox lMisActividades;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Label lCalendario;
        private System.Windows.Forms.Label noticias;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ListBox lOtrasActividades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCerrarSesion;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Button bCrearActividad;
        private System.Windows.Forms.Button bEliminarActividad;
        private System.Windows.Forms.PictureBox pApreservi;
        private System.Windows.Forms.Button bActividades;
        private System.Windows.Forms.Button bIniciarSesion;
        private System.Windows.Forms.Button bRegistrarse;
    }
}