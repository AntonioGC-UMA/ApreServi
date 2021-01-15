﻿
namespace ApreServi
{
    partial class Actividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actividad));
            this.mCalendario = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bPerfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bAbandonar = new System.Windows.Forms.Button();
            this.bCerrarSesion = new System.Windows.Forms.Button();
            this.lUsuario = new System.Windows.Forms.Label();
            this.bGuardar = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            this.pApreservi = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bAyuda = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.bActividades = new System.Windows.Forms.Button();
            this.bIntegrantes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.Pestañas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tPestañas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pApreservi)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mCalendario
            // 
            this.mCalendario.Location = new System.Drawing.Point(1138, 288);
            this.mCalendario.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.mCalendario.Name = "mCalendario";
            this.mCalendario.TabIndex = 39;
            this.mCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1237, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // bPerfil
            // 
            this.bPerfil.BackColor = System.Drawing.Color.SteelBlue;
            this.bPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPerfil.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bPerfil.ForeColor = System.Drawing.Color.White;
            this.bPerfil.Location = new System.Drawing.Point(1237, 161);
            this.bPerfil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(121, 48);
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
            this.label1.Location = new System.Drawing.Point(1138, 239);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(23, 13, 19, 13);
            this.label1.Size = new System.Drawing.Size(242, 46);
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
            this.bAbandonar.Location = new System.Drawing.Point(1189, 793);
            this.bAbandonar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bAbandonar.Name = "bAbandonar";
            this.bAbandonar.Size = new System.Drawing.Size(169, 48);
            this.bAbandonar.TabIndex = 40;
            this.bAbandonar.Text = "Abandonar Actividad";
            this.bAbandonar.UseVisualStyleBackColor = false;
            this.bAbandonar.Click += new System.EventHandler(this.bAbandonar_Click);
            // 
            // bCerrarSesion
            // 
            this.bCerrarSesion.BackColor = System.Drawing.Color.SteelBlue;
            this.bCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCerrarSesion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.bCerrarSesion.Location = new System.Drawing.Point(843, 47);
            this.bCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bCerrarSesion.Name = "bCerrarSesion";
            this.bCerrarSesion.Size = new System.Drawing.Size(119, 47);
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
            this.lUsuario.Location = new System.Drawing.Point(1039, 51);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(101, 29);
            this.lUsuario.TabIndex = 42;
            this.lUsuario.Text = "usuario";
            this.lUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.bGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bGuardar.ForeColor = System.Drawing.Color.White;
            this.bGuardar.Location = new System.Drawing.Point(22, 579);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(121, 51);
            this.bGuardar.TabIndex = 45;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bBorrarForo);
            this.tabPage2.Controls.Add(this.bAñadirForo);
            this.tabPage2.Controls.Add(this.lForos);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1085, 671);
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
            this.bBorrarForo.Location = new System.Drawing.Point(111, 617);
            this.bBorrarForo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bBorrarForo.Name = "bBorrarForo";
            this.bBorrarForo.Size = new System.Drawing.Size(99, 45);
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
            this.bAñadirForo.Location = new System.Drawing.Point(3, 617);
            this.bAñadirForo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bAñadirForo.Name = "bAñadirForo";
            this.bAñadirForo.Size = new System.Drawing.Size(99, 45);
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
            this.lForos.ItemHeight = 29;
            this.lForos.Location = new System.Drawing.Point(3, 4);
            this.lForos.Margin = new System.Windows.Forms.Padding(3, 7, 6, 4);
            this.lForos.Name = "lForos";
            this.lForos.Size = new System.Drawing.Size(1074, 551);
            this.lForos.TabIndex = 8;
            this.lForos.DoubleClick += new System.EventHandler(this.lForos_SelectedIndexChanged);
            // 
            // Pestañas
            // 
            this.Pestañas.Controls.Add(this.tDescripcion);
            this.Pestañas.Controls.Add(this.pictureBox2);
            this.Pestañas.Controls.Add(this.bGuardar);
            this.Pestañas.Location = new System.Drawing.Point(4, 29);
            this.Pestañas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pestañas.Name = "Pestañas";
            this.Pestañas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pestañas.Size = new System.Drawing.Size(1085, 671);
            this.Pestañas.TabIndex = 0;
            this.Pestañas.Text = "Descripcion";
            this.Pestañas.UseVisualStyleBackColor = true;
            // 
            // tDescripcion
            // 
            this.tDescripcion.BackColor = System.Drawing.Color.White;
            this.tDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDescripcion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tDescripcion.Location = new System.Drawing.Point(202, 16);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.ReadOnly = true;
            this.tDescripcion.Size = new System.Drawing.Size(858, 632);
            this.tDescripcion.TabIndex = 2;
            this.tDescripcion.Text = resources.GetString("tDescripcion.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(22, 45);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 179);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tPestañas
            // 
            this.tPestañas.Controls.Add(this.Pestañas);
            this.tPestañas.Controls.Add(this.tabPage2);
            this.tPestañas.Controls.Add(this.tabPage1);
            this.tPestañas.Location = new System.Drawing.Point(14, 161);
            this.tPestañas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tPestañas.Name = "tPestañas";
            this.tPestañas.SelectedIndex = 0;
            this.tPestañas.Size = new System.Drawing.Size(1093, 704);
            this.tPestañas.TabIndex = 2;
            this.tPestañas.SelectedIndexChanged += new System.EventHandler(this.tPestañas_SelectedIndexChanged);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1085, 671);
            this.tabPage1.TabIndex = 2;
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
            this.bEnviar.Location = new System.Drawing.Point(950, 565);
            this.bEnviar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(86, 51);
            this.bEnviar.TabIndex = 91;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = false;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // tMejora
            // 
            this.tMejora.Location = new System.Drawing.Point(55, 529);
            this.tMejora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tMejora.Multiline = true;
            this.tMejora.Name = "tMejora";
            this.tMejora.Size = new System.Drawing.Size(691, 85);
            this.tMejora.TabIndex = 90;
            // 
            // tOpinion
            // 
            this.tOpinion.Location = new System.Drawing.Point(55, 357);
            this.tOpinion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tOpinion.Multiline = true;
            this.tOpinion.Name = "tOpinion";
            this.tOpinion.Size = new System.Drawing.Size(691, 85);
            this.tOpinion.TabIndex = 89;
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
            this.cProfesor.Location = new System.Drawing.Point(55, 239);
            this.cProfesor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cProfesor.MultiColumn = true;
            this.cProfesor.Name = "cProfesor";
            this.cProfesor.Size = new System.Drawing.Size(691, 35);
            this.cProfesor.TabIndex = 88;
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
            this.cValoración.Location = new System.Drawing.Point(55, 107);
            this.cValoración.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cValoración.MultiColumn = true;
            this.cValoración.Name = "cValoración";
            this.cValoración.Size = new System.Drawing.Size(691, 35);
            this.cValoración.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(55, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(407, 29);
            this.label6.TabIndex = 86;
            this.label6.Text = "¿Qué te ha parecido la actividad?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(48, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(453, 29);
            this.label5.TabIndex = 85;
            this.label5.Text = "Valora la organización de la actividad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(55, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(516, 29);
            this.label4.TabIndex = 84;
            this.label4.Text = "¿Qué mejorarías para actividades futuras?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 29);
            this.label3.TabIndex = 83;
            this.label3.Text = "Valora la actividad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, -1);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 33, 1186, 33);
            this.label2.Size = new System.Drawing.Size(1439, 119);
            this.label2.TabIndex = 47;
            this.label2.Text = " ApreServi";
            // 
            // pApreservi
            // 
            this.pApreservi.BackColor = System.Drawing.Color.Navy;
            this.pApreservi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pApreservi.BackgroundImage")));
            this.pApreservi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pApreservi.Location = new System.Drawing.Point(14, 27);
            this.pApreservi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pApreservi.Name = "pApreservi";
            this.pApreservi.Size = new System.Drawing.Size(226, 67);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(274, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 55);
            this.tableLayoutPanel1.TabIndex = 81;
            // 
            // bAyuda
            // 
            this.bAyuda.BackColor = System.Drawing.Color.SteelBlue;
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
            // bIntegrantes
            // 
            this.bIntegrantes.BackColor = System.Drawing.Color.SteelBlue;
            this.bIntegrantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bIntegrantes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bIntegrantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIntegrantes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bIntegrantes.ForeColor = System.Drawing.Color.White;
            this.bIntegrantes.Location = new System.Drawing.Point(1189, 713);
            this.bIntegrantes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bIntegrantes.Name = "bIntegrantes";
            this.bIntegrantes.Size = new System.Drawing.Size(169, 51);
            this.bIntegrantes.TabIndex = 82;
            this.bIntegrantes.Text = "Integrantes";
            this.bIntegrantes.UseVisualStyleBackColor = false;
            this.bIntegrantes.Visible = false;
            this.bIntegrantes.Click += new System.EventHandler(this.bIntegrantes_Click);
            // 
            // Actividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1403, 881);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Actividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApreServi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.Pestañas.ResumeLayout(false);
            this.Pestañas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tPestañas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Button bGuardar;
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
    }
}