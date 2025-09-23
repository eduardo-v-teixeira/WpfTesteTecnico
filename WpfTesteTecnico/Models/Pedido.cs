using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTesteTecnico.Models.Enums;

namespace WpfTesteTecnico.Models
{
    public class Pedido
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Pessoa Pessoa { get; set; }
        public List<ItemPedido> Produtos { get; set; } = new List<ItemPedido>();
        public decimal ValorTotal => Produtos.Sum(i => i.Produto.Valor * i.Quantidade);
        public DateTime DataVenda { get; set; } = DateTime.Now;
        public FormaPagamento FormaPagamento { get; set; }
        public Status Status { get; set; } = Status.Pendente;
    }
}
