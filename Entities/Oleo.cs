using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Oleo
    {
        public int OleoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<Sintoma> Sintomas { get; set; }
    }
}
