using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.ObjectModel;
using Translator.Models;
using System.Reflection;
using System.Windows.Input;
using Translator.Utils;
using System.Globalization;
using GalaSoft.MvvmLight.Messaging;

namespace Translator.ViewModels
{
	class MainViewModel : BaseViewModel
	{
		private string _selectedPath;
		private WordTemplate _slectedTemplate;
		
		public MainViewModel()
		{
			this.OpenFolderTemplate = new RelayCommand(this.OpenFolderAndLoadTemplate);
			this.LoadSelectWordTemplate = new RelayCommand(this.OpenTemplateAndLoadToView);
		}
		public ObservableCollection<WordTemplate> MyTemplates { get; set; }//???
		private DataWordTemplate DataWord { get; set; }
		public WordTemplate SelectTemplate
		{
			get { return _slectedTemplate; }
			set {
				_slectedTemplate = value;
				OnPropertyChanged("SelectTemplate"); }
		}
		public List<string> NamePagesList { get; set; }
		public string PathTemplate
		{
			get { return _selectedPath; }
			set {
				_selectedPath = value;
				OnPropertyChanged("PathTemplate");
			}
		}
		public ICommand OpenFolderTemplate { get; set; }
		public ICommand LoadSelectWordTemplate { get; set; }
		private void OpenFolderAndLoadTemplate()
		{
			
			FileDialogViewModel DialogViewModel = new FileDialogViewModel();
			DialogViewModel.Extension = "*.docx";
			DialogViewModel.Filter = "Word docx (.docx)|*.docx|Old Word doc(.doc)|*.doc|All Files(.*)|*.*";

			if(DialogViewModel.OpenCommand.CanExecute(null))
				DialogViewModel.OpenCommand.Execute(null);
			
			PathTemplate = DialogViewModel.FileName;
			DataWord = new DataWordTemplate(PathTemplate);

			NamePagesList = new List<string>();
			foreach ( var name in DataWord.GetWordsList(PathTemplate) )
				NamePagesList.Add(name.Name);

			MyTemplates = new ObservableCollection<WordTemplate>(DataWord.GetWordsList(PathTemplate));
			OnPropertyChanged("MyTemplates");
		}
		private void OpenTemplateAndLoadToView()
		{
			try
			{
				//???
				SelectTemplate.GetOpenWord(SelectTemplate.PathToTemplate);
			}
			catch(Exception ex)
			{

			}
		}
	}
}
