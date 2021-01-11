
namespace ApreServi
{
    partial class CrearTest
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
            this.tEnunciado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bCrear = new System.Windows.Forms.Button();
            this.bAñadirPregunta = new System.Windows.Forms.Button();
            this.bEliminarPregunta = new System.Windows.Forms.Button();
            this.bEliminarOpcion = new System.Windows.Forms.Button();
            this.bAñadirOpcion = new System.Windows.Forms.Button();
            this.tOpcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lPreguntas = new System.Windows.Forms.ListBox();
            this.lOpciones = new System.Windows.Forms.ListBox();
            this.bMarcarSolucion = new System.Windows.Forms.Button();
            this.tNombreTest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tEnunciado
            // 
            this.tEnunciado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tEnunciado.Location = new System.Drawing.Point(82, 226);
            this.tEnunciado.Name = "tEnunciado";
            this.tEnunciado.Size = new System.Drawing.Size(511, 23);
            this.tEnunciado.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 180);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 10, 246, 10);
            this.label4.Size = new System.Drawing.Size(511, 43);
            this.label4.TabIndex = 39;
            this.label4.Text = "Enunciado de la pregunta";
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.bCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCancelar.ForeColor = System.Drawing.Color.White;
            this.bCancelar.Location = new System.Drawing.Point(684, 539);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(117, 65);
            this.bCancelar.TabIndex = 36;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bCrear
            // 
            this.bCrear.BackColor = System.Drawing.Color.SteelBlue;
            this.bCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCrear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCrear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCrear.ForeColor = System.Drawing.Color.White;
            this.bCrear.Location = new System.Drawing.Point(488, 539);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(149, 65);
            this.bCrear.TabIndex = 42;
            this.bCrear.Text = "Crear cuestionario";
            this.bCrear.UseVisualStyleBackColor = false;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // bAñadirPregunta
            // 
            this.bAñadirPregunta.BackColor = System.Drawing.Color.SteelBlue;
            this.bAñadirPregunta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bAñadirPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAñadirPregunta.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAñadirPregunta.ForeColor = System.Drawing.Color.White;
            this.bAñadirPregunta.Location = new System.Drawing.Point(82, 255);
            this.bAñadirPregunta.Name = "bAñadirPregunta";
            this.bAñadirPregunta.Size = new System.Drawing.Size(83, 38);
            this.bAñadirPregunta.TabIndex = 50;
            this.bAñadirPregunta.Text = "Añadir";
            this.bAñadirPregunta.UseVisualStyleBackColor = false;
            this.bAñadirPregunta.Click += new System.EventHandler(this.bAñadirPregunta_Click);
            // 
            // bEliminarPregunta
            // 
            this.bEliminarPregunta.BackColor = System.Drawing.Color.SteelBlue;
            this.bEliminarPregunta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bEliminarPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminarPregunta.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bEliminarPregunta.ForeColor = System.Drawing.Color.White;
            this.bEliminarPregunta.Location = new System.Drawing.Point(191, 255);
            this.bEliminarPregunta.Name = "bEliminarPregunta";
            this.bEliminarPregunta.Size = new System.Drawing.Size(111, 38);
            this.bEliminarPregunta.TabIndex = 51;
            this.bEliminarPregunta.Text = "Eliminar";
            this.bEliminarPregunta.UseVisualStyleBackColor = false;
            this.bEliminarPregunta.Click += new System.EventHandler(this.bEliminarPregunta_Click);
            // 
            // bEliminarOpcion
            // 
            this.bEliminarOpcion.BackColor = System.Drawing.Color.SteelBlue;
            this.bEliminarOpcion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bEliminarOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminarOpcion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bEliminarOpcion.ForeColor = System.Drawing.Color.White;
            this.bEliminarOpcion.Location = new System.Drawing.Point(191, 423);
            this.bEliminarOpcion.Name = "bEliminarOpcion";
            this.bEliminarOpcion.Size = new System.Drawing.Size(111, 38);
            this.bEliminarOpcion.TabIndex = 55;
            this.bEliminarOpcion.Text = "Eliminar";
            this.bEliminarOpcion.UseVisualStyleBackColor = false;
            // 
            // bAñadirOpcion
            // 
            this.bAñadirOpcion.BackColor = System.Drawing.Color.SteelBlue;
            this.bAñadirOpcion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bAñadirOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAñadirOpcion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAñadirOpcion.ForeColor = System.Drawing.Color.White;
            this.bAñadirOpcion.Location = new System.Drawing.Point(91, 423);
            this.bAñadirOpcion.Name = "bAñadirOpcion";
            this.bAñadirOpcion.Size = new System.Drawing.Size(83, 38);
            this.bAñadirOpcion.TabIndex = 54;
            this.bAñadirOpcion.Text = "Añadir";
            this.bAñadirOpcion.UseVisualStyleBackColor = false;
            this.bAñadirOpcion.Click += new System.EventHandler(this.bAñadirOpcion_Click);
            // 
            // tOpcion
            // 
            this.tOpcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tOpcion.Location = new System.Drawing.Point(83, 394);
            this.tOpcion.Name = "tOpcion";
            this.tOpcion.Size = new System.Drawing.Size(510, 23);
            this.tOpcion.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 348);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 10, 424, 10);
            this.label2.Size = new System.Drawing.Size(511, 43);
            this.label2.TabIndex = 52;
            this.label2.Text = "Opción";
            // 
            // lPreguntas
            // 
            this.lPreguntas.FormattingEnabled = true;
            this.lPreguntas.ItemHeight = 15;
            this.lPreguntas.Location = new System.Drawing.Point(710, 44);
            this.lPreguntas.Name = "lPreguntas";
            this.lPreguntas.Size = new System.Drawing.Size(370, 169);
            this.lPreguntas.TabIndex = 56;
            this.lPreguntas.SelectedIndexChanged += new System.EventHandler(this.lPreguntas_SelectedIndexChanged);
            // 
            // lOpciones
            // 
            this.lOpciones.FormattingEnabled = true;
            this.lOpciones.ItemHeight = 15;
            this.lOpciones.Location = new System.Drawing.Point(710, 297);
            this.lOpciones.Name = "lOpciones";
            this.lOpciones.Size = new System.Drawing.Size(370, 169);
            this.lOpciones.TabIndex = 57;
            // 
            // bMarcarSolucion
            // 
            this.bMarcarSolucion.BackColor = System.Drawing.Color.SteelBlue;
            this.bMarcarSolucion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bMarcarSolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMarcarSolucion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bMarcarSolucion.ForeColor = System.Drawing.Color.White;
            this.bMarcarSolucion.Location = new System.Drawing.Point(320, 423);
            this.bMarcarSolucion.Name = "bMarcarSolucion";
            this.bMarcarSolucion.Size = new System.Drawing.Size(222, 38);
            this.bMarcarSolucion.TabIndex = 58;
            this.bMarcarSolucion.Text = "Elegir como solución";
            this.bMarcarSolucion.UseVisualStyleBackColor = false;
            this.bMarcarSolucion.Click += new System.EventHandler(this.bMarcarSolucion_Click);
            // 
            // tNombreTest
            // 
            this.tNombreTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tNombreTest.Location = new System.Drawing.Point(83, 110);
            this.tNombreTest.Name = "tNombreTest";
            this.tNombreTest.Size = new System.Drawing.Size(510, 23);
            this.tNombreTest.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 60);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 10, 257, 10);
            this.label1.Size = new System.Drawing.Size(512, 43);
            this.label1.TabIndex = 60;
            this.label1.Text = "Nombre del cuestionario";
            // 
            // CrearTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1228, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tNombreTest);
            this.Controls.Add(this.bMarcarSolucion);
            this.Controls.Add(this.lOpciones);
            this.Controls.Add(this.lPreguntas);
            this.Controls.Add(this.bEliminarOpcion);
            this.Controls.Add(this.bAñadirOpcion);
            this.Controls.Add(this.tOpcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bEliminarPregunta);
            this.Controls.Add(this.bAñadirPregunta);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.tEnunciado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bCancelar);
            this.MaximizeBox = false;
            this.Name = "CrearTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApreServi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tEnunciado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.Button bAñadirPregunta;
        private System.Windows.Forms.Button bEliminarPregunta;
        private System.Windows.Forms.Button bEliminarOpcion;
        private System.Windows.Forms.Button bAñadirOpcion;
        private System.Windows.Forms.TextBox tOpcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lPreguntas;
        private System.Windows.Forms.ListBox lOpciones;
        private System.Windows.Forms.Button bMarcarSolucion;
        private System.Windows.Forms.TextBox tNombreTest;
        private System.Windows.Forms.Label label1;
    }
}