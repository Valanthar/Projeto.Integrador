using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Projeto.Integrador.DAO
{
    public class ConexaoDAO
    {
        public static readonly string conexao =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\BancoProjeto.mdf;
              Integrated Security=True;
              Connect Timeout=30";

        public static SqlConnection ObterConexao(SqlConnection conn)
        {
            using SqlConnection novaConexao = new SqlConnection(conexao);
            novaConexao.Open();

            return novaConexao;
        }
    }
}

