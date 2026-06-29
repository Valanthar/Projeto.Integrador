namespace Projeto.Integrador.View
{
    partial class FormLogin
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
            label1 = new Label();
            lblUsuario_login = new Label();
            lblSenha_Login = new Label();
            btnEntrar_login = new Button();
            btnVoltar_login = new Button();
            txtSenhaLogin = new TextBox();
            txtUsuarioLogin = new MaskedTextBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(306, 23);
            label1.Name = "label1";
            label1.Size = new Size(192, 15);
            label1.TabIndex = 0;
            label1.Text = "TELA DE LOGIN DO BALACO BACO";
            // 
            // lblUsuario_login
            // 
            lblUsuario_login.AutoSize = true;
            lblUsuario_login.Location = new Point(139, 144);
            lblUsuario_login.Name = "lblUsuario_login";
            lblUsuario_login.Size = new Size(28, 15);
            lblUsuario_login.TabIndex = 1;
            lblUsuario_login.Text = "CPF";
            // 
            // lblSenha_Login
            // 
            lblSenha_Login.AutoSize = true;
            lblSenha_Login.Location = new Point(139, 185);
            lblSenha_Login.Name = "lblSenha_Login";
            lblSenha_Login.Size = new Size(45, 15);
            lblSenha_Login.TabIndex = 2;
            lblSenha_Login.Text = "SENHA";
            // 
            // btnEntrar_login
            // 
            btnEntrar_login.Location = new Point(131, 285);
            btnEntrar_login.Name = "btnEntrar_login";
            btnEntrar_login.Size = new Size(75, 23);
            btnEntrar_login.TabIndex = 3;
            btnEntrar_login.Text = "ENTRAR";
            btnEntrar_login.UseVisualStyleBackColor = true;
            btnEntrar_login.Click += btnEntrar_login_Click;
            // 
            // btnVoltar_login
            // 
            btnVoltar_login.Location = new Point(381, 285);
            btnVoltar_login.Name = "btnVoltar_login";
            btnVoltar_login.Size = new Size(75, 23);
            btnVoltar_login.TabIndex = 4;
            btnVoltar_login.Text = "VOLTAR";
            btnVoltar_login.UseVisualStyleBackColor = true;
            btnVoltar_login.Click += btnVoltar_login_Click_1;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Location = new Point(203, 182);
            txtSenhaLogin.Margin = new Padding(3, 2, 3, 2);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(110, 23);
            txtSenhaLogin.TabIndex = 2;
            txtSenhaLogin.UseSystemPasswordChar = true;
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(186, 141);
            txtUsuarioLogin.Margin = new Padding(3, 2, 3, 2);
            txtUsuarioLogin.Mask = "000\\.000\\.000\\-00";
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(110, 23);
            txtUsuarioLogin.TabIndex = 1;
            txtUsuarioLogin.MaskInputRejected += txtUsuarioLogin_MaskInputRejected;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(139, 250);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(185, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Não possui cadastro? Clique aqui!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 407);
            Controls.Add(linkLabel1);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(txtSenhaLogin);
            Controls.Add(btnVoltar_login);
            Controls.Add(btnEntrar_login);
            Controls.Add(lblSenha_Login);
            Controls.Add(lblUsuario_login);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "TelaLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsuario_login;
        private Label lblSenha_Login;
        private Button btnEntrar_login;
        private Button btnVoltar_login;
        private TextBox txtSenhaLogin;
        private MaskedTextBox txtUsuarioLogin;
        private LinkLabel linkLabel1;
    }
}
