namespace Projeto.Integrador
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBoasVindas = new Label();
            lblPossuiConta = new Label();
            btnSim = new Button();
            btnNão = new Button();
            SuspendLayout();
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.Font = new Font("Arial Narrow", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBoasVindas.Location = new Point(192, 37);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(188, 43);
            lblBoasVindas.TabIndex = 0;
            lblBoasVindas.Text = "BEM VINDO";
            lblBoasVindas.Click += label1_Click;
            // 
            // lblPossuiConta
            // 
            lblPossuiConta.AutoSize = true;
            lblPossuiConta.Location = new Point(236, 106);
            lblPossuiConta.Name = "lblPossuiConta";
            lblPossuiConta.Size = new Size(91, 15);
            lblPossuiConta.TabIndex = 1;
            lblPossuiConta.Text = "ja possui conta?";
            lblPossuiConta.Click += label2_Click;
            // 
            // btnSim
            // 
            btnSim.Location = new Point(38, 202);
            btnSim.Name = "btnSim";
            btnSim.Size = new Size(144, 23);
            btnSim.TabIndex = 2;
            btnSim.Text = "SIM";
            btnSim.UseVisualStyleBackColor = true;
            btnSim.Click += btnSim_Click;
            // 
            // btnNão
            // 
            btnNão.Location = new Point(428, 202);
            btnNão.Name = "btnNão";
            btnNão.Size = new Size(138, 23);
            btnNão.TabIndex = 3;
            btnNão.Text = "NÃO";
            btnNão.UseVisualStyleBackColor = true;
            btnNão.Click += btnNão_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 314);
            Controls.Add(btnNão);
            Controls.Add(btnSim);
            Controls.Add(lblPossuiConta);
            Controls.Add(lblBoasVindas);
            Name = "MainMenu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBoasVindas;
        private Label lblPossuiConta;
        private Button btnSim;
        private Button btnNão;
    }
}
