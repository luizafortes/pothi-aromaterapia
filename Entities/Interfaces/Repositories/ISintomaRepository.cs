using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces.Repositories
{
    public interface ISintomaRepository : IBase<SintomaModel>
    {
        List<SintomaModel> GetByNome(string _nome);
        List<SintomaModel> GetByOleo(string _oleo);
        int CountOleos(int _idSintoma);
    }
}
