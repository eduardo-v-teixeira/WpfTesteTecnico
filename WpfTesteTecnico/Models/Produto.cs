using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WpfTesteTecnico.Models
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public decimal Valor { get; set; }

        public Produto()
        {
            //criando um id unico para cada produto e de maneira automatica
            Id = Guid.NewGuid();
            Valor = 0.00m;
        }

        public List<Produto> ObterProdutos()
        {
            List<Produto> listaProdutos = new List<Produto>()
            {
                new Produto { Id = Guid.NewGuid(), Nome = "Produto A", Valor = 10.0m },
                new Produto { Id = Guid.NewGuid(), Nome = "Produto B", Valor = 20.0m },
                new Produto { Id = Guid.NewGuid(), Nome = "Produto C", Valor = 30.0m }
            };
            return listaProdutos;
        }
    }
}
