using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces.Repositories
{
    public interface IPessoaRepository : IBase<PessoaModel>
    {
        List<PessoaModel> GetByNome(string _nome);
        PessoaModel GetByEmail(string _email);
        PessoaModel GetByCpf(string _cpf);
        List<PessoaModel> GetByCidade(string _cidade);
        List<PessoaModel> GetByEstado(string _estado);
    }
}
