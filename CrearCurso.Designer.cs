
namespace ApreServi
{
    partial class CrearCurso
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
            this.tNombreCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bCrear = new System.Windows.Forms.Button();
            this.dInicio = new System.Windows.Forms.DateTimePicker();
            this.dFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tNombreCurso
            // 
            this.tNombreCurso.Location = new System.Drawing.Point(43, 76);
            this.tNombreCurso.Name = "tNombreCurso";
            this.tNombreCurso.Size = new System.Drawing.Size(191, 23);
            this.tNombreCurso.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nombre del nuevo curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Descripcion del curso";
            // 
            // tDescripcion
            // 
            this.tDescripcion.Location = new System.Drawing.Point(43, 164);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(306, 153);
            this.tDescripcion.TabIndex = 38;
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCancelar.Location = new System.Drawing.Point(232, 373);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(117, 65);
            this.bCancelar.TabIndex = 36;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bCrear
            // 
            this.bCrear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCrear.Location = new System.Drawing.Point(403, 373);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(131, 65);
            this.bCrear.TabIndex = 42;
            this.bCrear.Text = "Crear curso";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // dInicio
            // 
            this.dInicio.Location = new System.Drawing.Point(483, 76);
            this.dInicio.Name = "dInicio";
            this.dInicio.Size = new System.Drawing.Size(245, 23);
            this.dInicio.TabIndex = 46;
            // 
            // dFin
            // 
            this.dFin.Location = new System.Drawing.Point(483, 188);
            this.dFin.Name = "dFin";
            this.dFin.Size = new System.Drawing.Size(245, 23);
            this.dFin.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(483, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "Fecha de inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(483, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "Fecha de fin";
            // 
            // CrearCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dFin);
            this.Controls.Add(this.dInicio);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.tNombreCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.label2);
            this.Name = "CrearCurso";
            this.Text = "ApreServi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombreCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.DateTimePicker dInicio;
        private System.Windows.Forms.DateTimePicker dFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}