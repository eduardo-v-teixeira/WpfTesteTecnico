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
        public Guid Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public List<Produto> Produtos { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataVenda { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public Status Status { get; set; }

    }
}
