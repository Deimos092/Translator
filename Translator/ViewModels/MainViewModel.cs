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
using System.Windows.Controls;

namespace Translator.ViewModels
{
	class MainViewModel : BaseViewModel
	{
		private string _selectedPath;
        private ITemplate selectedTemplate;

        public MainViewModel(IEnumerable<ITemplate> modules)
		{
			this.OpenFolderTemplate = new RelayCommand(this.OpenFolderAndLoadTemplate);

            this.Templates = modules.OrderBy(m => m.Name).ThenByDescending(m => m.Name).ToList();
            if (this.Templates.Count > 0)
            {
                this.SelectTemplate = this.Templates[0];
            }
        }
		public ObservableCollection<WordTemplate> MyTemplates { get; set; }

		private DataWordTemplate DataWord { get; set; }
        private RelayCommand TranslateCommand { get; set; }

        public List<ITemplate> Templates { get; private set; }
        public ITemplate SelectTemplate
        {
            get
            {
                return selectedTemplate;
            }
            set
            {
                if (value != selectedTemplate)
                {
                    if (selectedTemplate != null)
                    {
                        selectedTemplate.Deactivate();
                    }
                    selectedTemplate = value;
                    selectedTemplate.RelayCommand = TranslateCommand;
                    OnPropertyChanged("SelectTemplate");
                    OnPropertyChanged("UserInterface");
                }
            }
        }
        public UserControl UserInterface
        {
            get
            {
                if (SelectTemplate == null) return null;
                return SelectTemplate.UserInterface;
            }
        }
		public string PathTemplate
		{
			get { return _selectedPath; }
			set {
				_selectedPath = value;
				OnPropertyChanged("PathTemplate");
			}
		}
		public RelayCommand OpenFolderTemplate { get; set; }
		private void OpenFolderAndLoadTemplate()
		{
			FileDialogViewModel DialogViewModel = new FileDialogViewModel();
			DialogViewModel.Extension = "*.docx";
			DialogViewModel.Filter = "Word docx (.docx)|*.docx|Old Word doc(.doc)|*.doc|All Files(.*)|*.*";

			if(DialogViewModel.OpenCommand.CanExecute(null))
				DialogViewModel.OpenCommand.Execute(null);
			
			PathTemplate = DialogViewModel.FileName;
			DataWord = new DataWordTemplate(PathTemplate);

			MyTemplates = new ObservableCollection<WordTemplate>(DataWord.GetWordsList(PathTemplate));
			OnPropertyChanged("MyTemplates");
		}
       
	}
}
