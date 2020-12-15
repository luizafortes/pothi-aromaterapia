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

        public Dictionary<Int64, Cidade> ListarCidadesPorEstado(Int64 _idEstado)
        {
            Dictionary<Int64, Cidade> mapaCidades = new Dictionary<Int64, Cidade>();
            try
            {
                String SQL = String.Format("SELECT * FROM cidade WHERE estado_id = {0};", _idEstado);

                SqlDataReader data = Conexao.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Cidade cidade = new Cidade();

                    cidade.Id = data.GetInt64(0);
                    cidade.Descricao = data.GetString(1);

                    mapaCidades.Add(cidade.Id, cidade);
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
