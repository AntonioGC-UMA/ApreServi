
namespace ApreServi
{
    partial class Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
            this.mCalendario = new System.Windows.Forms.MonthCalendar();
            this.pImagen = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bAyuda = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.bActividades = new System.Windows.Forms.Button();
            this.lMisCursos = new System.Windows.Forms.ListBox();
            this.bPerfil = new System.Windows.Forms.Button();
            this.lCalendario = new System.Windows.Forms.Label();
            this.noticias = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.lOtrosCursos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bCerrarSesion = new System.Windows.Forms.Button();
            this.lUsuario = new System.Windows.Forms.Label();
            this.bCrearCurso = new System.Windows.Forms.Button();
            this.bEliminarCurso = new System.Windows.Forms.Button();
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
            this.mCalendario.Location = new System.Drawing.Point(1141, 288);
            this.mCalendario.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.mCalendario.Name = "mCalendario";
            this.mCalendario.TabIndex = 29;
            this.mCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mCalendario_DateChanged);
            // 
            // pImagen
            // 
            this.pImagen.Image = ((System.Drawing.Image)(resources.GetObject("pImagen.Image")));
            this.pImagen.Location = new System.Drawing.Point(1239, 32);
            this.pImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pImagen.Name = "pImagen";
            this.pImagen.Size = new System.Drawing.Size(121, 121);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(274, 39);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(430, 55);
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
            this.bAyuda.Location = new System.Drawing.Point(354, 4);
            this.bAyuda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bAyuda.Name = "bAyuda";
            this.bAyuda.Size = new System.Drawing.Size(72, 47);
            this.bAyuda.TabIndex = 3;
            this.bAyuda.Text = "Ayuda";
            this.bAyuda.UseVisualStyleBackColor = false;
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
            this.bCursos.Location = new System.Drawing.Point(157, 4);
            this.bCursos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(70, 47);
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
            this.bNoticias.Location = new System.Drawing.Point(71, 4);
            this.bNoticias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(79, 47);
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
            this.bForos.Location = new System.Drawing.Point(3, 4);
            this.bForos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(62, 47);
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
            this.bActividades.Location = new System.Drawing.Point(234, 4);
            this.bActividades.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bActividades.Name = "bActividades";
            this.bActividades.Size = new System.Drawing.Size(113, 47);
            this.bActividades.TabIndex = 4;
            this.bActividades.Text = "Actividades";
            this.bActividades.UseVisualStyleBackColor = false;
            this.bActividades.Click += new System.EventHandler(this.bActividades_Click);
            // 
            // lMisCursos
            // 
            this.lMisCursos.ColumnWidth = 60;
            this.lMisCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lMisCursos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lMisCursos.FormattingEnabled = true;
            this.lMisCursos.ItemHeight = 32;
            this.lMisCursos.Location = new System.Drawing.Point(40, 224);
            this.lMisCursos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lMisCursos.Name = "lMisCursos";
            this.lMisCursos.Size = new System.Drawing.Size(879, 196);
            this.lMisCursos.TabIndex = 24;
            this.lMisCursos.DoubleClick += new System.EventHandler(this.lMisCursos_SelectedIndexChanged);
            // 
            // bPerfil
            // 
            this.bPerfil.BackColor = System.Drawing.Color.SteelBlue;
            this.bPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPerfil.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bPerfil.ForeColor = System.Drawing.Color.White;
            this.bPerfil.Location = new System.Drawing.Point(1239, 161);
            this.bPerfil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(121, 48);
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
            this.lCalendario.Location = new System.Drawing.Point(1142, 239);
            this.lCalendario.Name = "lCalendario";
            this.lCalendario.Padding = new System.Windows.Forms.Padding(23, 13, 19, 13);
            this.lCalendario.Size = new System.Drawing.Size(216, 44);
            this.lCalendario.TabIndex = 22;
            this.lCalendario.Text = "Calendario de eventos";
            // 
            // noticias
            // 
            this.noticias.AutoSize = true;
            this.noticias.BackColor = System.Drawing.Color.DodgerBlue;
            this.noticias.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noticias.ForeColor = System.Drawing.Color.White;
            this.noticias.Location = new System.Drawing.Point(40, 163);
            this.noticias.Name = "noticias";
            this.noticias.Padding = new System.Windows.Forms.Padding(11, 13, 742, 13);
            this.noticias.Size = new System.Drawing.Size(892, 55);
            this.noticias.TabIndex = 21;
            this.noticias.Text = "Mis cursos";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Navy;
            this.titulo.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.Padding = new System.Windows.Forms.Padding(0, 33, 1186, 33);
            this.titulo.Size = new System.Drawing.Size(1427, 119);
            this.titulo.TabIndex = 20;
            this.titulo.Text = " ApreServ";
            // 
            // lOtrosCursos
            // 
            this.lOtrosCursos.ColumnWidth = 60;
            this.lOtrosCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lOtrosCursos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lOtrosCursos.FormattingEnabled = true;
            this.lOtrosCursos.ItemHeight = 32;
            this.lOtrosCursos.Location = new System.Drawing.Point(40, 539);
            this.lOtrosCursos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lOtrosCursos.Name = "lOtrosCursos";
            this.lOtrosCursos.Size = new System.Drawing.Size(879, 196);
            this.lOtrosCursos.TabIndex = 30;
            this.lOtrosCursos.DoubleClick += new System.EventHandler(this.lOtrosCursos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 477);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(11, 13, 720, 13);
            this.label2.Size = new System.Drawing.Size(897, 55);
            this.label2.TabIndex = 31;
            this.label2.Text = "Otros cursos";
            // 
            // bCerrarSesion
            // 
            this.bCerrarSesion.BackColor = System.Drawing.Color.SteelBlue;
            this.bCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCerrarSesion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.bCerrarSesion.Location = new System.Drawing.Point(843, 47);
            this.bCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bCerrarSesion.Name = "bCerrarSesion";
            this.bCerrarSesion.Size = new System.Drawing.Size(125, 47);
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
            this.lUsuario.Location = new System.Drawing.Point(1039, 51);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(83, 29);
            this.lUsuario.TabIndex = 33;
            this.lUsuario.Text = "label3";
            this.lUsuario.Visible = false;
            // 
            // bCrearCurso
            // 
            this.bCrearCurso.BackColor = System.Drawing.Color.SteelBlue;
            this.bCrearCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCrearCurso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bCrearCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCrearCurso.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCrearCurso.ForeColor = System.Drawing.Color.White;
            this.bCrearCurso.Location = new System.Drawing.Point(39, 813);
            this.bCrearCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bCrearCurso.Name = "bCrearCurso";
            this.bCrearCurso.Size = new System.Drawing.Size(127, 52);
            this.bCrearCurso.TabIndex = 34;
            this.bCrearCurso.Text = "Crear Curso";
            this.bCrearCurso.UseVisualStyleBackColor = false;
            this.bCrearCurso.Visible = false;
            this.bCrearCurso.Click += new System.EventHandler(this.bCrearCurso_Click);
            // 
            // bEliminarCurso
            // 
            this.bEliminarCurso.BackColor = System.Drawing.Color.SteelBlue;
            this.bEliminarCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEliminarCurso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bEliminarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminarCurso.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bEliminarCurso.ForeColor = System.Drawing.Color.White;
            this.bEliminarCurso.Location = new System.Drawing.Point(209, 813);
            this.bEliminarCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bEliminarCurso.Name = "bEliminarCurso";
            this.bEliminarCurso.Size = new System.Drawing.Size(123, 52);
            this.bEliminarCurso.TabIndex = 37;
            this.bEliminarCurso.Text = "Eliminar Curso";
            this.bEliminarCurso.UseVisualStyleBackColor = false;
            this.bEliminarCurso.Visible = false;
            this.bEliminarCurso.Click += new System.EventHandler(this.bEliminarCurso_Click);
            // 
            // pApreservi
            // 
            this.pApreservi.BackColor = System.Drawing.Color.Navy;
            this.pApreservi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pApreservi.BackgroundImage")));
            this.pApreservi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pApreservi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pApreservi.Location = new System.Drawing.Point(14, 27);
            this.pApreservi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pApreservi.Name = "pApreservi";
            this.pApreservi.Size = new System.Drawing.Size(226, 67);
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
            this.bIniciarSesion.Location = new System.Drawing.Point(978, 47);
            this.bIniciarSesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bIniciarSesion.Name = "bIniciarSesion";
            this.bIniciarSesion.Size = new System.Drawing.Size(127, 44);
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
            this.bRegistrarse.Location = new System.Drawing.Point(1112, 47);
            this.bRegistrarse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bRegistrarse.Name = "bRegistrarse";
            this.bRegistrarse.Size = new System.Drawing.Size(103, 44);
            this.bRegistrarse.TabIndex = 67;
            this.bRegistrarse.Text = "Registrarse";
            this.bRegistrarse.UseVisualStyleBackColor = false;
            this.bRegistrarse.Visible = false;
            this.bRegistrarse.Click += new System.EventHandler(this.bRegistrarse_Click);
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1403, 881);
            this.Controls.Add(this.bRegistrarse);
            this.Controls.Add(this.pApreservi);
            this.Controls.Add(this.bEliminarCurso);
            this.Controls.Add(this.bCrearCurso);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.bCerrarSesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lOtrosCursos);
            this.Controls.Add(this.mCalendario);
            this.Controls.Add(this.pImagen);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lMisCursos);
            this.Controls.Add(this.bPerfil);
            this.Controls.Add(this.lCalendario);
            this.Controls.Add(this.noticias);
            this.Controls.Add(this.bIniciarSesion);
            this.Controls.Add(this.titulo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApreServi";
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
        private System.Windows.Forms.ListBox lMisCursos;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Label lCalendario;
        private System.Windows.Forms.Label noticias;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ListBox lOtrosCursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCerrarSesion;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Button bCrearCurso;
        private System.Windows.Forms.Button bEliminarCurso;
        private System.Windows.Forms.PictureBox pApreservi;
        private System.Windows.Forms.Button bActividades;
        private System.Windows.Forms.Button bIniciarSesion;
        private System.Windows.Forms.Button bRegistrarse;
    }
}