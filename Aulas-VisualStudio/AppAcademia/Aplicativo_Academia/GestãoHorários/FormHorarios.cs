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
    public partial class FormHorarios : Form
    {
        public FormHorarios()
        {
            InitializeComponent();
        }

        private void FormHorarios_Load(object sender, EventArgs e)
        {
            string vquery = @"
                SELECT
                    N_ID_HORARIO as 'ID',
                    T_DSC_HORARIO as 'Horário'
                FROM
                    tb_horarios
                ORDER BY
                    T_DSC_HORARIO
            ";

            datagrid_horarios.DataSource = Banco.DQL(vquery);
            datagrid_horarios.Columns[0].Width = 60;
            datagrid_horarios.Columns[1].Width = 170;
        }

        private void datagrid_horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView) sender;

            int contlinhas = datagrid_horarios.SelectedRows.Count;

            if(contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                    SELECT 
                        * 
                    FROM
                        tb_horarios
                    WHERE N_ID_HORARIO = " +vid;

                dt = Banco.DQL(vquery);
                tbox_id.Text = dt.Rows[0].Field<Int64>("N_ID_HORARIO").ToString();
                mtbox_horario.Text = dt.Rows[0].Field<string>("T_DSC_HORARIO");
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            tbox_id.Clear();
            mtbox_horario.Clear();
            mtbox_horario.Focus();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            string vquery;

            if (tbox_id.Text == "")
            {
                vquery = @"
                INSERT INTO 
                    tb_horarios (T_DSC_HORARIO)
                VALUES
                    ('" +mtbox_horario.Text+ "')";
            }
            else
            {
                vquery = @"
                UPDATE 
                    tb_horarios 
                SET
                    T_DSC_HORARIO = '" +mtbox_horario.Text+ "' WHERE N_ID_HORARIO = " + tbox_id.Text;   
            }

            Banco.DML(vquery);

            vquery = @"
                SELECT
                    N_ID_HORARIO as 'ID',
                    T_DSC_HORARIO as 'Horário'
                FROM
                    tb_horarios
                ORDER BY
                    T_DSC_HORARIO 
            ";

            datagrid_horarios.DataSource = Banco.DQL(vquery);
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo excluir?", "Confirmação", MessageBoxButtons.YesNo);

            if(res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_horarios WHERE N_ID_HORARIO = " +tbox_id.Text;
                Banco.DML(vquery);
                datagrid_horarios.Rows.Remove(datagrid_horarios.CurrentRow);
            }
        }
    }
}
