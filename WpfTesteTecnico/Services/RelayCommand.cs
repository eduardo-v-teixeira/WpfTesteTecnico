using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfTesteTecnico.Services
{
    public class RelayCommand : ICommand 
    {
        private Action<object> excute; //propriedade que representa a ação a ser executada
        private Func<object, bool> canExecute;

        public event EventHandler? CanExecuteChanged // manipulador de eventos que é acionado quando a capacidade de execução do comando muda
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null) // Construtor que inicializa as propriedades excute e canExecute
        {
            this.excute = execute;
            this.canExecute = canExecute;
        }
        public bool CanExecute(object parameter) // Verifica se o metodo do contrutor pode ser executado 
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public void Execute(object parameter) // Executa o metodo do contrutor
        {
            this.excute(parameter);
        }
    }
}
