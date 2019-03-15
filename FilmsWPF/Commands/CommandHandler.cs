using System;
using System.Windows.Input;

namespace FilmsWPF.Commands
{
    public class CommandHandler : ICommand
    {
        public Action<object> ExecuteMethod { get; set; }
        public Func<object, bool> CanExecuteMethod { get; set; }


        public CommandHandler(Action<object> executeMethod, Func<object, bool> canExecuteMethod)
        {
            this.ExecuteMethod = executeMethod;
            this.CanExecuteMethod = canExecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            return CanExecuteMethod(parameter);
        }

        public void Execute(object parameter)
        {
            ExecuteMethod(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
