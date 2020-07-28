using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Week_6_In_Class
{
    public class MainVM : INotifyPropertyChanged
    {
        private string textBlockMessage;

        public string TextBlockMessage
        {
            get { return textBlockMessage; }
            set
            {
                textBlockMessage = value;
                NotifyProperty();
            }
        }

        public ICommand ButtonCommand { get; set; }
        private int num = 0;

        public MainVM()
        {
            TextBlockMessage = "Hello World from VM";

            ButtonCommand = new RelayCommand(() =>
            {
                TextBlockMessage = $"You clicked me {++num} times!";
            });
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void NotifyProperty([CallerMemberName]string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}