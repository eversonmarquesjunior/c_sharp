namespace Aplicativo_Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormLogin formlogin = new FormLogin(this);
            formlogin.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin formentrar = new FormLogin(this);
            formentrar.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_acesso.Text = "0";
            label_nomeuser.Text = "---";
            pb_statuslog.Image = Properties.Resources.botaovermelho;
            Global.nivel = 0;
            Global.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if(Global.nivel >= 3)
                {
                    //procedimentos
                }
                else
                {
                    MessageBox.Show("Usuário Nível 3 necessário");                
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuário logado");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 2)
                {
                    FormNovoUsuario formnovousuario = new FormNovoUsuario();
                    formnovousuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário Nível 2 necessário");
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuário logado");
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 2)
                {
                    //procedimentos
                }
                else
                {
                    MessageBox.Show("Usuário Nível 2 necessário");
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuário logado");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                //procedimentos
            }
            else
            {
                MessageBox.Show("Nenhum usuário logado");
            }
        }
    }
}