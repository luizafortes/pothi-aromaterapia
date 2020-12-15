using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Entities.Interfaces.Repositories
{
    public interface IOleoRepository : IBase<OleoModel>
    {
        List<OleoModel> GetByNome(string _nome);
        List<OleoModel> GetBySintoma(string _sintoma);
        int CountSintomas(int _idOleo);
    }
}
