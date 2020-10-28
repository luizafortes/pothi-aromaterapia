using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositories.Interfaces
{
    public interface IOleoRepository : IBaseRepository<Oleo>
    {
        List<Oleo> GetByNome(string _nome);
        List<Oleo> GetBySintoma(string _sintoma);
        int CountSintomas(int _idOleo);
    }
}
