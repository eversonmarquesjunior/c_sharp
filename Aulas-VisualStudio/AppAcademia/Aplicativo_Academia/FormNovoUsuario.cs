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
    public partial class FormNovoUsuario : Form
    {
        public FormNovoUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.nome = tbox_nome.Text;
            usuario.username = tbox_username.Text;
            usuario.senha = tbox_senha.Text;
            usuario.status = cb_status.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(numeric_nivel.Value, 0));

            Banco.NovoUsuario(usuario);
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            tbox_nome.Clear();
            tbox_username.Clear();
            tbox_senha.Clear();
            cb_status.Text = "";
            numeric_nivel.Value = 1;
            tbox_nome.Focus();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            tbox_nome.Clear();
            tbox_username.Clear();
            tbox_senha.Clear();
            cb_status.Text = "";
            numeric_nivel.Value = 1;
            tbox_nome.Focus();
        }
    }
}
