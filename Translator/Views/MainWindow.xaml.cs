using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Text.RegularExpressions;
using System.Net.Http;
using Newtonsoft.Json;
using Translator.ViewModels;

namespace Translator
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_MouseEnter( object sender , MouseEventArgs e )
		{

		}

		private void Btn_Exit_Click( object sender , RoutedEventArgs e )
		{
			this.Close();
		}

		private void Btn_About_Click( object sender , RoutedEventArgs e )
		{

		}

		private void Btn_Translate_Click( object sender , RoutedEventArgs e )
		{

           
        }

		private void Btn_Save_Click( object sender , RoutedEventArgs e )
		{

		}

		private void Btn_ExportFile_Click( object sender , RoutedEventArgs e )
		{

		}
	}
}
