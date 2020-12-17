using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositories
{
    public class SintomaRepository
    {
        #region "Operações com Banco de Dados"

        public Dictionary<int, SintomaModel> GetAll()
        {
            Dictionary<int, SintomaModel> mapaSintomas = new Dictionary<int, SintomaModel>();
            try
            {
                String SQL = "SELECT * FROM sintoma;";

                SqlDataReader data = Conexao.ExecutarSelect(SQL);

                while (data.Read())
                {
                    SintomaModel s = new SintomaModel();

                    s.SintomaId = Convert.ToInt32(data["SintomaId"]);
                    s.Nome = data["Nome"].ToString();

                    mapaSintomas.Add(s.SintomaId, s);
                }

                data.Close();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaSintomas;
        }

        public SintomaModel GetForID(int _id)
        {
            SintomaModel s = null;
            try
            {
                String SQL = String.Format("SELECT * FROM sintoma WHERE sintomaId = {0};", _id);

                SqlDataReader data = Conexao.ExecutarSelect(SQL);

                if (data.Read())
                {
                    s = new SintomaModel();

                    s.SintomaId = Convert.ToInt32(data["SintomaId"]);
                    s.Nome = data["Nome"].ToString();
                }

                data.Close();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return s;
        }

        public Boolean Insert(SintomaModel _obj)
        {
            Boolean resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO sintoma (" +
                    "nome, descricao) " +
                    "VALUES ('{0}', '{1}')",
                    _obj.Nome.ToString(),
                    _obj.Descricao.ToString()
                    );

                int linhasAfetadas = Conexao.ExecutarIDU(SQL);

                if (linhasAfetadas > 0)
                {
                    resultado = true;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Boolean Delete(int _id)
        {
            Boolean resultado = false;
            try
            {
                String SQL = "DELETE FROM sintoma WHERE sintomaId = " + _id;

                int linhasAfetadas = Conexao.ExecutarIDU(SQL);

                if (linhasAfetadas > 0)
                {
                    resultado = true;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean Update(SintomaModel _obj)
        {
            Boolean resultado = false;
            try
            {
                String SQL = String.Format("UPDATE sintoma SET " +
                    "nome = '{0}' WHERE sintomaId = {1}",
                    _obj.Nome.ToString(),
                    _obj.SintomaId.ToString()
                    );

                int linhasAfetadas = Conexao.ExecutarIDU(SQL);

                if (linhasAfetadas > 0)
                {
                    resultado = true;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Adicionado para implementar as opções de filtro
        public Dictionary<int, SintomaModel> BuscarListaFiltrada(String _filtros)
        {
            Dictionary<int, SintomaModel> mapaSintomas = new Dictionary<int, SintomaModel>();
            try
            {
                String SQL = "SELECT * FROM sintoma WHERE ";

                int saida;
                if (int.TryParse(_filtros, out saida))
                {
                    SQL += String.Format("sintomaId = {0}", _filtros);
                }
                else
                {
                    SQL += String.Format("nome LIKE '%{0}%'", _filtros);
                }

                SqlDataReader data = Conexao.ExecutarSelect(SQL);

                while (data.Read())
                {
                    SintomaModel s = new SintomaModel();

                    s.SintomaId = Convert.ToInt32(data["SintomaId"]);
                    s.Nome = data["Nome"].ToString();

                    mapaSintomas.Add(s.SintomaId, s);
                }

                data.Close();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaSintomas;
        }

        #endregion
    }
}
