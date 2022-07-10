using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace Sample.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private string? _Greeting = "Hello {0}";

        public string? Greeting
        {
            get => _Greeting;
            set => SetProperty(ref _Greeting, value);
        }


        private string? _Name;
        public string? Name
        {
            get => _Name; 
            set
            {
                if (SetProperty(ref _Name, value))
                {
                    // If the name changed, notify our result changed as well. 
                    OnPropertyChanged(nameof(Result));
                }
            }
        }

        public string Result => string.Format(Greeting ?? "{0}", Name);
    }
}
