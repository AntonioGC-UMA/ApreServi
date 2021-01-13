
namespace ApreServi
{
    partial class Curso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Curso));
            this.mCalendario = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bPerfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bAbandonar = new System.Windows.Forms.Button();
            this.bCerrarSesion = new System.Windows.Forms.Button();
            this.lUsuario = new System.Windows.Forms.Label();
            this.bAñadirTest = new System.Windows.Forms.Button();
            this.bBorrarTest = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.bCalificaciones = new System.Windows.Forms.Button();
            this.lTest = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bBorrarForo = new System.Windows.Forms.Button();
            this.bAñadirForo = new System.Windows.Forms.Button();
            this.lForos = new System.Windows.Forms.ListBox();
            this.Pestañas = new System.Windows.Forms.TabPage();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tPestañas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bEnviar = new System.Windows.Forms.Button();
            this.tMejora = new System.Windows.Forms.TextBox();
            this.tOpinion = new System.Windows.Forms.TextBox();
            this.cProfesor = new System.Windows.Forms.CheckedListBox();
            this.cValoración = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lArchivos = new System.Windows.Forms.ListBox();
            this.bEliminarArchivo = new System.Windows.Forms.Button();
            this.bSubirArchivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pApreservi = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bAyuda = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.bActividades = new System.Windows.Forms.Button();
            this.bIntegrantes = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Pestañas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tPestañas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pApreservi)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mCalendario
            // 
            this.mCalendario.Location = new System.Drawing.Point(996, 216);
            this.mCalendario.Name = "mCalendario";
            this.mCalendario.TabIndex = 39;
            this.mCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1082, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // bPerfil
            // 
            this.bPerfil.BackColor = System.Drawing.Color.SteelBlue;
            this.bPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPerfil.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bPerfil.ForeColor = System.Drawing.Color.White;
            this.bPerfil.Location = new System.Drawing.Point(1082, 121);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(106, 36);
            this.bPerfil.TabIndex = 35;
            this.bPerfil.Text = "Mi perfil";
            this.bPerfil.UseVisualStyleBackColor = false;
            this.bPerfil.Click += new System.EventHandler(this.bPerfil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(996, 179);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 10, 17, 10);
            this.label1.Size = new System.Drawing.Size(191, 36);
            this.label1.TabIndex = 34;
            this.label1.Text = "Calendario de eventos";
            // 
            // bAbandonar
            // 
            this.bAbandonar.BackColor = System.Drawing.Color.SteelBlue;
            this.bAbandonar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAbandonar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bAbandonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAbandonar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAbandonar.ForeColor = System.Drawing.Color.White;
            this.bAbandonar.Location = new System.Drawing.Point(1055, 595);
            this.bAbandonar.Name = "bAbandonar";
            this.bAbandonar.Size = new System.Drawing.Size(133, 36);
            this.bAbandonar.TabIndex = 40;
            this.bAbandonar.Text = "Abandonar Curso";
            this.bAbandonar.UseVisualStyleBackColor = false;
            this.bAbandonar.Click += new System.EventHandler(this.bAbandonar_Click);
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
            this.bCerrarSesion.TabIndex = 41;
            this.bCerrarSesion.Text = "Cerrar Sesión";
            this.bCerrarSesion.UseVisualStyleBackColor = false;
            this.bCerrarSesion.Click += new System.EventHandler(this.bCerrarSesion_Click);
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.BackColor = System.Drawing.Color.DarkBlue;
            this.lUsuario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lUsuario.ForeColor = System.Drawing.Color.White;
            this.lUsuario.Location = new System.Drawing.Point(909, 38);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(81, 23);
            this.lUsuario.TabIndex = 42;
            this.lUsuario.Text = "usuario";
            this.lUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bAñadirTest
            // 
            this.bAñadirTest.BackColor = System.Drawing.Color.SteelBlue;
            this.bAñadirTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAñadirTest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bAñadirTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAñadirTest.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAñadirTest.ForeColor = System.Drawing.Color.White;
            this.bAñadirTest.Location = new System.Drawing.Point(3, 451);
            this.bAñadirTest.Name = "bAñadirTest";
            this.bAñadirTest.Size = new System.Drawing.Size(83, 38);
            this.bAñadirTest.TabIndex = 43;
            this.bAñadirTest.Text = "Añadir";
            this.bAñadirTest.UseVisualStyleBackColor = false;
            this.bAñadirTest.Visible = false;
            this.bAñadirTest.Click += new System.EventHandler(this.bAñadir_Click);
            // 
            // bBorrarTest
            // 
            this.bBorrarTest.BackColor = System.Drawing.Color.SteelBlue;
            this.bBorrarTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBorrarTest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bBorrarTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBorrarTest.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bBorrarTest.ForeColor = System.Drawing.Color.White;
            this.bBorrarTest.Location = new System.Drawing.Point(105, 451);
            this.bBorrarTest.Name = "bBorrarTest";
            this.bBorrarTest.Size = new System.Drawing.Size(104, 39);
            this.bBorrarTest.TabIndex = 44;
            this.bBorrarTest.Text = "Borrar";
            this.bBorrarTest.UseVisualStyleBackColor = false;
            this.bBorrarTest.Visible = false;
            this.bBorrarTest.Click += new System.EventHandler(this.bBorrarTest_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.bGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bGuardar.ForeColor = System.Drawing.Color.White;
            this.bGuardar.Location = new System.Drawing.Point(19, 448);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(106, 38);
            this.bGuardar.TabIndex = 45;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.bCalificaciones);
            this.tabPage5.Controls.Add(this.lTest);
            this.tabPage5.Controls.Add(this.bAñadirTest);
            this.tabPage5.Controls.Add(this.bBorrarTest);
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(948, 501);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Examenes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // bCalificaciones
            // 
            this.bCalificaciones.BackColor = System.Drawing.Color.SteelBlue;
            this.bCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCalificaciones.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCalificaciones.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCalificaciones.ForeColor = System.Drawing.Color.White;
            this.bCalificaciones.Location = new System.Drawing.Point(828, 451);
            this.bCalificaciones.Name = "bCalificaciones";
            this.bCalificaciones.Size = new System.Drawing.Size(106, 38);
            this.bCalificaciones.TabIndex = 82;
            this.bCalificaciones.Text = "Calificaciones";
            this.bCalificaciones.UseVisualStyleBackColor = false;
            this.bCalificaciones.Click += new System.EventHandler(this.bCalificaciones_Click);
            // 
            // lTest
            // 
            this.lTest.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lTest.FormattingEnabled = true;
            this.lTest.ItemHeight = 23;
            this.lTest.Location = new System.Drawing.Point(0, 0);
            this.lTest.Name = "lTest";
            this.lTest.Size = new System.Drawing.Size(948, 441);
            this.lTest.TabIndex = 0;
            this.lTest.DoubleClick += new System.EventHandler(this.lTest_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bBorrarForo);
            this.tabPage2.Controls.Add(this.bAñadirForo);
            this.tabPage2.Controls.Add(this.lForos);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(948, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Foros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bBorrarForo
            // 
            this.bBorrarForo.BackColor = System.Drawing.Color.SteelBlue;
            this.bBorrarForo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bBorrarForo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBorrarForo.ForeColor = System.Drawing.Color.White;
            this.bBorrarForo.Location = new System.Drawing.Point(97, 463);
            this.bBorrarForo.Name = "bBorrarForo";
            this.bBorrarForo.Size = new System.Drawing.Size(87, 34);
            this.bBorrarForo.TabIndex = 10;
            this.bBorrarForo.Text = "Borrar";
            this.bBorrarForo.UseVisualStyleBackColor = false;
            this.bBorrarForo.Visible = false;
            this.bBorrarForo.Click += new System.EventHandler(this.bBorrarForo_Click);
            // 
            // bAñadirForo
            // 
            this.bAñadirForo.BackColor = System.Drawing.Color.SteelBlue;
            this.bAñadirForo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bAñadirForo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAñadirForo.ForeColor = System.Drawing.Color.White;
            this.bAñadirForo.Location = new System.Drawing.Point(3, 463);
            this.bAñadirForo.Name = "bAñadirForo";
            this.bAñadirForo.Size = new System.Drawing.Size(87, 34);
            this.bAñadirForo.TabIndex = 9;
            this.bAñadirForo.Text = "Añadir";
            this.bAñadirForo.UseVisualStyleBackColor = false;
            this.bAñadirForo.Visible = false;
            this.bAñadirForo.Click += new System.EventHandler(this.bAñadirForo_Click);
            // 
            // lForos
            // 
            this.lForos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lForos.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lForos.FormattingEnabled = true;
            this.lForos.ItemHeight = 23;
            this.lForos.Location = new System.Drawing.Point(3, 3);
            this.lForos.Margin = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.lForos.Name = "lForos";
            this.lForos.Size = new System.Drawing.Size(940, 437);
            this.lForos.TabIndex = 8;
            this.lForos.DoubleClick += new System.EventHandler(this.lForos_SelectedIndexChanged);
            // 
            // Pestañas
            // 
            this.Pestañas.Controls.Add(this.tDescripcion);
            this.Pestañas.Controls.Add(this.pictureBox2);
            this.Pestañas.Controls.Add(this.bGuardar);
            this.Pestañas.Location = new System.Drawing.Point(4, 23);
            this.Pestañas.Name = "Pestañas";
            this.Pestañas.Padding = new System.Windows.Forms.Padding(3);
            this.Pestañas.Size = new System.Drawing.Size(948, 501);
            this.Pestañas.TabIndex = 0;
            this.Pestañas.Text = "Descripcion";
            this.Pestañas.UseVisualStyleBackColor = true;
            // 
            // tDescripcion
            // 
            this.tDescripcion.BackColor = System.Drawing.Color.White;
            this.tDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDescripcion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tDescripcion.Location = new System.Drawing.Point(177, 12);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.ReadOnly = true;
            this.tDescripcion.Size = new System.Drawing.Size(751, 474);
            this.tDescripcion.TabIndex = 2;
            this.tDescripcion.Text = resources.GetString("tDescripcion.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(19, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 134);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tPestañas
            // 
            this.tPestañas.Controls.Add(this.Pestañas);
            this.tPestañas.Controls.Add(this.tabPage2);
            this.tPestañas.Controls.Add(this.tabPage5);
            this.tPestañas.Controls.Add(this.tabPage1);
            this.tPestañas.Controls.Add(this.tabPage3);
            this.tPestañas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tPestañas.Location = new System.Drawing.Point(12, 121);
            this.tPestañas.Name = "tPestañas";
            this.tPestañas.SelectedIndex = 0;
            this.tPestañas.Size = new System.Drawing.Size(956, 528);
            this.tPestañas.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bEnviar);
            this.tabPage1.Controls.Add(this.tMejora);
            this.tabPage1.Controls.Add(this.tOpinion);
            this.tabPage1.Controls.Add(this.cProfesor);
            this.tabPage1.Controls.Add(this.cValoración);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(948, 501);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Cuestionario de satisfacción";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bEnviar
            // 
            this.bEnviar.BackColor = System.Drawing.Color.SteelBlue;
            this.bEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnviar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bEnviar.ForeColor = System.Drawing.Color.White;
            this.bEnviar.Location = new System.Drawing.Point(834, 414);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(75, 38);
            this.bEnviar.TabIndex = 82;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = false;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // tMejora
            // 
            this.tMejora.Location = new System.Drawing.Point(51, 387);
            this.tMejora.Multiline = true;
            this.tMejora.Name = "tMejora";
            this.tMejora.Size = new System.Drawing.Size(605, 65);
            this.tMejora.TabIndex = 7;
            // 
            // tOpinion
            // 
            this.tOpinion.Location = new System.Drawing.Point(51, 258);
            this.tOpinion.Multiline = true;
            this.tOpinion.Name = "tOpinion";
            this.tOpinion.Size = new System.Drawing.Size(605, 65);
            this.tOpinion.TabIndex = 6;
            // 
            // cProfesor
            // 
            this.cProfesor.CheckOnClick = true;
            this.cProfesor.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cProfesor.FormattingEnabled = true;
            this.cProfesor.HorizontalExtent = 5;
            this.cProfesor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cProfesor.Location = new System.Drawing.Point(51, 169);
            this.cProfesor.MultiColumn = true;
            this.cProfesor.Name = "cProfesor";
            this.cProfesor.Size = new System.Drawing.Size(605, 30);
            this.cProfesor.TabIndex = 5;
            // 
            // cValoración
            // 
            this.cValoración.CheckOnClick = true;
            this.cValoración.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cValoración.FormattingEnabled = true;
            this.cValoración.HorizontalExtent = 5;
            this.cValoración.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cValoración.Location = new System.Drawing.Point(51, 70);
            this.cValoración.MultiColumn = true;
            this.cValoración.Name = "cValoración";
            this.cValoración.Size = new System.Drawing.Size(605, 30);
            this.cValoración.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(51, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "¿Qué te ha parecido el curso?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(45, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Valora al profesor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(51, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "¿Qué mejorarías para cursos posteriores?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Valora el curso";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lArchivos);
            this.tabPage3.Controls.Add(this.bEliminarArchivo);
            this.tabPage3.Controls.Add(this.bSubirArchivo);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(948, 501);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "Material";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lArchivos
            // 
            this.lArchivos.FormattingEnabled = true;
            this.lArchivos.ItemHeight = 14;
            this.lArchivos.Location = new System.Drawing.Point(4, 4);
            this.lArchivos.Name = "lArchivos";
            this.lArchivos.Size = new System.Drawing.Size(944, 424);
            this.lArchivos.TabIndex = 84;
            this.lArchivos.DoubleClick += new System.EventHandler(this.lArchivos_DoubleClick);
            // 
            // bEliminarArchivo
            // 
            this.bEliminarArchivo.BackColor = System.Drawing.Color.SteelBlue;
            this.bEliminarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEliminarArchivo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bEliminarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminarArchivo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bEliminarArchivo.ForeColor = System.Drawing.Color.White;
            this.bEliminarArchivo.Location = new System.Drawing.Point(175, 449);
            this.bEliminarArchivo.Name = "bEliminarArchivo";
            this.bEliminarArchivo.Size = new System.Drawing.Size(106, 38);
            this.bEliminarArchivo.TabIndex = 83;
            this.bEliminarArchivo.Text = "Eliminar";
            this.bEliminarArchivo.UseVisualStyleBackColor = false;
            this.bEliminarArchivo.Visible = false;
            this.bEliminarArchivo.Click += new System.EventHandler(this.bEliminarArchivo_Click);
            // 
            // bSubirArchivo
            // 
            this.bSubirArchivo.BackColor = System.Drawing.Color.SteelBlue;
            this.bSubirArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSubirArchivo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bSubirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSubirArchivo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bSubirArchivo.ForeColor = System.Drawing.Color.White;
            this.bSubirArchivo.Location = new System.Drawing.Point(28, 449);
            this.bSubirArchivo.Name = "bSubirArchivo";
            this.bSubirArchivo.Size = new System.Drawing.Size(106, 38);
            this.bSubirArchivo.TabIndex = 82;
            this.bSubirArchivo.Text = "Subir";
            this.bSubirArchivo.UseVisualStyleBackColor = false;
            this.bSubirArchivo.Visible = false;
            this.bSubirArchivo.Click += new System.EventHandler(this.bSubirArchivo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, -1);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 25, 1038, 25);
            this.label2.Size = new System.Drawing.Size(1240, 92);
            this.label2.TabIndex = 47;
            this.label2.Text = " ApreServi";
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
            this.pApreservi.TabIndex = 48;
            this.pApreservi.TabStop = false;
            this.pApreservi.Click += new System.EventHandler(this.pApreservi_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Navy;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.Controls.Add(this.bAyuda, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.bCursos, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bNoticias, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bForos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bActividades, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(240, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 41);
            this.tableLayoutPanel1.TabIndex = 81;
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
            // bIntegrantes
            // 
            this.bIntegrantes.BackColor = System.Drawing.Color.SteelBlue;
            this.bIntegrantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bIntegrantes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bIntegrantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIntegrantes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bIntegrantes.ForeColor = System.Drawing.Color.White;
            this.bIntegrantes.Location = new System.Drawing.Point(1055, 531);
            this.bIntegrantes.Name = "bIntegrantes";
            this.bIntegrantes.Size = new System.Drawing.Size(106, 38);
            this.bIntegrantes.TabIndex = 46;
            this.bIntegrantes.Text = "Integrantes";
            this.bIntegrantes.UseVisualStyleBackColor = false;
            this.bIntegrantes.Visible = false;
            this.bIntegrantes.Click += new System.EventHandler(this.bIntegrantes_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1228, 661);
            this.Controls.Add(this.bIntegrantes);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pApreservi);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.bCerrarSesion);
            this.Controls.Add(this.bAbandonar);
            this.Controls.Add(this.tPestañas);
            this.Controls.Add(this.mCalendario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.Name = "Curso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApreServi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.Pestañas.ResumeLayout(false);
            this.Pestañas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tPestañas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pApreservi)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mCalendario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAbandonar;
        private System.Windows.Forms.Button bCerrarSesion;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Button bAñadirTest;
        private System.Windows.Forms.Button bBorrarTest;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lForos;
        private System.Windows.Forms.TabPage Pestañas;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tPestañas;
        private System.Windows.Forms.Button bBorrarForo;
        private System.Windows.Forms.Button bAñadirForo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pApreservi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bAyuda;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.Button bForos;
        private System.Windows.Forms.Button bActividades;
        private System.Windows.Forms.ListBox lTest;
        private System.Windows.Forms.Button bCalificaciones;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.TextBox tMejora;
        private System.Windows.Forms.TextBox tOpinion;
        private System.Windows.Forms.CheckedListBox cProfesor;
        private System.Windows.Forms.CheckedListBox cValoración;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bIntegrantes;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lArchivos;
        private System.Windows.Forms.Button bEliminarArchivo;
        private System.Windows.Forms.Button bSubirArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}