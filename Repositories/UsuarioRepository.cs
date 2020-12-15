using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositories
{
    public class UsuarioRepository
    {

        #region "Operações com Banco de Dados"

        public Dictionary<Int64, UsuarioModel> GetAll()
        {
            Dictionary<Int64, UsuarioModel> mapaUsuarios = new Dictionary<Int64, UsuarioModel>();
            try
            {
                String SQL = "SELECT * FROM usuario;";

                SqlDataReader data = Conexao.ExecutarSelect(SQL);

                while (data.Read())
                {
                    UsuarioModel u = new UsuarioModel();

                    u.Login = data["Login"].ToString();
                    u.Senha = data["Senha"].ToString();
                    u.Nome = data["Nome"].ToString();
                    u.Email = data["Email"].ToString();

                    mapaUsuarios.Add(u.UsuarioId, u);
                }

                data.Close();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaUsuarios;
        }

        public UsuarioModel GetForID(int _id)
        {
            UsuarioModel u = null;
            try
            {
                String SQL = String.Format("SELECT * FROM usuario WHERE usuarioId = {0};", _id);

                SqlDataReader data = Conexao.ExecutarSelect(SQL);

                if (data.Read())
                {
                    u = new UsuarioModel();

                    u.UsuarioId = Convert.ToInt32(data["usuarioId"]);
                    u.Nome = data["Nome"].ToString();
                    u.Tel = data["Tel"].ToString();
                    u.Email = data["Email"].ToString();
                }

                data.Close();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return u;
        }

        public Boolean Insert(UsuarioModel _obj)
        {
            Boolean resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO usuario (" +
                    "login, " +
                    "senha, " +
                    "nome, " +
                    "email) " +
                    "VALUES ({0}, '{1}', '{2}', '{3}')",
                    _obj.Login.ToString(),
                    _obj.Nome.ToString(),
                    _obj.Senha.ToString(),
                    _obj.Email.ToString()
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
                String SQL = "DELETE FROM usuario WHERE usuarioId = " + _id;

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

        public Boolean Update(UsuarioModel _obj)
        {
            Boolean resultado = false;
            try
            {
                String SQL = String.Format("UPDATE usuario SET " +
                    "login = '{0}', " +
                    "senha = '{1}', " +
                    "nome = '{2}', " +
                    "email = '{3}' WHERE usuarioId = {4}",
                    _obj.Login,
                    _obj.Senha,
                    _obj.Nome,
                    _obj.Email
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
        public Dictionary<int, UsuarioModel> BuscarListaFiltrada(String _filtros)
        {
            Dictionary<int, UsuarioModel> mapaUsuarios = new Dictionary<int, UsuarioModel>();
            try
            {
                String SQL = "SELECT * FROM usuario WHERE ";

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
                    UsuarioModel u = new UsuarioModel();

                    u.UsuarioId = Convert.ToInt32(data["usuarioId"]);
                    u.Nome = data["Nome"].ToString();
                    u.Tel = data["Tel"].ToString();
                    u.Email = data["Email"].ToString();

                    mapaUsuarios.Add(u.UsuarioId, u);
                }

                data.Close();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaUsuarios;
        }

        #endregion
    }
}
