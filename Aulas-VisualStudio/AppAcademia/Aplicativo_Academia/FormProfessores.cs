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
    public partial class FormProfessores : Form
    {
        public FormProfessores()
        {
            InitializeComponent();
        }

        private void FormProfessores_Load(object sender, EventArgs e)
        {
            string vquery = @"
                SELECT
                    N_ID_PROFESSOR as 'ID',
                    T_NOME_PROFESSOR as 'Nome',
                    T_TELEFONE as 'Telefone'
                FROM
                    tb_professores
                ORDER BY
                    T_NOME_PROFESSOR
            ";

            datagrid_professores.DataSource = Banco.DQL(vquery);
            datagrid_professores.Columns[0].Width = 60;
            datagrid_professores.Columns[1].Width = 170;
            datagrid_professores.Columns[2].Width = 100;
        }
        private void datagrid_professores_SelectionChanged_1(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            int contlinhas = dgv.SelectedRows.Count;

            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                    SELECT 
                        * 
                    FROM
                        tb_professores
                    WHERE 
                        N_ID_PROFESSOR = " +vid;

                dt = Banco.DQL(vquery);
                tbox_idprof.Text = dt.Rows[0].Field<Int64>("N_ID_PROFESSOR").ToString();
                tbox_nomeprof.Text = dt.Rows[0].Field<string>("T_NOME_PROFESSOR");
                mtbox_tel.Text = dt.Rows[0].Field<string>("T_TELEFONE");
            }
        }
        private void bt_addprof_Click(object sender, EventArgs e)
        {
            tbox_idprof.Clear();
            tbox_nomeprof.Clear();
            mtbox_tel.Clear();
            tbox_nomeprof.Focus();
        }
        private void bt_salvarprof_Click(object sender, EventArgs e)
        {
            string vquery;

            if (tbox_idprof.Text == "")
            {
                vquery = "INSERT INTO tb_professores (T_NOME_PROFESSOR, T_TELEFONE) VALUES ('" +tbox_nomeprof.Text+ "','" +mtbox_tel.Text+ "')";
            }
            else
            {
                vquery = "UPDATE tb_professores SET T_NOME_PROFESSOR = '" +tbox_nomeprof.Text+ "', T_TELEFONE = '" +mtbox_tel.Text+ "' WHERE N_ID_PROFESSOR = " +tbox_idprof.Text;
            }

            Banco.DML(vquery);

            vquery = @"
                SELECT
                    N_ID_PROFESSOR as 'ID',
                    T_NOME_PROFESSOR as 'Nome',
                    T_TELEFONE as 'Telefone'
                FROM
                    tb_professores
                ORDER BY
                    T_NOME_PROFESSOR 
            ";

            datagrid_professores.DataSource = Banco.DQL(vquery);
        }
        private void bt_excluirprof_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo excluir?", "Confirmação", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_professores WHERE N_ID_PROFESSOR = " +tbox_idprof.Text;
                Banco.DML(vquery);
                datagrid_professores.Rows.Remove(datagrid_professores.CurrentRow);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
