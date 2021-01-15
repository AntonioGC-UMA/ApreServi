
namespace ApreServi
{
    partial class Registro
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
            this.bCancelar = new System.Windows.Forms.Button();
            this.tCorreo = new System.Windows.Forms.TextBox();
            this.tApellidos = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.tConfirmPassword = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tNombreUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.bCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCancelar.ForeColor = System.Drawing.Color.White;
            this.bCancelar.Location = new System.Drawing.Point(355, 532);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(117, 65);
            this.bCancelar.TabIndex = 9;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // tCorreo
            // 
            this.tCorreo.Location = new System.Drawing.Point(686, 244);
            this.tCorreo.Name = "tCorreo";
            this.tCorreo.Size = new System.Drawing.Size(256, 23);
            this.tCorreo.TabIndex = 8;
            // 
            // tApellidos
            // 
            this.tApellidos.Location = new System.Drawing.Point(81, 412);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(256, 23);
            this.tApellidos.TabIndex = 7;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(688, 210);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(186, 23);
            this.password.TabIndex = 6;
            this.password.Text = "Correo electrónico";
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usuario.Location = new System.Drawing.Point(83, 374);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(98, 23);
            this.usuario.TabIndex = 5;
            this.usuario.Text = "Apellidos";
            // 
            // tConfirmPassword
            // 
            this.tConfirmPassword.Location = new System.Drawing.Point(686, 508);
            this.tConfirmPassword.Name = "tConfirmPassword";
            this.tConfirmPassword.PasswordChar = '*';
            this.tConfirmPassword.Size = new System.Drawing.Size(256, 23);
            this.tConfirmPassword.TabIndex = 13;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(688, 377);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(254, 23);
            this.tPassword.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(688, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(688, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Confirmar contraseña";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(83, 281);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(256, 23);
            this.tNombre.TabIndex = 17;
            // 
            // tNombreUsuario
            // 
            this.tNombreUsuario.Location = new System.Drawing.Point(83, 150);
            this.tNombreUsuario.Name = "tNombreUsuario";
            this.tNombreUsuario.Size = new System.Drawing.Size(256, 23);
            this.tNombreUsuario.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(83, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(83, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre de usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Navy;
            this.label5.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, -2);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10);
            this.label5.Size = new System.Drawing.Size(604, 62);
            this.label5.TabIndex = 18;
            this.label5.Text = "Introduzca sus datos personales";
            // 
            // bConfirmar
            // 
            this.bConfirmar.BackColor = System.Drawing.Color.SteelBlue;
            this.bConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConfirmar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bConfirmar.ForeColor = System.Drawing.Color.White;
            this.bConfirmar.Location = new System.Drawing.Point(154, 532);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(136, 65);
            this.bConfirmar.TabIndex = 19;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = false;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Usuario",
            "Profesor",
            "Organización"});
            this.cbRol.Location = new System.Drawing.Point(684, 133);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(121, 23);
            this.cbRol.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(684, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Rol";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1228, 661);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.tNombreUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tConfirmPassword);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.tCorreo);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usuario);
            this.MaximizeBox = false;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApreServi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.TextBox tCorreo;
        private System.Windows.Forms.TextBox tApellidos;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.TextBox tConfirmPassword;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tNombreUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label label6;
    }
}