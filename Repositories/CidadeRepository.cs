using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositories
{
    public class CidadeRepository
    {

        public Dictionary<int, Cidade> ListarCidadesPorEstado(int _idEstado)
        {
            Dictionary<int, Cidade> mapaCidades = new Dictionary<int, Cidade>();
            try
            {
                String SQL = String.Format("SELECT * FROM cidades WHERE Id_Estado = {0};", _idEstado);

                SqlDataReader data = Conexao.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Cidade cidade = new Cidade();

                    cidade.Id_Cidade = Convert.ToInt32(data["Id_Cidade"]);
                    cidade.Nome = data["Nome"].ToString();
                    cidade.Id_Estado = Convert.ToInt32(data["Id_Estado"]);

                    mapaCidades.Add(cidade.Id_Cidade, cidade);
                }

                data.Close();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaCidades;
        }
    }
}
