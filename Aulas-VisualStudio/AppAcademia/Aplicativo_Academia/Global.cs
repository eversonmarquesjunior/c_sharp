using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Academia
{
    internal class Global
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0; //1-comum / 2-gerente / 3-master
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomebanco = "Banco_Academia.db";
        public static string caminhobanco = caminho+ @"\Banco\";

        //DADOS tb_usuarios
        //N_ID_USUARIO, T_NOME_USUARIO, T_USERNAME, T_SENHA_USUARIO, T_STATUS_USUARIO, N_NIVEL_USUARIO

    }
}
