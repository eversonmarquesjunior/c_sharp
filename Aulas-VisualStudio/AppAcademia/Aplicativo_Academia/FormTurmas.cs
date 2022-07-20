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
        public FormTurmas()
        {
            InitializeComponent();
        }

        private void FormTurmas_Load(object sender, EventArgs e)
        {
            string vquery = @"
                SELECT
                    tbt.N_ID_TURMA as 'ID',
                    tbt.T_DSC_TURMA as 'Turma',
                    tbh.T_DSC_HORARIO as 'Horário'
                FROM
                    tb_turmas as tbt
                INNER JOIN
                    tb_horarios as tbh on tbh.N_ID_HORARIO = tbt.N_ID_HORARIO
            ";

            datagrid_turmas.DataSource = Banco.DQL(vquery);
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
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

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
                        N_ID_TURMA = " + vid;

                dt = Banco.DQL(vquery);
                tbox_dscturma.Text = dt.Rows[0].Field<string>("T_DSC_TURMA").ToString();
                cb_prof.SelectedValue = dt.Rows[0].Field<Int64>("N_ID_PROFESSOR").ToString();
                numeric_maxalunos.Value = dt.Rows[0].Field<Int64>("N_MAX_ALUNOS");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horarios.SelectedValue = dt.Rows[0].Field<Int64>("N_ID_HORARIO");
            }
        }
            


    }
}
    

