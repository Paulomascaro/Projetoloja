﻿namespace Projetoloja.desktopApp.views
{
    partial class UsuarioForm
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.lblNomeUser = new System.Windows.Forms.Label();
            this.lblEmailUser = new System.Windows.Forms.Label();
            this.lblSenhaUser = new System.Windows.Forms.Label();
            this.lblTipoUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(79, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(705, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(79, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(705, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(79, 88);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(705, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(79, 126);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(705, 21);
            this.cmbTipoUsuario.TabIndex = 3;
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(13, 230);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(210, 43);
            this.btnCadastrarUsuario.TabIndex = 4;
            this.btnCadastrarUsuario.Text = "Cadastrar";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUser.Location = new System.Drawing.Point(8, 12);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Size = new System.Drawing.Size(60, 23);
            this.lblNomeUser.TabIndex = 5;
            this.lblNomeUser.Text = "Nome";
            // 
            // lblEmailUser
            // 
            this.lblEmailUser.AutoSize = true;
            this.lblEmailUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUser.Location = new System.Drawing.Point(9, 47);
            this.lblEmailUser.Name = "lblEmailUser";
            this.lblEmailUser.Size = new System.Drawing.Size(59, 20);
            this.lblEmailUser.TabIndex = 6;
            this.lblEmailUser.Text = "E-mail";
            // 
            // lblSenhaUser
            // 
            this.lblSenhaUser.AutoSize = true;
            this.lblSenhaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaUser.Location = new System.Drawing.Point(9, 88);
            this.lblSenhaUser.Name = "lblSenhaUser";
            this.lblSenhaUser.Size = new System.Drawing.Size(61, 20);
            this.lblSenhaUser.TabIndex = 7;
            this.lblSenhaUser.Text = "Senha";
            // 
            // lblTipoUser
            // 
            this.lblTipoUser.AutoSize = true;
            this.lblTipoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUser.Location = new System.Drawing.Point(12, 127);
            this.lblTipoUser.Name = "lblTipoUser";
            this.lblTipoUser.Size = new System.Drawing.Size(43, 20);
            this.lblTipoUser.TabIndex = 8;
            this.lblTipoUser.Text = "Tipo";
            // 
            // UsuarioForm
            // 
            this.ClientSize = new System.Drawing.Size(796, 285);
            this.Controls.Add(this.lblTipoUser);
            this.Controls.Add(this.lblSenhaUser);
            this.Controls.Add(this.lblEmailUser);
            this.Controls.Add(this.lblNomeUser);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Name = "UsuarioForm";
            this.Load += new System.EventHandler(this.UsuarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.Label lblNomeUser;
        private System.Windows.Forms.Label lblEmailUser;
        private System.Windows.Forms.Label lblSenhaUser;
        private System.Windows.Forms.Label lblTipoUser;
    }
}