using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string TipoEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int PessoaId { get; set; }
    }
}
