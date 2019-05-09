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

			DataContext = new MainViewModel();
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
			
			//string host = "https://api.cognitive.microsofttranslator.com";
			//string route = "/translate?api-version=3.0&to=en";
			//string subscriptionKey = "ddaa6e7133ab46b787092c45f059277f";

			//System.Object[] body = new System.Object[] {
			//	new { Name1.Text},new {tb1.Text } };
			//var requestBody = JsonConvert.SerializeObject(body);
			//using ( var client = new HttpClient() )
			//using ( var request = new HttpRequestMessage() )
			//{
			//	// Set the method to POST
			//	request.Method = HttpMethod.Post;

			//	// Construct the full URI
			//	request.RequestUri = new Uri(host + route);

			//	// Add the serialized JSON object to your request
			//	request.Content = new StringContent(requestBody , Encoding.UTF8 , "application/json");

			//	// Add the authorization header
			//	request.Headers.Add("Ocp-Apim-Subscription-Key" , subscriptionKey);

			//	// Send request, get response
			//	var response = client.SendAsync(request).Result;
			//	var jsonResponse = response.Content.ReadAsStringAsync().Result;

			//	// Print the response
			//	List<Items> translater = JsonConvert.DeserializeObject<List<Items>>(jsonResponse);
			//	tb1.Text = translater[0].translations[0].text;
			//}
		}

		private void Btn_Save_Click( object sender , RoutedEventArgs e )
		{

		}

		private void Btn_ExportFile_Click( object sender , RoutedEventArgs e )
		{

		}
	}
}
