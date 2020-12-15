using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositories
{
    public class EstadoRepository
    {

        public Dictionary<Int64, Estado> GetAll()
        {
            Dictionary<Int64, Estado> mapaEstados = new Dictionary<Int64, Estado>();
            try
            {
                String SQL = "SELECT * FROM estado;";

                SqlDataReader data = Conexao.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Estado estado = new Estado();

                    estado.Id = data.GetInt64(0);
                    estado.Descricao = data.GetString(1);

                    mapaEstados.Add(estado.Id, estado);
                }

                data.Close();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaEstados;
        }
    }
}
