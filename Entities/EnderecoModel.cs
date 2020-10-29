using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EnderecoModel
    {
        public int EnderecoId { get; set; }
        public int TipoLogradouro { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public object Cep { get; set; }
        public int Cidade { get; set; }
        public int Estado { get; set; }
        public int PessoaId { get; set; }
    }
}
