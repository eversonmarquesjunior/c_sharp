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

            string vqueryturmas = @"
                SELECT
                    N_ID_TURMA,
                    ('Vagas: ' || (
                                    (N_MAX_ALUNOS)-(
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
                ";

            cb_turmas.Items.Clear();
            cb_turmas.DataSource = Banco.DQL(vqueryturmas);
            cb_turmas.DisplayMember = "Turma";
            cb_turmas.ValueMember = "N_ID_TURMA";        }
    }
}
