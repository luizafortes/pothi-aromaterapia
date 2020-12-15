using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlServerCe;
using System.Data;
using System.Data.SqlClient;

namespace Repositories
{
    public static class Conexao
    {
        private static String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=pothiAromaterapia_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private static SqlConnection conexao;

        public static void AbrirConexao()
        {
            try
            {
                if (conexao != null)
                {
                    if (conexao.State == ConnectionState.Closed)
                    {
                        conexao.ConnectionString = connectionString;
                        conexao.Open();
                    }
                }
                else
                {
                    conexao = new SqlConnection(connectionString);
                    conexao.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                if (conexao != null)
                {
                    if (conexao.State == ConnectionState.Open)
                    {
                        conexao.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static SqlDataReader ExecutarSelect(String _SQL)
        {
            try
            {
                AbrirConexao();

                SqlCommand comando = new SqlCommand(_SQL, conexao);

                SqlDataReader data = comando.ExecuteReader();

                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int ExecutarIDU(String _SQL)
        {
            int linhasAfetadas = 0;
            try
            {
                AbrirConexao();

                SqlCommand comando = new SqlCommand(_SQL, conexao);

                linhasAfetadas = comando.ExecuteNonQuery();


                FecharConexao();

                return linhasAfetadas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int ExecutarIDU(String _SQL, CommandType type)
        {
            int linhasAfetadas = 0;
            try
            {
                AbrirConexao();

                SqlCommand comando = new SqlCommand(_SQL, conexao);

                linhasAfetadas = comando.ExecuteNonQuery();


                FecharConexao();

                return linhasAfetadas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Object ExecutarInsertComRetornoID(String _SQL, List<SqlParameter> _parametros)
        {
            try
            {
                // Execução do INSERT
                AbrirConexao();
                SqlCommand comando = new SqlCommand(_SQL, conexao);
                comando.Parameters.AddRange(_parametros.ToArray());
                comando.ExecuteNonQuery();

                //RETORNO DA CHAVE PRIMARIA DE FORMA GENÉRICA (Pode ser Qualquer Tipo)
                comando.CommandText = "SELECT @@IDENTITY";
                Object chavePrimaria = comando.ExecuteScalar();

                FecharConexao();

                return chavePrimaria;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
