using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void novoAlunoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                FormNovoAluno formnovoaluno = new FormNovoAluno();
                AbrirForm(1, formnovoaluno);
            }
            else
            {
                MessageBox.Show("Nenhum usuário logado");
            }
        }
        private void gestãoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestaoAlunos formgestaoalunos = new FormGestaoAlunos();
            AbrirForm(3, formgestaoalunos);
        }

        private void novoUsuárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormNovoUsuario formnovousuario = new FormNovoUsuario();
            AbrirForm(2, formnovousuario);
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormGestaoUsuarios formgestao = new FormGestaoUsuarios();
            AbrirForm(2, formgestao);
        }

        private void horáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormHorarios formhorarios = new FormHorarios();
            AbrirForm(3, formhorarios);
        }

        private void professoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormProfessores formprofessores = new FormProfessores();
            AbrirForm(3, formprofessores);
        }

        private void turmasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormTurmas formturmas = new FormTurmas();
            AbrirForm(3, formturmas);
        }

        private void entrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormLogin formentrar = new FormLogin(this);
            formentrar.ShowDialog();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            label_acesso.Text = "0";
            label_nomeuser.Text = "---";
            pb_statuslog.Image = Properties.Resources.botaovermelho;
            Global.nivel = 0;
            Global.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click_1(object sender, EventArgs e)
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

