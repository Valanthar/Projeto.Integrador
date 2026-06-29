namespace Projeto.Integrador.View
{
    partial class FormCadastro
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
            lbl_tela_cadastro = new Label();
            lblUsuario_Cadastro = new Label();
            lblSenha_Cadastro = new Label();
            btnCadastrar = new Button();
            btnVoltar_Cad = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            label3 = new Label();
            dtpDataNascimento = new DateTimePicker();
            label4 = new Label();
            txtSobrenome = new TextBox();
            txtCPF = new MaskedTextBox();
            SuspendLayout();
            // 
            // lbl_tela_cadastro
            // 
            lbl_tela_cadastro.AutoSize = true;
            lbl_tela_cadastro.Location = new Point(181, 37);
            lbl_tela_cadastro.Name = "lbl_tela_cadastro";
            lbl_tela_cadastro.Size = new Size(149, 15);
            lbl_tela_cadastro.TabIndex = 0;
            lbl_tela_cadastro.Text = "TELA DE CADASTRO FODA";
            // 
            // lblUsuario_Cadastro
            // 
            lblUsuario_Cadastro.AutoSize = true;
            lblUsuario_Cadastro.Location = new Point(85, 92);
            lblUsuario_Cadastro.Name = "lblUsuario_Cadastro";
            lblUsuario_Cadastro.Size = new Size(42, 15);
            lblUsuario_Cadastro.TabIndex = 1;
            lblUsuario_Cadastro.Text = "NOME";
            lblUsuario_Cadastro.Click += lblUsuario_Cadastro_Click;
            // 
            // lblSenha_Cadastro
            // 
            lblSenha_Cadastro.AutoSize = true;
            lblSenha_Cadastro.Location = new Point(85, 161);
            lblSenha_Cadastro.Name = "lblSenha_Cadastro";
            lblSenha_Cadastro.Size = new Size(28, 15);
            lblSenha_Cadastro.TabIndex = 2;
            lblSenha_Cadastro.Text = "CPF";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(136, 352);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(114, 31);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnVoltar_Cad
            // 
            btnVoltar_Cad.Location = new Point(480, 352);
            btnVoltar_Cad.Margin = new Padding(3, 4, 3, 4);
            btnVoltar_Cad.Name = "btnVoltar_Cad";
            btnVoltar_Cad.Size = new Size(86, 31);
            btnVoltar_Cad.TabIndex = 8;
            btnVoltar_Cad.Text = "VOLTAR";
            btnVoltar_Cad.UseVisualStyleBackColor = true;
            btnVoltar_Cad.Click += btnVoltar_Cad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 198);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 5;
            label1.Text = "SENHA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 264);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 6;
            label2.Text = "DATA DE NASCIMENTO";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(194, 85);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 23);
            txtNome.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(158, 191);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 23);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(208, 224);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(125, 23);
            txtConfirmarSenha.TabIndex = 5;
            txtConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 230);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 12;
            label3.Text = "Confirmar senha";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(250, 258);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(250, 23);
            dtpDataNascimento.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 126);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 14;
            label4.Text = "Sobrenome";
            label4.Click += label4_Click;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(195, 123);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(125, 23);
            txtSobrenome.TabIndex = 2;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(158, 156);
            txtCPF.Mask = "000\\.000\\.000\\-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(125, 23);
            txtCPF.TabIndex = 3;
            // 
            // FormCadastro
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(914, 600);
            Controls.Add(txtCPF);
            Controls.Add(txtSobrenome);
            Controls.Add(label4);
            Controls.Add(dtpDataNascimento);
            Controls.Add(label3);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVoltar_Cad);
            Controls.Add(btnCadastrar);
            Controls.Add(lblSenha_Cadastro);
            Controls.Add(lblUsuario_Cadastro);
            Controls.Add(lbl_tela_cadastro);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCadastro";
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_tela_cadastro;
        private Label lblUsuario_Cadastro;
        private Label lblSenha_Cadastro;
        private Button btnCadastrar;
        private Button btnVoltar_Cad;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private Label label3;
        private DateTimePicker dtpDataNascimento;
        private Label label4;
        private TextBox txtSobrenome;
        private MaskedTextBox txtCPF;
    }
}