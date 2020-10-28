using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Sintoma
    {
        public int SintomaId { get; set; }
        public string Nome { get; set; }
        public List<Oleo> Oleos { get; set; }
    }
}
