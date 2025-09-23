using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfTesteTecnico.ViewModels;

namespace WpfTesteTecnico.Views
{
    /// <summary>
    /// Interação lógica para ProdutoBuscar.xam
    /// </summary>
    public partial class ProdutoBuscar : Page
    {
        public ProdutoBuscar()
        {
            InitializeComponent();
            DataContext = new ProdutoViewModel();
        }
    }
}
