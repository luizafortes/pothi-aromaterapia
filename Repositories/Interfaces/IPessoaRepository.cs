using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositories.Interfaces
{
    public interface IPessoaRepository : IBaseRepository<PessoaModel>
    {
        List<PessoaModel> GetByNome(string _nome);
        PessoaModel GetByEmail(string _email);
        PessoaModel GetByCpf(string _cpf);
        List<PessoaModel> GetByCidade(string _cidade);
        List<PessoaModel> GetByEstado(string _estado);
    }
}
