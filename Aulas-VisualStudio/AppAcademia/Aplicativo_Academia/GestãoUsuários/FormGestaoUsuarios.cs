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
    public partial class FormGestaoUsuarios : Form
    {
        public FormGestaoUsuarios()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormGestaoUsuarios_Load(object sender, EventArgs e)
        {
            datagrid_usuarios.DataSource = Banco.ObterIdNomeUsuarios();

            datagrid_usuarios.Columns[0].Width = 90;
            datagrid_usuarios.Columns[1].Width = 190;
        }

        private void datagrid_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView) sender;

            int contlinhas = dgv.SelectedRows.Count;

            if(contlinhas > 0)
            {
                DataTable dt = new DataTable();

                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuarios(vid);

                tbox_id.Text = dt.Rows[0].Field<Int64>("N_ID_USUARIO").ToString();
                tbox_nome.Text = dt.Rows[0].Field<string>("T_NOME_USUARIO").ToString();
                tbox_username.Text = dt.Rows[0].Field<string>("T_USERNAME").ToString();
                tbox_senha.Text = dt.Rows[0].Field<string>("T_SENHA_USUARIO").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("T_STATUS_USUARIO").ToString();
                numeric_nivel.Value = dt.Rows[0].Field<Int64>("N_NIVEL_USUARIO");
            }

            
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_novouser_Click(object sender, EventArgs e)
        {
            FormNovoUsuario formnovousuario = new FormNovoUsuario();
            formnovousuario.ShowDialog();
            datagrid_usuarios.DataSource = Banco.ObterIdNomeUsuarios();
        }

        private void bt_salvaralt_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            int linha = datagrid_usuarios.SelectedRows[0].Index;

            u.id = Convert.ToInt32(tbox_id.Text);
            u.nome = tbox_nome.Text;
            u.username = tbox_username.Text;
            u.senha = tbox_senha.Text;
            u.status = cb_status.Text;
            u.nivel = Convert.ToInt32(Math.Round(numeric_nivel.Value, 0));
            Banco.AtualizarUsuarios(u);

            //datagrid_usuarios.DataSource = Banco.ObterIdNomeUsuarios();
            //datagrid_usuarios.CurrentCell = datagrid_usuarios[0, linha];

            datagrid_usuarios[1, linha].Value = tbox_nome.Text;
        }

        private void bt_excluiruser_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo excluir?", "Confirmação", MessageBoxButtons.YesNo);

            if(res == DialogResult.Yes)
            {
                Banco.ExcluirUsuarios(tbox_id.Text);
                datagrid_usuarios.Rows.Remove(datagrid_usuarios.CurrentRow);
            }
        }
    }
}
