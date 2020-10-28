using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;

namespace Entities
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public Sexo Sexo  { get; set; }
        public string EstadoCivil { get; set; }
        public Endereco Endereco { get; set; }
    }
}
