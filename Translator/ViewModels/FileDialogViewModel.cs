using System;
using System.IO;
using System.Windows.Input;
using Translator.Utils;

namespace Translator.ViewModels
{
	class FileDialogViewModel
	{
		public FileDialogViewModel()
		{
			//this.SaveCommand = new RelayCommand(this.SaveFile);
			this.OpenCommand = new RelayCommand(this.OpenFile);
		}

		public string FileName { get; set; }
		public string Extension { get; set; }
		public string Filter { get; set; }
		public ICommand OpenCommand { get; set; }
		public ICommand SaveCommand { get; set; }

		private void OpenFile()
		{
			FileService fileServices = new FileService();
			this.FileName = fileServices.OpenFile(this.Extension , this.Filter);
		}

		//private void SaveFile()
		//{
		//	FileService fileServices = new FileService();
		//	this.FileName = fileServices.SaveFile(this.Extension , this.Filter);
		//}
	}
}
