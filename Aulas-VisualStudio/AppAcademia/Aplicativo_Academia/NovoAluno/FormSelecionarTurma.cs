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
    public partial class FormSelecionarTurma : Form
    {
        FormNovoAluno formnovoaluno;
        public FormSelecionarTurma(FormNovoAluno f)
        {
            InitializeComponent();
            formnovoaluno = f;
        }

        private void FormSelecionarTurma_Load(object sender, EventArgs e)
        {
            string vqueryturmas = String.Format(@"
                SELECT
                    tbt.N_ID_TURMA as 'ID',
                    tbt.T_DSC_TURMA as 'Turma',
                    tbh.T_DSC_HORARIO as 'Horário',
                    tbp.T_NOME_PROFESSOR as 'Professor',
                    tbt.N_MAX_ALUNOS as '´Máximo Alunos',
                    ( SELECT
                        count (N_ID_ALUNO)
                      FROM
                        tb_alunos as tba
                      WHERE
                        tba.N_ID_TURMA = tbt.N_ID_TURMA and T_STATUS = 'A'
                    ) as 'Qtde. Alunos'
                FROM
                    tb_turmas as tbt
                INNER JOIN 
                    tb_professores as tbp on tbp.N_ID_PROFESSOR = tbt.N_ID_PROFESSOR
                INNER JOIN 
                    tb_horarios as tbh on tbh.N_ID_HORARIO = tbt.N_ID_HORARIO
            ");

            datagrid_selealunos.DataSource = Banco.DQL(vqueryturmas);
        }

        private void datagrid_selealunos_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            int maxalunos = 0;
            int qtdealunos = 0;

            maxalunos = Int32.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
            qtdealunos = Int32.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());

            if (qtdealunos >= maxalunos)
            {
                MessageBox.Show("Não há vagas disponíveis");
            }
            else
            {
                formnovoaluno.tbox_turma.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
                formnovoaluno.tbox_turma.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                Close();
            }
        }
    }
}
