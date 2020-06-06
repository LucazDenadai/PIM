using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entity
{
    public abstract class PessoaEntity
    { 
        public string Documento { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string dataCadastro { get; set; }

        public string dataNascimento { get; set; }

        public EnderecoEntity Endereco { get; set; } = new EnderecoEntity();
    }
}
