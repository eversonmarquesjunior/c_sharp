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
        private void AbrirForm(int nivel, Form f)
        {
            if (Global.logado)
            {
                if (Global.nivel >= nivel)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuário logado");
            }
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

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoUsuario formnovousuario = new FormNovoUsuario();
            AbrirForm(2, formnovousuario);
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestaoUsuarios formgestao = new FormGestaoUsuarios();
            AbrirForm(2, formgestao);
        }
        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHorarios formhorarios = new FormHorarios();
            AbrirForm(3, formhorarios);
        }
        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfessores formprofessores = new FormProfessores();
            AbrirForm(3, formprofessores);
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
        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 3)
                {
                    //procedimentos
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuário logado");
            }
        }
    }
}