using Projeto.Integrador.View;

namespace Projeto.Integrador
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            //instancia da tela de Login
            FormLogin login = new FormLogin();
            login.Show();

            //esconde a tela
            this.Hide();

        }

        private void btnNão_Click(object sender, EventArgs e)
        {
            //instancia da tela de Cadastro
            FormCadastro cadastro = new FormCadastro();
            cadastro.Show();

            //Esconde a tela
            this.Hide();
        }
    }
}
