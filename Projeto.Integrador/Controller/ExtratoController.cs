using Microsoft.Data.SqlClient;
using Projeto.Integrador.Model;
using System;
using System.Collections.Generic;

namespace Projeto.Integrador.DAO
{
    internal class ExtratoController
    {
        public void RegistrarOperacao(Extrato extrato)
        {
            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            {
                string sql = "INSERT INTO Extrato (NumeroConta, Tipo, Valor, DataOperacao) " +
                             "VALUES (@NumeroConta, @Tipo, @Valor, @DataOperacao)";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@NumeroConta", extrato.NumeroConta);
                comando.Parameters.AddWithValue("@Tipo", extrato.Tipo);
                comando.Parameters.AddWithValue("@Valor", extrato.Valor);
                comando.Parameters.AddWithValue("@DataOperacao", extrato.DataOperacao);

                comando.ExecuteNonQuery();
            }
        }

        public List<Extrato> BuscarExtrato(int numeroConta)
        {
            List<Extrato> extratos = new List<Extrato>();

            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            {
                string sql = "SELECT * FROM Extrato WHERE NumeroConta = @NumeroConta " +
                             "ORDER BY DataOperacao DESC";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@NumeroConta", numeroConta);

                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    Extrato extrato = new Extrato(
                        Convert.ToInt32(leitor["Id"]),
                        Convert.ToInt32(leitor["NumeroConta"]),
                        leitor["Tipo"].ToString(),
                        Convert.ToDouble(leitor["Valor"]),
                        Convert.ToDateTime(leitor["DataOperacao"])
                    );
                    extratos.Add(extrato);
                }
            }

            return extratos;
        }
    }
}