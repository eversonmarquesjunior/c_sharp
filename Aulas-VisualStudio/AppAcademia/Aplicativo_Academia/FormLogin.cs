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
    public partial class FormLogin : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public FormLogin(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void bt_logar_Click(object sender, EventArgs e)
        {
            string username = tbox_user.Text;
            string senha = tbox_senha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuário e/ou senha inválidos");
                tbox_user.Focus();
                return;
            }

            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME = '" +username+ "' AND T_SENHA_USUARIO = '" +senha+ "'";
            dt = Banco.Consulta(sql);

            if (dt.Rows.Count == 1)
            {
                form1.label_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.label_nomeuser.Text = dt.Rows[0].Field<string>("T_NOME_USUARIO");
                form1.pb_statuslog.Image = Properties.Resources.botaoverde;
                Global.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVEL_USUARIO").ToString());
                Global.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
