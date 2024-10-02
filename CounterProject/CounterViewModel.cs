using ItenaryProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CounterProject.Properties
{
    public class CounterViewModel : INotifyPropertyChanged
    {
        private int _counter;

        public int Counter
        {
            get { return _counter; }
            set {
                
                    _counter = value; OnPropertyChanged("Counter");
                } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand IncrementCommand { get; }
        public ICommand DecrementCommand { get; }
        public CounterViewModel()
        {
            IncrementCommand = new RelayCommand(Increment);
            DecrementCommand = new RelayCommand(Decrement);

            void Increment()
            { Counter++; }
            void Decrement()
            { Counter--; }
        }

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
