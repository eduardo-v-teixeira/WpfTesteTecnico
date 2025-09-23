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
        public Guid Id { get; private set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public string? Endereco { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public Pessoa()
        {
            //criando um id unico para cada pessoa e de maneira automatica
            Id = Guid.NewGuid();
            Pedidos = new List<Pedido>();
        }
        public Pessoa(string nome, int cpf, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
        }
    }
}
