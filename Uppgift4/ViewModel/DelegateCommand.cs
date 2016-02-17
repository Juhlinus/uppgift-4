using System;
using System.Windows.Input;

namespace Uppgift4.ViewModel
{
    public class DelegateCommand : ICommand
    {
        // Each action is stored in _action
        private readonly Action _action;

        // When a command is delegated then 
        // reroute it to the appropriate action
        public DelegateCommand(Action action)
        {
            _action = action;
        }

        // Execute specific action
        public void Execute(object parameter)
        {
            _action();
        }

        // Check if aciton can be executed
        public bool CanExecute(object parameter)
        {
            return true;
        }

        // An event handler that captures all actions
        public event EventHandler CanExecuteChanged { add { } remove { } }
    }
}