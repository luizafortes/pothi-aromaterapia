using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositories.Interfaces
{
    public interface ISintomaRepository : IBaseRepository<SintomaModel>
    {
        List<SintomaModel> GetByNome(string _nome);
        List<SintomaModel> GetByOleo(string _oleo);
        int CountOleos(int _idSintoma);
    }
}
