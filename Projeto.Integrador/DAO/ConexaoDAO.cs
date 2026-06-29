using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Integrador.DAO
{
    internal class ConexaoDAO
    {
        private static string _stringConexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BancoCaixaEletronico;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
        
        public static SqlConnection ObterConexao()
        {
            SqlConnection conexao = new SqlConnection(_stringConexao);
            conexao.Open();
            return conexao;
        }
    }
}
