﻿
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
            this.bConfirmar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bConfirmar.Location = new System.Drawing.Point(411, 351);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(117, 65);
            this.bConfirmar.TabIndex = 34;
            this.bConfirmar.Text = "Crear foro";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // tNombreForo
            // 
            this.tNombreForo.Location = new System.Drawing.Point(75, 123);
            this.tNombreForo.Name = "tNombreForo";
            this.tNombreForo.Size = new System.Drawing.Size(191, 23);
            this.tNombreForo.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(75, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(75, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nombre del nuevo foro";
            // 
            // tContenido
            // 
            this.tContenido.Location = new System.Drawing.Point(435, 134);
            this.tContenido.Multiline = true;
            this.tContenido.Name = "tContenido";
            this.tContenido.Size = new System.Drawing.Size(306, 153);
            this.tContenido.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(435, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Contenido";
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCancelar.Location = new System.Drawing.Point(240, 351);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(117, 65);
            this.bCancelar.TabIndex = 24;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // cCategoria
            // 
            this.cCategoria.FormattingEnabled = true;
            this.cCategoria.Items.AddRange(new object[] {
            "Dudas",
            "Preguntas",
            "Anuncios"});
            this.cCategoria.Location = new System.Drawing.Point(77, 259);
            this.cCategoria.Name = "cCategoria";
            this.cCategoria.Size = new System.Drawing.Size(186, 23);
            this.cCategoria.TabIndex = 35;
            // 
            // CrearForo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cCategoria);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.tNombreForo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tContenido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCancelar);
            this.Name = "CrearForo";
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