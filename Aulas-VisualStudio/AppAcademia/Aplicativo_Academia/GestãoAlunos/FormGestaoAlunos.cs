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
    public partial class FormGestaoAlunos : Form
    {
        string vqueryglobal = "";
        string turmaatual = "";
        string idselecionado = "";
        string turma = "";
        int linha = 0;
        public FormGestaoAlunos()
        {
            InitializeComponent();
        }

        private void FormGestaoAlunos_Load(object sender, EventArgs e)
        {
            vqueryglobal = @"
                SELECT
                    N_ID_ALUNO as 'ID',
                    T_NOME_ALUNO as 'Aluno'
                FROM   
                    tb_alunos
            ";

            datagrid_alunos.DataSource = Banco.DQL(vqueryglobal);
            datagrid_alunos.Columns[0].Width = 40;
            datagrid_alunos.Columns[1].Width = 120;

            tbox_nomealuno.Text = datagrid_alunos.Rows[datagrid_alunos.SelectedRows[0].Index].Cells[1].Value.ToString();

            //Popular cb_turmas

            string vqueryturmas = String.Format(@"
                SELECT
                    N_ID_TURMA,
                    ('Vagas: '|| (
                                    (N_MAX_ALUNOS) - (
                                                     SELECT
                                                        count(tba.N_ID_ALUNO)
                                                     FROM
                                                        tb_alunos as tba
                                                     WHERE
                                                        tba.T_STATUS = 'A' and tba.N_ID_TURMA = N_ID_TURMA
                                                     )
                                 ) || ' / Turma: ' || T_DSC_TURMA
                    )as 'Turma'
                FROM
                    tb_turmas
                ORDER BY
                    N_ID_TURMA
                ");

            cb_turmas.Items.Clear();
            cb_turmas.DataSource = Banco.DQL(vqueryturmas);
            cb_turmas.DisplayMember = "Turma";
            cb_turmas.ValueMember = "N_ID_TURMA";   
            
            //Popular cb_status

            Dictionary<string, string> status = new Dictionary<string, string>();
            
            status.Add("A", "Ativo");   
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");

            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            turma = cb_turmas.Text;
            turma = cb_turmas.Text;
            idselecionado = datagrid_alunos.Rows[0].Cells[0].Value.ToString();
        }

        private void datagrid_alunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagrid_alunos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if(dgv.SelectedRows.Count > 0)
            {
                idselecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();

                string vquerycampos = String.Format(@"
                    SELECT
                        N_ID_ALUNO,
                        T_NOME_ALUNO,
                        T_TELEFONE,
                        T_STATUS,
                        N_ID_TURMA
                    FROM
                        tb_alunos
                    WHERE N_ID_ALUNO = {0}", idselecionado);

                DataTable dt = Banco.DQL(vquerycampos);

                tbox_nomealuno.Text = dt.Rows[0].Field<string>("T_NOME_ALUNO");
                mtbox_telaluno.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_turmas.SelectedValue = dt.Rows[0].Field<Int64>("N_ID_TURMA");
                turmaatual = cb_turmas.Text;
            }
        }

        private void bt_salvaraluno_Click(object sender, EventArgs e)
        {
            turma = cb_turmas.Text;

            if (turmaatual != turma)
            {
                string[] t = turma.Split(' ');
                int vagas = int.Parse(t[1]);

                if (vagas < 1)
                {
                    MessageBox.Show("Não há vagas na turma selecionada");
                    cb_turmas.Focus();
                    return;
                }

                //linha = datagrid_alunos.SelectedRows[0].Index;
                string vqueryatualizaraluno = String.Format(@"
                    UPDATE
                        tb_alunos
                    SET
                        T_NOME_ALUNO = '{0}',
                        T_TELEFONE = '{1}',
                        T_STATUS = '{2}',
                        N_ID_TURMA = '{3}'
                    WHERE
                        N_ID_ALUNO = {4}", tbox_nomealuno.Text, mtbox_telaluno.Text, cb_status.SelectedValue, cb_turmas.SelectedValue, idselecionado);
                    
                Banco.DML(vqueryatualizaraluno);
                //datagrid_alunos[1, linha].Value = tbox_nomealuno.Text;
            }
        }

        private void bt_excluiraluno_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo excluir?", "Confirmação", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                string vqueryexcluir = String.Format(@"
                    DELETE FROM
                        tb_alunos
                    WHERE
                        N_ID_ALUNO = {0}", idselecionado);

                Banco.DML(vqueryexcluir);
                datagrid_alunos.Rows.Remove(datagrid_alunos.CurrentRow);
            }
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
