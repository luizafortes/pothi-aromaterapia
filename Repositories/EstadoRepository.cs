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

        public Dictionary<int, Estado> GetAll()
        {
            Dictionary<int, Estado> mapaEstados = new Dictionary<int, Estado>();
            try
            {
                String SQL = "SELECT * FROM estados;";

                SqlDataReader data = Conexao.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Estado estado = new Estado();

                    estado.Id_Estado = Convert.ToInt32(data["Id_Estado"]);
                    estado.Nome = data["Nome"].ToString();

                    mapaEstados.Add(estado.Id_Estado, estado);
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
