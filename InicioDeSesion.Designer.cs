﻿
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
            this.bCancelar = new System.Windows.Forms.Button();
            this.bOlvido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usuario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usuario.Location = new System.Drawing.Point(567, 151);
            this.usuario.Name = "usuario";
            this.usuario.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.usuario.Size = new System.Drawing.Size(116, 43);
            this.usuario.TabIndex = 0;
            this.usuario.Text = "Usuario";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(569, 352);
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.password.Size = new System.Drawing.Size(161, 43);
            this.password.TabIndex = 1;
            this.password.Text = "Contraseña";
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(569, 197);
            this.tUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(262, 27);
            this.tUsuario.TabIndex = 2;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(569, 400);
            this.tPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(262, 27);
            this.tPassword.TabIndex = 3;
            this.tPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPassword_KeyPress);
            // 
            // bIniciar
            // 
            this.bIniciar.BackColor = System.Drawing.Color.SteelBlue;
            this.bIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bIniciar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIniciar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bIniciar.ForeColor = System.Drawing.Color.White;
            this.bIniciar.Location = new System.Drawing.Point(505, 687);
            this.bIniciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(134, 87);
            this.bIniciar.TabIndex = 4;
            this.bIniciar.Text = "Iniciar Sesion";
            this.bIniciar.UseVisualStyleBackColor = false;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.bCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCancelar.ForeColor = System.Drawing.Color.White;
            this.bCancelar.Location = new System.Drawing.Point(768, 687);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(134, 87);
            this.bCancelar.TabIndex = 10;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bOlvido
            // 
            this.bOlvido.BackColor = System.Drawing.Color.SteelBlue;
            this.bOlvido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOlvido.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bOlvido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOlvido.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOlvido.ForeColor = System.Drawing.Color.White;
            this.bOlvido.Location = new System.Drawing.Point(539, 464);
            this.bOlvido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bOlvido.Name = "bOlvido";
            this.bOlvido.Size = new System.Drawing.Size(326, 45);
            this.bOlvido.TabIndex = 11;
            this.bOlvido.Text = "He olvidado mi contraseña";
            this.bOlvido.UseVisualStyleBackColor = false;
            this.bOlvido.Click += new System.EventHandler(this.bOlvido_Click);
            // 
            // InicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1403, 881);
            this.Controls.Add(this.bOlvido);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bIniciar);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usuario);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "InicioDeSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bOlvido;
    }
}