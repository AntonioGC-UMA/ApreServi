
namespace ApreServi
{
    partial class InicioDeSesion
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
            this.usuario = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.bIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usuario.Location = new System.Drawing.Point(350, 73);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(83, 23);
            this.usuario.TabIndex = 0;
            this.usuario.Text = "Usuario";
            this.usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(335, 181);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(117, 23);
            this.password.TabIndex = 1;
            this.password.Text = "Contraseña";
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(333, 127);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(119, 23);
            this.tUsuario.TabIndex = 2;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(333, 215);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(119, 23);
            this.tPassword.TabIndex = 3;
            // 
            // bIniciar
            // 
            this.bIniciar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bIniciar.Location = new System.Drawing.Point(332, 333);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(117, 65);
            this.bIniciar.TabIndex = 4;
            this.bIniciar.Text = "Iniciar Sesion";
            this.bIniciar.UseVisualStyleBackColor = true;
            // 
            // InicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bIniciar);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usuario);
            this.Name = "InicioDeSesion";
            this.Text = "ApreServi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button bIniciar;
    }
}