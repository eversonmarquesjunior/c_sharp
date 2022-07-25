using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Aplicativo_Academia
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        //Funções Genéricas
        public static DataTable DQL(string sql)     //DataQueryLanguage - (select)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vconexao = ConexaoBanco();

                var cmd = vconexao.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vconexao);
                da.Fill(dt);
                vconexao.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void DML(string q, string msgOK = null, string msgERRO = null)       //DataManipulationLanguage - (insert/delete/update)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vconexao = ConexaoBanco();

                var cmd = vconexao.CreateCommand();
                cmd.CommandText = q;
                da = new SQLiteDataAdapter(cmd.CommandText, vconexao);
                cmd.ExecuteNonQuery();
                vconexao.Close();

                if (msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
            }
            catch (Exception ex)
            {
                if (msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex.Message);
                }
                throw ex;
            }
        }

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = " + Global.caminhobanco + Global.nomebanco);
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vconexao = ConexaoBanco();

                var cmd = vconexao.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vconexao);
                da.Fill(dt);
                vconexao.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //FIM Funções Genéricas

        //Funções Formulário GestaoUsuarios

        public static DataTable ObterIdNomeUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vconexao = ConexaoBanco();

                var cmd = vconexao.CreateCommand();
                cmd.CommandText = "SELECT N_ID_USUARIO as 'ID Usuário', T_NOME_USUARIO as 'Nome Usuário' FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vconexao);
                da.Fill(dt);
                vconexao.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static DataTable ObterDadosUsuarios(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vconexao = ConexaoBanco();

                var cmd = vconexao.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios WHERE N_ID_USUARIO = " + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vconexao);
                da.Fill(dt);
                vconexao.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void AtualizarUsuarios(Usuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vconexao = ConexaoBanco();

                var cmd = vconexao.CreateCommand();
                cmd.CommandText = "UPDATE tb_usuarios SET T_NOME_USUARIO = '" + u.nome + "', T_USERNAME = '" + u.username + "', T_SENHA_USUARIO = '" + u.senha + "', T_STATUS_USUARIO = '" + u.status + "', N_NIVEL_USUARIO = " + u.nivel + " WHERE N_ID_USUARIO = " + u.id;
                da = new SQLiteDataAdapter(cmd.CommandText, vconexao);
                cmd.ExecuteNonQuery();
                vconexao.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void ExcluirUsuarios(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vconexao = ConexaoBanco();

                var cmd = vconexao.CreateCommand();
                cmd.CommandText = " DELETE FROM tb_usuarios WHERE N_ID_USUARIO = " + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vconexao);
                cmd.ExecuteNonQuery();
                vconexao.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Fim Funções Formulário GestaoUsuarios

        //Funções Formulário NovoUsuario

        public static void NovoUsuario(Usuario u)
        {
            if (ExisteUsername(u))
            {
                MessageBox.Show("Username já existe");
                return;
            }

            try
            {
                var vconexao = ConexaoBanco();

                var cmd = vconexao.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOME_USUARIO, T_USERNAME, T_SENHA_USUARIO, T_STATUS_USUARIO, N_NIVEL_USUARIO) VALUES (@nome, @username, @senha, @status, @nivel)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuário inserido");
                vconexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo usuário");
            }
        }

        //FIM Funções Formulário NovoUsuario

        //Rotinas Gerais

        public static bool ExisteUsername(Usuario u)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vconexao = ConexaoBanco();

            var cmd = vconexao.CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME = '" + u.username + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vconexao);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            vconexao.Close();
            return res;
        }
    }
}
