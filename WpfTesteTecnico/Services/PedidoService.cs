using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTesteTecnico.Models;
using WpfTesteTecnico.Models.Enums;

namespace WpfTesteTecnico.Services
{
    public class PedidoService
    {
        private readonly DataService<Pedido> _data;

        public PedidoService(string filePath)
        {
            _data = new DataService<Pedido>(filePath);
        }

        public List<Pedido> GetAll() => _data.Load();

        public void Add(Pedido p)
        {
            var list = _data.Load();
            list.Add(p);
            _data.Save(list);
        }

        public void AtualizarStatus(Guid id, Status novo)
        {
            var list = _data.Load();
            var pedido = list.FirstOrDefault(x => x.Id == id);
            if (pedido != null)
            {
                pedido.Status = novo;
                _data.Save(list);
            }
        }

        public void AtualizarFormaPagamento(Guid id, FormaPagamento forma)
        {
            var list = _data.Load();
            var pedido = list.FirstOrDefault(x => x.Id == id);
            if (pedido != null)
            {
                pedido.FormaPagamento = forma;
                _data.Save(list);
            }
        }

        public List<Pedido> FiltrarPorStatus(Status status) =>
            _data.Load().Where(p => p.Status == status).ToList();

        public List<Pedido> FiltrarPorPessoa(Guid pessoaId) =>
            _data.Load().Where(p => p.Pessoa != null && p.Pessoa.Id == pessoaId).ToList();
    }

}
