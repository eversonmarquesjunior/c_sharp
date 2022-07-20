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
    public partial class FormTurmas : Form
    {
        string idselecionado;
        int modo = 0; //0 = padrão; 1 = edição; 2 = inserção
        string vqueryglobal;
        public FormTurmas()
        {
            InitializeComponent();
        }

        private void FormTurmas_Load(object sender, EventArgs e)
        {
            vqueryglobal = @"
                SELECT
                    tbt.N_ID_TURMA as 'ID',
                    tbt.T_DSC_TURMA as 'Turma',
                    tbh.T_DSC_HORARIO as 'Horário'
                FROM
                    tb_turmas as tbt
                INNER JOIN
                    tb_horarios as tbh on tbh.N_ID_HORARIO = tbt.N_ID_HORARIO
            ";

            datagrid_turmas.DataSource = Banco.DQL(vqueryglobal);
            datagrid_turmas.Columns[0].Width = 40;
            datagrid_turmas.Columns[1].Width = 120;
            datagrid_turmas.Columns[2].Width = 85;

            //Popular cb_prof

            string vqueryprof = @"
                SELECT
                    N_ID_PROFESSOR,
                    T_NOME_PROFESSOR
                FROM
                    tb_professores
                ORDER BY
                    T_NOME_PROFESSOR
            ";

            cb_prof.Items.Clear();
            cb_prof.DataSource = Banco.DQL(vqueryprof);
            cb_prof.DisplayMember = "T_NOME_PROFESSOR";
            cb_prof.ValueMember = "N_ID_PROFESSOR";

            //Popular cb_status - A = Ativa; P = Paralisada; C = Cancelada;

            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativa");
            status.Add("P", "Paralisada");
            status.Add("C", "Cancelada");

            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.ValueMember = "Key";
            cb_status.DisplayMember = "Value";

            //Popular cb_horarios

            string vqueryhorarios = @"
                SELECT
                    *
                FROM
                    tb_horarios
                ORDER BY
                    T_DSC_HORARIO
            ";

            cb_horarios.Items.Clear();
            cb_horarios.DataSource = Banco.DQL(vqueryhorarios);
            cb_horarios.DisplayMember = "T_DSC_HORARIO";
            cb_horarios.ValueMember = "N_ID_HORARIO";

        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void datagrid_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            int contlinhas = dgv.SelectedRows.Count;

            if (contlinhas > 0)
            {
                modo = 0;

                DataTable dt = new DataTable();
                idselecionado = datagrid_turmas.Rows[datagrid_turmas.SelectedRows[0].Index].Cells[0].Value.ToString();

                string vquery = @"
                    SELECT
                        T_DSC_TURMA,
                        N_ID_PROFESSOR,
                        N_ID_HORARIO,
                        N_MAX_ALUNOS,
                        T_STATUS
                    FROM
                        tb_turmas  
                    WHERE 
                        N_ID_TURMA = " +idselecionado;

                dt = Banco.DQL(vquery);
                tbox_dscturma.Text = dt.Rows[0].Field<string>("T_DSC_TURMA").ToString();
                cb_prof.SelectedValue = dt.Rows[0].Field<Int64>("N_ID_PROFESSOR").ToString();
                numeric_maxalunos.Value = dt.Rows[0].Field<Int64>("N_MAX_ALUNOS");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horarios.SelectedValue = dt.Rows[0].Field<Int64>("N_ID_HORARIO");
            }
        }

        private void bt_addturma_Click(object sender, EventArgs e)
        {
            tbox_dscturma.Clear();
            cb_prof.SelectedIndex = -1;
            numeric_maxalunos.Value = 0;
            cb_status.SelectedIndex = -1;
            cb_horarios.SelectedIndex = -1;
            tbox_dscturma.Focus();
            modo = 2;
        }

        private void bt_salvarturma_Click(object sender, EventArgs e)
        {
            if (modo != 0) 
            {
                string vquery = "";
                string msg = "";

                if (modo == 1)
                {
                    msg = "Dados alterados";
                    vquery = String.Format(@"
                        UPDATE
                            tb_turmas
                        SET
                            T_DSC_TURMA = '{0}',
                            N_ID_PROFESSOR = {1},
                            N_ID_HORARIO = {2},
                            N_MAX_ALUNOS = {3},
                            T_STATUS = '{4}'
                        WHERE
                             N_ID_TURMA = {5}", tbox_dscturma.Text, cb_prof.SelectedValue, cb_horarios.SelectedValue, Int32.Parse(Math.Round(numeric_maxalunos.Value).ToString()), cb_status.SelectedValue, idselecionado);
                }
                else
                {
                    msg = "Turma adicionada";
                    vquery = String.Format(@"
                        INSERT INTO tb_turmas
                        (T_DSC_TURMA, N_ID_PROFESSOR, N_ID_HORARIO, N_MAX_ALUNOS, T_STATUS)
                        VALUES('{0}', {1}, {2}, {3}, '{4}')", tbox_dscturma.Text, cb_prof.SelectedValue, cb_horarios.SelectedValue, Int32.Parse(Math.Round(numeric_maxalunos.Value).ToString()), cb_status.SelectedValue);
                }

                int linha = datagrid_turmas.SelectedRows[0].Index;
     
                Banco.DML(vquery);

                if (modo == 1)
                {
                    datagrid_turmas[1, linha].Value = tbox_dscturma.Text;
                    datagrid_turmas[2, linha].Value = cb_horarios.Text;
                }
                else
                {
                    datagrid_turmas.DataSource = Banco.DQL(vqueryglobal);
                }

                MessageBox.Show(msg);
            }
        }
   
        private void bt_excluirprof_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo excluir?", "Confirmação", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_turmas WHERE N_ID_TURMA = " +idselecionado;
                Banco.DML(vquery);
                datagrid_turmas.Rows.Remove(datagrid_turmas.CurrentRow);
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbox_dscturma_TextChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_prof_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void numeric_maxalunos_ValueChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_horarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }
    }
}
    

