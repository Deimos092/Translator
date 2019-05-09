using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;
using Translator.Utils;

namespace Translator.ViewModels
{
	class NavigateViewModel : BaseViewModel
	{
		public NavigateViewModel()
		{

		}

		public string Title { get; set; }
		public void Navigate( string url )
		{
			Messenger.Default.Send<NavigateArgs>(new NavigateArgs(url));
		}
	}
}
