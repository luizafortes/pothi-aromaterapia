using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositories.Interfaces
{
    public interface IPessoaRepository : IBaseRepository<Pessoa>
    {
        List<Pessoa> GetByNome(string _nome);
        Pessoa GetByEmail(string _email);
        Pessoa GetByCpf(string _cpf);
        List<Pessoa> GetByCidade(string _cidade);
        List<Pessoa> GetByEstado(string _estado);
    }
}
