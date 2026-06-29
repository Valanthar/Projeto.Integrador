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
            lblBoasVindas.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBoasVindas.Location = new Point(219, 49);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(285, 54);
            lblBoasVindas.TabIndex = 0;
            lblBoasVindas.Text = "BEM VINDO";
            lblBoasVindas.Click += label1_Click;
            // 
            // lblPossuiConta
            // 
            lblPossuiConta.AutoSize = true;
            lblPossuiConta.Location = new Point(270, 141);
            lblPossuiConta.Name = "lblPossuiConta";
            lblPossuiConta.Size = new Size(115, 20);
            lblPossuiConta.TabIndex = 1;
            lblPossuiConta.Text = "ja possui conta?";
            lblPossuiConta.Click += label2_Click;
            // 
            // btnSim
            // 
            btnSim.Location = new Point(43, 269);
            btnSim.Margin = new Padding(3, 4, 3, 4);
            btnSim.Name = "btnSim";
            btnSim.Size = new Size(165, 31);
            btnSim.TabIndex = 1;
            btnSim.Text = "SIM";
            btnSim.UseVisualStyleBackColor = true;
            btnSim.Click += btnSim_Click;
            // 
            // btnNão
            // 
            btnNão.Location = new Point(489, 269);
            btnNão.Margin = new Padding(3, 4, 3, 4);
            btnNão.Name = "btnNão";
            btnNão.Size = new Size(158, 31);
            btnNão.TabIndex = 2;
            btnNão.Text = "NÃO";
            btnNão.UseVisualStyleBackColor = true;
            btnNão.Click += btnNão_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 419);
            Controls.Add(btnNão);
            Controls.Add(btnSim);
            Controls.Add(lblPossuiConta);
            Controls.Add(lblBoasVindas);
            Margin = new Padding(3, 4, 3, 4);
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
