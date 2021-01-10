
namespace ApreServi
{
    partial class CrearNoticia
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
            this.tTitular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tCuerpo = new System.Windows.Forms.TextBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bCrear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // tTitular
            // 
            this.tTitular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tTitular.Location = new System.Drawing.Point(43, 96);
            this.tTitular.Name = "tTitular";
            this.tTitular.Size = new System.Drawing.Size(382, 23);
            this.tTitular.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 50);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 10, 128, 10);
            this.label4.Size = new System.Drawing.Size(210, 43);
            this.label4.TabIndex = 39;
            this.label4.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 184);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 10, 366, 10);
            this.label2.Size = new System.Drawing.Size(454, 43);
            this.label2.TabIndex = 37;
            this.label2.Text = "Cuerpo";
            // 
            // tCuerpo
            // 
            this.tCuerpo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tCuerpo.Location = new System.Drawing.Point(43, 230);
            this.tCuerpo.Multiline = true;
            this.tCuerpo.Name = "tCuerpo";
            this.tCuerpo.Size = new System.Drawing.Size(593, 249);
            this.tCuerpo.TabIndex = 38;
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
            this.bCrear.Size = new System.Drawing.Size(131, 65);
            this.bCrear.TabIndex = 42;
            this.bCrear.Text = "Crear noticia";
            this.bCrear.UseVisualStyleBackColor = false;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(730, 36);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 10, 108, 10);
            this.label3.Size = new System.Drawing.Size(200, 43);
            this.label3.TabIndex = 49;
            this.label3.Text = "Imagen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(883, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pImagen
            // 
            this.pImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pImagen.Location = new System.Drawing.Point(730, 96);
            this.pImagen.Name = "pImagen";
            this.pImagen.Size = new System.Drawing.Size(147, 131);
            this.pImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImagen.TabIndex = 51;
            this.pImagen.TabStop = false;
            // 
            // CrearNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1228, 661);
            this.Controls.Add(this.pImagen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.tTitular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tCuerpo);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "CrearNoticia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApreServi";
            ((System.ComponentModel.ISupportInitialize)(this.pImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tTitular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tCuerpo;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pImagen;
    }
}