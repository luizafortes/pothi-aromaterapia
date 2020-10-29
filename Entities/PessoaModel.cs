using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;

namespace Entities
{
    public class PessoaModel
    {
        public PessoaModel()
        {
            this.Endereco = new EnderecoModel();
        }
        public int PessoaId { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public Sexo Sexo  { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public bool Filhos { get; set; }
        public bool Animais { get; set; }
        public bool Fumante { get; set; }
        public EnderecoModel Endereco { get; set; }
    }
}
