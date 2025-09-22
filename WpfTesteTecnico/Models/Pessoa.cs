using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace WpfTesteTecnico.Models
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public string Endereco { get; set; }

        public Pessoa()
        {
            //criando um id unico para cada pessoa e de maneira automatica
            Id = Guid.NewGuid();
        }
        public Pessoa(string nome, int cpf, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
        }
    }
}
