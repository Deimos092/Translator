using System;
using System.Linq;
using System.Windows;
using Translator.Utils;
using Translator.ViewModels;

namespace Translator
{
	/// <summary>
	/// Логика взаимодействия для App.xaml
	/// </summary>
	public partial class App : Application
	{
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainWindow = new MainWindow();

            var modules = ReflectionHelper.CreateAllInstancesOf<ITemplate>();

            var vm = new MainViewModel(modules);
            mainWindow.DataContext = vm;
            mainWindow.Closing += (s, args) => vm.SelectTemplate.Deactivate();
            mainWindow.Show();
        }
    }
}
