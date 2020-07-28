using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Week_6_In_Class
{
    public class RelayCommand : ICommand
    {
        private readonly Action _action;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action action)
        {
            _action = action;
        }


        public bool CanExecute(object parameter)
        {
            return true; // make button always clickable
        }

        public void Execute(object parameter)
        {
            _action();
        }

    }
}
