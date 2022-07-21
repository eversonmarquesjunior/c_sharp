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
    public partial class FormNovoAluno : Form
    {
        public FormNovoAluno()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void tbox_nomealuno_TextChanged(object sender, EventArgs e)
        {

        }
        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void mtbox_telaluno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FormNovoAluno_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativo");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");

            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";
        }

        private void bt_novoaluno_Click(object sender, EventArgs e)
        {
            tbox_nomealuno.Enabled = true;
            mtbox_telaluno.Enabled = true;
            cb_status.Enabled = true;

            tbox_nomealuno.Clear();
            mtbox_telaluno.Clear();
            tbox_turma.Clear();
            cb_status.SelectedIndex = 0;
            tbox_nomealuno.Focus();

            bt_salvaraluno.Enabled = true;
            bt_cancelaraluno.Enabled = true;
            bt_novoaluno.Enabled = false;
        }

        private void bt_cancelaraluno_Click(object sender, EventArgs e)
        {
            tbox_nomealuno.Enabled = false;
            mtbox_telaluno.Enabled = false;
            cb_status.Enabled = false;

            tbox_nomealuno.Clear();
            mtbox_telaluno.Clear();
            tbox_turma.Clear();
            cb_status.SelectedIndex = 0;

            bt_salvaraluno.Enabled = false;
            bt_cancelaraluno.Enabled = false;
            bt_novoaluno.Enabled = true;
        }
        private void bt_salvaraluno_Click(object sender, EventArgs e)
        {
            string vquerynovoaluno = String.Format(@"
                INSERT INTO tb_alunos
                    (T_NOME_ALUNO, T_TELEFONE, T_STATUS, N_ID_TURMA)
                VALUES('{0}', '{1}', '{2}', {3})", tbox_nomealuno.Text, mtbox_telaluno.Text, cb_status.SelectedValue, tbox_turma.Tag.ToString());

            Banco.DML(vquerynovoaluno);

            MessageBox.Show("Novo aluno adicionado");

            tbox_nomealuno.Enabled = false;
            mtbox_telaluno.Enabled = false;
            cb_status.Enabled = false;

            bt_salvaraluno.Enabled = false;
            bt_cancelaraluno.Enabled = false;
            bt_novoaluno.Enabled = true;
        }
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_selturma_Click(object sender, EventArgs e)
        {
            FormSelecionarTurma formselecinoarturma = new FormSelecionarTurma(this);
            formselecinoarturma.ShowDialog();
        }
    }
}
