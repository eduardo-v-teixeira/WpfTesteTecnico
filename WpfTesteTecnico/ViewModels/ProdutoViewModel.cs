using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfTesteTecnico.Models;
using WpfTesteTecnico.Services;

namespace WpfTesteTecnico.ViewModels
{
    public class ProdutoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged; //evento que ocorrera quando a propriedade for modificada

        public ObservableCollection<Produto> Produto { get; set; }
        public ICommand BuscarProduto { get; set; }

        public ProdutoViewModel()
        {
            BuscarProduto = new RelayCommand(ObterProdutos);
        }

        public void ObterProdutos(object obj)
        {
            {
                var produtoList = new Produto().ObterProdutos();
                Produto = new ObservableCollection<Produto>(produtoList);//Convertendo uma lista em ObservableCollection
                NotifyPropertyChanged("Produto");
            }
            ;
        }
        public void NotifyPropertyChanged(string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));//avisa que ocorreu uma mudança na propriedade
        }
    }
}
