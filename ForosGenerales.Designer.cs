
namespace ApreServi
{
    partial class ForosGenerales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForosGenerales));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bAyuda = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.lForos = new System.Windows.Forms.ListBox();
            this.bPerfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.noticias = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.bCerrarSesion = new System.Windows.Forms.Button();
            this.lUsuario = new System.Windows.Forms.Label();
            this.bAñadir = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(571, 165);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(662, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.bAyuda, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.bCursos, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.bNoticias, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bForos, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(162, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(274, 32);
            this.tableLayoutPanel2.TabIndex = 26;
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
            // lForos
            // 
            this.lForos.FormattingEnabled = true;
            this.lForos.ItemHeight = 15;
            this.lForos.Location = new System.Drawing.Point(38, 93);
            this.lForos.Name = "lForos";
            this.lForos.Size = new System.Drawing.Size(468, 334);
            this.lForos.TabIndex = 24;
            this.lForos.DoubleClick += new System.EventHandler(this.lForos_SelectedIndexChanged);
            // 
            // bPerfil
            // 
            this.bPerfil.Location = new System.Drawing.Point(652, 93);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(111, 23);
            this.bPerfil.TabIndex = 23;
            this.bPerfil.Text = "Mi perfil";
            this.bPerfil.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Calendario de eventos";
            // 
            // noticias
            // 
            this.noticias.AutoSize = true;
            this.noticias.Location = new System.Drawing.Point(38, 66);
            this.noticias.Name = "noticias";
            this.noticias.Size = new System.Drawing.Size(89, 15);
            this.noticias.TabIndex = 21;
            this.noticias.Text = "Foros generales";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titulo.Location = new System.Drawing.Point(13, 27);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(146, 32);
            this.titulo.TabIndex = 20;
            this.titulo.Text = "ApreServi";
            // 
            // bCerrarSesion
            // 
            this.bCerrarSesion.Location = new System.Drawing.Point(452, 33);
            this.bCerrarSesion.Name = "bCerrarSesion";
            this.bCerrarSesion.Size = new System.Drawing.Size(91, 23);
            this.bCerrarSesion.TabIndex = 29;
            this.bCerrarSesion.Text = "Cerrar Sesión";
            this.bCerrarSesion.UseVisualStyleBackColor = true;
            this.bCerrarSesion.Click += new System.EventHandler(this.bCerrarSesion_Click);
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lUsuario.Location = new System.Drawing.Point(571, 33);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(68, 23);
            this.lUsuario.TabIndex = 30;
            this.lUsuario.Text = "label2";
            // 
            // bAñadir
            // 
            this.bAñadir.Location = new System.Drawing.Point(571, 354);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(75, 23);
            this.bAñadir.TabIndex = 31;
            this.bAñadir.Text = "Añadir";
            this.bAñadir.UseVisualStyleBackColor = true;
            this.bAñadir.Click += new System.EventHandler(this.bAñadir_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(688, 354);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 23);
            this.bBorrar.TabIndex = 32;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // ForosGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bAñadir);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.bCerrarSesion);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lForos);
            this.Controls.Add(this.bPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noticias);
            this.Controls.Add(this.titulo);
            this.Name = "ForosGenerales";
            this.Text = "ForosGenerales";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox lForos;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label noticias;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button bCerrarSesion;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Button bAñadir;
        private System.Windows.Forms.Button bBorrar;
    }
}