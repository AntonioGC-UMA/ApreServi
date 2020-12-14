
namespace ApreServi
{
    partial class CrearForo
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
            this.bConfirmar = new System.Windows.Forms.Button();
            this.tNombreForo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tContenido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.cCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bConfirmar
            // 
            this.bConfirmar.BackColor = System.Drawing.Color.SteelBlue;
            this.bConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConfirmar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bConfirmar.ForeColor = System.Drawing.Color.White;
            this.bConfirmar.Location = new System.Drawing.Point(898, 314);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(117, 65);
            this.bConfirmar.TabIndex = 34;
            this.bConfirmar.Text = "Crear foro";
            this.bConfirmar.UseVisualStyleBackColor = false;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // tNombreForo
            // 
            this.tNombreForo.Location = new System.Drawing.Point(82, 142);
            this.tNombreForo.Name = "tNombreForo";
            this.tNombreForo.Size = new System.Drawing.Size(342, 23);
            this.tNombreForo.TabIndex = 31;
            this.tNombreForo.TextChanged += new System.EventHandler(this.tNombreForo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(793, 96);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 10, 78, 10);
            this.label3.Size = new System.Drawing.Size(189, 43);
            this.label3.TabIndex = 30;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 96);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 10, 100, 10);
            this.label4.Size = new System.Drawing.Size(342, 43);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nombre del nuevo foro";
            // 
            // tContenido
            // 
            this.tContenido.Location = new System.Drawing.Point(75, 309);
            this.tContenido.Multiline = true;
            this.tContenido.Name = "tContenido";
            this.tContenido.Size = new System.Drawing.Size(594, 247);
            this.tContenido.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 263);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 10, 478, 10);
            this.label1.Size = new System.Drawing.Size(595, 43);
            this.label1.TabIndex = 26;
            this.label1.Text = "Contenido";
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.bCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCancelar.ForeColor = System.Drawing.Color.White;
            this.bCancelar.Location = new System.Drawing.Point(898, 436);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(117, 65);
            this.bCancelar.TabIndex = 24;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // cCategoria
            // 
            this.cCategoria.FormattingEnabled = true;
            this.cCategoria.Items.AddRange(new object[] {
            "Dudas",
            "Preguntas",
            "Anuncios"});
            this.cCategoria.Location = new System.Drawing.Point(793, 142);
            this.cCategoria.Name = "cCategoria";
            this.cCategoria.Size = new System.Drawing.Size(189, 23);
            this.cCategoria.TabIndex = 35;
            // 
            // CrearForo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1228, 661);
            this.Controls.Add(this.cCategoria);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.tNombreForo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tContenido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCancelar);
            this.MaximizeBox = false;
            this.Name = "CrearForo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApreServi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.TextBox tNombreForo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tContenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.ComboBox cCategoria;
    }
}