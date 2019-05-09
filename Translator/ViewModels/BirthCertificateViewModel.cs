using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Translator.Utils;

namespace Translator.ViewModels
{
	class BirthCertificateViewModel : NavigateViewModel
	{
		public BirthCertificateViewModel()
		{
			Title = "Свидетельство и рождении";
		}
		private ICommand _page2Command;

		public ICommand Page2Command
		{
			get
			{
				if ( _page2Command == null )
				{
					_page2Command = new RelayCommand(() =>
					{
						Navigate("View/Page2.xaml");
					});
				}
				return _page2Command;
			}
			set { _page2Command = value; }
		}
	}
}
