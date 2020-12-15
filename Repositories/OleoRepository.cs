using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositories
{
    public class OleoRepository
    {
        #region "Operações com Banco de Dados"

        public Dictionary<int, OleoModel> GetAll()
        {
            Dictionary<int, OleoModel> mapaOleos = new Dictionary<int, OleoModel>();
            try
            {
                String SQL = "SELECT * FROM oleo;";

                SqlDataReader data = Conexao.ExecutarSelect(SQL);

                while (data.Read())
                {
                    OleoModel o = new OleoModel();

                    o.OleoId = Convert.ToInt32(data["OleoId"]);
                    o.Nome = data["Nome"].ToString();
                    o.Descricao = data["Descricao"].ToString();

                    mapaOleos.Add(o.OleoId, o);
                }

                data.Close();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaOleos;
        }

        public OleoModel GetForID(int _id)
        {
            OleoModel o = null;
            try
            {
                String SQL = String.Format("SELECT * FROM oleo WHERE usuarioId = {0};", _id);

                SqlDataReader data = Conexao.ExecutarSelect(SQL);

                if (data.Read())
                {
                    o = new OleoModel();


                    o.OleoId = Convert.ToInt32(data["OleoId"]);
                    o.Nome = data["Nome"].ToString();
                    o.Descricao = data["Descricao"].ToString();
                }

                data.Close();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return o;
        }

        public Boolean Insert(OleoModel _obj)
        {
            Boolean resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO oleo (" +
                    "nome, " +
                    "descricao) " +
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
                String SQL = "DELETE FROM oleo WHERE usuarioId = " + _id;

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

        public Boolean Update(OleoModel _obj)
        {
            Boolean resultado = false;
            try
            {
                String SQL = String.Format("UPDATE oleo SET " +
                    "nome = '{0}', " +
                    "descricao = '{1}' WHERE oleoId = {2}",
                    _obj.Nome.ToString(),
                    _obj.Descricao.ToString(),
                    _obj.OleoId.ToString()
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
        public Dictionary<int, OleoModel> BuscarListaFiltrada(String _filtros)
        {
            Dictionary<int, OleoModel> mapaOleos = new Dictionary<int, OleoModel>();
            try
            {
                String SQL = "SELECT * FROM oleo WHERE ";

                int saida;
                if (int.TryParse(_filtros, out saida))
                {
                    SQL += String.Format("usuarioId = {0}", _filtros);
                }
                else
                {
                    SQL += String.Format("nome LIKE '%{0}%'", _filtros);
                }

                SqlDataReader data = Conexao.ExecutarSelect(SQL);

                while (data.Read())
                {
                    OleoModel o = new OleoModel();

                    o.OleoId = Convert.ToInt32(data["OleoId"]);
                    o.Nome = data["Nome"].ToString();
                    o.Descricao = data["Descricao"].ToString();

                    mapaOleos.Add(o.OleoId, o);
                }

                data.Close();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaOleos;
        }

        #endregion
    }
}
