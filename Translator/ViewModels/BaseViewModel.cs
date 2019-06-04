using System;
using System.Linq;
using System.Windows;
using System.ComponentModel;

namespace Translator.ViewModels
{
    class BaseViewModel : DependencyObject, INotifyPropertyChanged
	{
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
