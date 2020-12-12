﻿
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bAyuda = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bPerfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.bAbandonar = new System.Windows.Forms.Button();
            this.bCerrarSesion = new System.Windows.Forms.Button();
            this.lUsuario = new System.Windows.Forms.Label();
            this.bAñadir = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.tAñadir = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bBorrarForo = new System.Windows.Forms.Button();
            this.bAñadirForo = new System.Windows.Forms.Button();
            this.lForos = new System.Windows.Forms.ListBox();
            this.Pestañas = new System.Windows.Forms.TabPage();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tPestañas = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Pestañas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tPestañas.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(571, 182);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(662, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.bAyuda, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.bNoticias, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bForos, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bCursos, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(164, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(274, 32);
            this.tableLayoutPanel2.TabIndex = 37;
            // 
            // bAyuda
            // 
            this.bAyuda.Location = new System.Drawing.Point(207, 3);
            this.bAyuda.Name = "bAyuda";
            this.bAyuda.Size = new System.Drawing.Size(64, 26);
            this.bAyuda.TabIndex = 3;
            this.bAyuda.Text = "Ayuda";
            this.bAyuda.UseVisualStyleBackColor = true;
            this.bAyuda.Click += new System.EventHandler(this.bAyuda_Click);
            // 
            // bNoticias
            // 
            this.bNoticias.Location = new System.Drawing.Point(71, 3);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(62, 26);
            this.bNoticias.TabIndex = 1;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            this.bNoticias.Click += new System.EventHandler(this.bNoticias_Click);
            // 
            // bForos
            // 
            this.bForos.Location = new System.Drawing.Point(3, 3);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(62, 26);
            this.bForos.TabIndex = 0;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = true;
            this.bForos.Click += new System.EventHandler(this.bForos_Click);
            // 
            // bCursos
            // 
            this.bCursos.Location = new System.Drawing.Point(139, 3);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(62, 26);
            this.bCursos.TabIndex = 2;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bPerfil
            // 
            this.bPerfil.Location = new System.Drawing.Point(652, 110);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(111, 23);
            this.bPerfil.TabIndex = 35;
            this.bPerfil.Text = "Mi perfil";
            this.bPerfil.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Calendario de eventos";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titulo.Location = new System.Drawing.Point(12, 28);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(146, 32);
            this.titulo.TabIndex = 32;
            this.titulo.Text = "ApreServi";
            // 
            // bAbandonar
            // 
            this.bAbandonar.Location = new System.Drawing.Point(607, 396);
            this.bAbandonar.Name = "bAbandonar";
            this.bAbandonar.Size = new System.Drawing.Size(111, 23);
            this.bAbandonar.TabIndex = 40;
            this.bAbandonar.Text = "Abandonar Curso";
            this.bAbandonar.UseVisualStyleBackColor = true;
            this.bAbandonar.Click += new System.EventHandler(this.bAbandonar_Click);
            // 
            // bCerrarSesion
            // 
            this.bCerrarSesion.Location = new System.Drawing.Point(458, 40);
            this.bCerrarSesion.Name = "bCerrarSesion";
            this.bCerrarSesion.Size = new System.Drawing.Size(87, 23);
            this.bCerrarSesion.TabIndex = 41;
            this.bCerrarSesion.Text = "Cerrar Sesión";
            this.bCerrarSesion.UseVisualStyleBackColor = true;
            this.bCerrarSesion.Click += new System.EventHandler(this.bCerrarSesion_Click);
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lUsuario.Location = new System.Drawing.Point(562, 43);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(81, 23);
            this.lUsuario.TabIndex = 42;
            this.lUsuario.Text = "usuario";
            this.lUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bAñadir
            // 
            this.bAñadir.Location = new System.Drawing.Point(571, 396);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(75, 23);
            this.bAñadir.TabIndex = 43;
            this.bAñadir.Text = "Añadir";
            this.bAñadir.UseVisualStyleBackColor = true;
            this.bAñadir.Visible = false;
            this.bAñadir.Click += new System.EventHandler(this.bAñadir_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(677, 357);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 23);
            this.bBorrar.TabIndex = 44;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Visible = false;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(571, 357);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 45;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // tAñadir
            // 
            this.tAñadir.Location = new System.Drawing.Point(672, 397);
            this.tAñadir.Name = "tAñadir";
            this.tAñadir.Size = new System.Drawing.Size(100, 23);
            this.tAñadir.TabIndex = 46;
            this.tAñadir.Visible = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(497, 281);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Examenes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bBorrarForo);
            this.tabPage2.Controls.Add(this.bAñadirForo);
            this.tabPage2.Controls.Add(this.lForos);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(497, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Foros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bBorrarForo
            // 
            this.bBorrarForo.Location = new System.Drawing.Point(86, 252);
            this.bBorrarForo.Name = "bBorrarForo";
            this.bBorrarForo.Size = new System.Drawing.Size(75, 23);
            this.bBorrarForo.TabIndex = 10;
            this.bBorrarForo.Text = "Borrar";
            this.bBorrarForo.UseVisualStyleBackColor = true;
            this.bBorrarForo.Visible = false;
            this.bBorrarForo.Click += new System.EventHandler(this.bBorrarForo_Click);
            // 
            // bAñadirForo
            // 
            this.bAñadirForo.Location = new System.Drawing.Point(4, 253);
            this.bAñadirForo.Name = "bAñadirForo";
            this.bAñadirForo.Size = new System.Drawing.Size(75, 23);
            this.bAñadirForo.TabIndex = 9;
            this.bAñadirForo.Text = "Añadir";
            this.bAñadirForo.UseVisualStyleBackColor = true;
            this.bAñadirForo.Visible = false;
            this.bAñadirForo.Click += new System.EventHandler(this.bAñadirForo_Click);
            // 
            // lForos
            // 
            this.lForos.FormattingEnabled = true;
            this.lForos.ItemHeight = 15;
            this.lForos.Location = new System.Drawing.Point(3, 3);
            this.lForos.Margin = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.lForos.Name = "lForos";
            this.lForos.Size = new System.Drawing.Size(475, 244);
            this.lForos.TabIndex = 8;
            this.lForos.DoubleClick += new System.EventHandler(this.lForos_SelectedIndexChanged);
            // 
            // Pestañas
            // 
            this.Pestañas.Controls.Add(this.tDescripcion);
            this.Pestañas.Controls.Add(this.pictureBox2);
            this.Pestañas.Location = new System.Drawing.Point(4, 24);
            this.Pestañas.Name = "Pestañas";
            this.Pestañas.Padding = new System.Windows.Forms.Padding(3);
            this.Pestañas.Size = new System.Drawing.Size(497, 281);
            this.Pestañas.TabIndex = 0;
            this.Pestañas.Text = "Descripcion";
            this.Pestañas.UseVisualStyleBackColor = true;
            // 
            // tDescripcion
            // 
            this.tDescripcion.Location = new System.Drawing.Point(177, 12);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.ReadOnly = true;
            this.tDescripcion.Size = new System.Drawing.Size(303, 257);
            this.tDescripcion.TabIndex = 2;
            this.tDescripcion.Text = resources.GetString("tDescripcion.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(27, 76);
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
            this.tPestañas.Location = new System.Drawing.Point(38, 110);
            this.tPestañas.Name = "tPestañas";
            this.tPestañas.SelectedIndex = 0;
            this.tPestañas.Size = new System.Drawing.Size(505, 309);
            this.tPestañas.TabIndex = 2;
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tAñadir);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bAñadir);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.bCerrarSesion);
            this.Controls.Add(this.bAbandonar);
            this.Controls.Add(this.tPestañas);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.bPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Name = "Curso";
            this.Text = "ApreServi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.Pestañas.ResumeLayout(false);
            this.Pestañas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tPestañas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bAyuda;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.Button bForos;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button bAbandonar;
        private System.Windows.Forms.Button bCerrarSesion;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Button bAñadir;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox tAñadir;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lForos;
        private System.Windows.Forms.TabPage Pestañas;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tPestañas;
        private System.Windows.Forms.Button bBorrarForo;
        private System.Windows.Forms.Button bAñadirForo;
    }
}