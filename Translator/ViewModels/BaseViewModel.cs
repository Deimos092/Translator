using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.ComponentModel;

namespace Translator.ViewModels
{
    class BaseViewModel : DependencyObject, INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		internal void OnPropertyChanged( string propertyName , object sender = null )
		{
			PropertyChanged?.Invoke(sender ?? this , new PropertyChangedEventArgs(propertyName));
		}
	}
}
