
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bAyuda = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.lMisCursos = new System.Windows.Forms.ListBox();
            this.bPerfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.noticias = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.lOtrosCursos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bCerrarSesion = new System.Windows.Forms.Button();
            this.lUsuario = new System.Windows.Forms.Label();
            this.bCrearCurso = new System.Windows.Forms.Button();
            this.bEliminarCurso = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1141, 288);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1239, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Navy;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.bAyuda, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.bCursos, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.bNoticias, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bForos, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(274, 39);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(430, 55);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // bAyuda
            // 
            this.bAyuda.BackColor = System.Drawing.Color.SteelBlue;
            this.bAyuda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAyuda.ForeColor = System.Drawing.Color.White;
            this.bAyuda.Location = new System.Drawing.Point(324, 4);
            this.bAyuda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bAyuda.Name = "bAyuda";
            this.bAyuda.Size = new System.Drawing.Size(101, 47);
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
            this.bCursos.ForeColor = System.Drawing.Color.White;
            this.bCursos.Location = new System.Drawing.Point(217, 4);
            this.bCursos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(101, 47);
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
            this.bNoticias.ForeColor = System.Drawing.Color.White;
            this.bNoticias.Location = new System.Drawing.Point(110, 4);
            this.bNoticias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(101, 47);
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
            this.bForos.ForeColor = System.Drawing.Color.White;
            this.bForos.Location = new System.Drawing.Point(3, 4);
            this.bForos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(101, 47);
            this.bForos.TabIndex = 0;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = false;
            this.bForos.Click += new System.EventHandler(this.bForos_Click);
            // 
            // lMisCursos
            // 
            this.lMisCursos.ColumnWidth = 60;
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
            this.bPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPerfil.ForeColor = System.Drawing.Color.White;
            this.bPerfil.Location = new System.Drawing.Point(1239, 161);
            this.bPerfil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(121, 48);
            this.bPerfil.TabIndex = 23;
            this.bPerfil.Text = "Mi perfil";
            this.bPerfil.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1142, 239);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(23, 13, 19, 13);
            this.label1.Size = new System.Drawing.Size(216, 44);
            this.label1.TabIndex = 22;
            this.label1.Text = "Calendario de eventos";
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
            this.bCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.bCerrarSesion.Location = new System.Drawing.Point(872, 47);
            this.bCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bCerrarSesion.Name = "bCerrarSesion";
            this.bCerrarSesion.Size = new System.Drawing.Size(104, 47);
            this.bCerrarSesion.TabIndex = 32;
            this.bCerrarSesion.Text = "Cerrar Sesión";
            this.bCerrarSesion.UseVisualStyleBackColor = false;
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
            // 
            // bCrearCurso
            // 
            this.bCrearCurso.BackColor = System.Drawing.Color.SteelBlue;
            this.bCrearCurso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bCrearCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.bEliminarCurso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bEliminarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminarCurso.ForeColor = System.Drawing.Color.White;
            this.bEliminarCurso.Location = new System.Drawing.Point(209, 813);
            this.bEliminarCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bEliminarCurso.Name = "bEliminarCurso";
            this.bEliminarCurso.Size = new System.Drawing.Size(118, 52);
            this.bEliminarCurso.TabIndex = 37;
            this.bEliminarCurso.Text = "Eliminar Curso";
            this.bEliminarCurso.UseVisualStyleBackColor = false;
            this.bEliminarCurso.Visible = false;
            this.bEliminarCurso.Click += new System.EventHandler(this.bEliminarCurso_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(14, 27);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(226, 67);
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1403, 881);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bEliminarCurso);
            this.Controls.Add(this.bCrearCurso);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.bCerrarSesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lOtrosCursos);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lMisCursos);
            this.Controls.Add(this.bPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noticias);
            this.Controls.Add(this.titulo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApreServi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.ListBox lMisCursos;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label noticias;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ListBox lOtrosCursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCerrarSesion;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Button bCrearCurso;
        private System.Windows.Forms.Button bEliminarCurso;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}