using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace POO_3D2_38_13.DAL
{
    public class dalsql
    {
        private MySqlConnection conexao;
        private string string_conexao = "Persist security info = false;" +
                                        "server=localhost;" +
                                        "database=BD_Livraria;" +
                                        "user=root ; pwd=;";
        public void conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException e)
            {
                throw new Exception("Problemas de conexão com banco de dados. \nErro: " + e.Message);
            }
        }

        public void executarComando(string sql)
        {
            try
            {
                conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possível executar a instrução no Banco de Dados.. Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public DataTable executarConsulta(string sql)
        {
            try
            {
                conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possível selecionar os registros no Banco de Dados. Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}