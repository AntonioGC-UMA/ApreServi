
namespace ApreServi
{
    partial class PantallaInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            this.titulo = new System.Windows.Forms.Label();
            this.noticias = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bIniciarSesion = new System.Windows.Forms.Button();
            this.bRegistrarse = new System.Windows.Forms.Button();
            this.lForos = new System.Windows.Forms.ListBox();
            this.bSalir = new System.Windows.Forms.Button();
            this.pApreservi = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bAyuda = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bActividades = new System.Windows.Forms.Button();
            this.fNoticias = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pApreservi)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Navy;
            this.titulo.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.Location = new System.Drawing.Point(0, -1);
            this.titulo.Name = "titulo";
            this.titulo.Padding = new System.Windows.Forms.Padding(0, 25, 800, 25);
            this.titulo.Size = new System.Drawing.Size(1227, 92);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Bienvenido a ApreServi";
            // 
            // noticias
            // 
            this.noticias.AutoSize = true;
            this.noticias.BackColor = System.Drawing.Color.DodgerBlue;
            this.noticias.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noticias.ForeColor = System.Drawing.Color.White;
            this.noticias.Location = new System.Drawing.Point(45, 147);
            this.noticias.Name = "noticias";
            this.noticias.Padding = new System.Windows.Forms.Padding(74, 0, 74, 0);
            this.noticias.Size = new System.Drawing.Size(428, 32);
            this.noticias.TabIndex = 1;
            this.noticias.Text = "Noticias destacadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(564, 147);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(188, 0, 189, 10);
            this.label1.Size = new System.Drawing.Size(605, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Foros generales";
            // 
            // bIniciarSesion
            // 
            this.bIniciarSesion.BackColor = System.Drawing.Color.SteelBlue;
            this.bIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIniciarSesion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.bIniciarSesion.Location = new System.Drawing.Point(826, 29);
            this.bIniciarSesion.Name = "bIniciarSesion";
            this.bIniciarSesion.Size = new System.Drawing.Size(122, 33);
            this.bIniciarSesion.TabIndex = 4;
            this.bIniciarSesion.Text = "Iniciar Sesion";
            this.bIniciarSesion.UseVisualStyleBackColor = false;
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
            this.bRegistrarse.Location = new System.Drawing.Point(964, 29);
            this.bRegistrarse.Name = "bRegistrarse";
            this.bRegistrarse.Size = new System.Drawing.Size(127, 33);
            this.bRegistrarse.TabIndex = 5;
            this.bRegistrarse.Text = "Registrarse";
            this.bRegistrarse.UseVisualStyleBackColor = false;
            this.bRegistrarse.Click += new System.EventHandler(this.bRegistrarse_Click);
            // 
            // lForos
            // 
            this.lForos.BackColor = System.Drawing.Color.White;
            this.lForos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lForos.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lForos.FormattingEnabled = true;
            this.lForos.ItemHeight = 23;
            this.lForos.Location = new System.Drawing.Point(564, 182);
            this.lForos.Name = "lForos";
            this.lForos.Size = new System.Drawing.Size(605, 418);
            this.lForos.TabIndex = 6;
            this.lForos.DoubleClick += new System.EventHandler(this.lForos_SelectedIndexChanged);
            // 
            // bSalir
            // 
            this.bSalir.BackColor = System.Drawing.Color.SteelBlue;
            this.bSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSalir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bSalir.ForeColor = System.Drawing.Color.White;
            this.bSalir.Location = new System.Drawing.Point(1107, 29);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(91, 33);
            this.bSalir.TabIndex = 8;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = false;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // pApreservi
            // 
            this.pApreservi.BackColor = System.Drawing.Color.Navy;
            this.pApreservi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pApreservi.BackgroundImage")));
            this.pApreservi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pApreservi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pApreservi.Location = new System.Drawing.Point(242, 21);
            this.pApreservi.Name = "pApreservi";
            this.pApreservi.Size = new System.Drawing.Size(198, 50);
            this.pApreservi.TabIndex = 49;
            this.pApreservi.TabStop = false;
            this.pApreservi.Click += new System.EventHandler(this.pApreservi_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Navy;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.bAyuda, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.bNoticias, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bCursos, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bActividades, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(446, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(357, 42);
            this.tableLayoutPanel2.TabIndex = 51;
            // 
            // bAyuda
            // 
            this.bAyuda.BackColor = System.Drawing.Color.SteelBlue;
            this.bAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAyuda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAyuda.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAyuda.ForeColor = System.Drawing.Color.White;
            this.bAyuda.Location = new System.Drawing.Point(287, 3);
            this.bAyuda.Name = "bAyuda";
            this.bAyuda.Size = new System.Drawing.Size(67, 35);
            this.bAyuda.TabIndex = 3;
            this.bAyuda.Text = "Ayuda";
            this.bAyuda.UseVisualStyleBackColor = false;
            this.bAyuda.Visible = false;
            this.bAyuda.Click += new System.EventHandler(this.bAyuda_Click);
            // 
            // bNoticias
            // 
            this.bNoticias.BackColor = System.Drawing.Color.SteelBlue;
            this.bNoticias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNoticias.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bNoticias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNoticias.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bNoticias.ForeColor = System.Drawing.Color.White;
            this.bNoticias.Location = new System.Drawing.Point(3, 3);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(83, 35);
            this.bNoticias.TabIndex = 1;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = false;
            this.bNoticias.Click += new System.EventHandler(this.bNoticias_Click);
            // 
            // bCursos
            // 
            this.bCursos.BackColor = System.Drawing.Color.SteelBlue;
            this.bCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCursos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCursos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCursos.ForeColor = System.Drawing.Color.White;
            this.bCursos.Location = new System.Drawing.Point(92, 3);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(65, 35);
            this.bCursos.TabIndex = 2;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = false;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bActividades
            // 
            this.bActividades.BackColor = System.Drawing.Color.SteelBlue;
            this.bActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bActividades.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bActividades.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bActividades.ForeColor = System.Drawing.Color.White;
            this.bActividades.Location = new System.Drawing.Point(163, 3);
            this.bActividades.Name = "bActividades";
            this.bActividades.Size = new System.Drawing.Size(118, 35);
            this.bActividades.TabIndex = 4;
            this.bActividades.Text = "Actividades";
            this.bActividades.UseVisualStyleBackColor = false;
            this.bActividades.Click += new System.EventHandler(this.bActividades_Click);
            // 
            // fNoticias
            // 
            this.fNoticias.BackColor = System.Drawing.Color.White;
            this.fNoticias.Location = new System.Drawing.Point(45, 183);
            this.fNoticias.Name = "fNoticias";
            this.fNoticias.Size = new System.Drawing.Size(480, 417);
            this.fNoticias.TabIndex = 74;
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1228, 661);
            this.Controls.Add(this.fNoticias);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pApreservi);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.lForos);
            this.Controls.Add(this.bRegistrarse);
            this.Controls.Add(this.bIniciarSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noticias);
            this.Controls.Add(this.titulo);
            this.MaximizeBox = false;
            this.Name = "PantallaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApreServi";
            this.Load += new System.EventHandler(this.PantallaInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pApreservi)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label noticias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bIniciarSesion;
        private System.Windows.Forms.Button bRegistrarse;
        private System.Windows.Forms.ListBox lForos;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.PictureBox pApreservi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bAyuda;
        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bActividades;
        private System.Windows.Forms.FlowLayoutPanel fNoticias;
    }
}

