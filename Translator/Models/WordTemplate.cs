using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace Translator.Models
{
    class WordTemplate
    {
		Object _missingObj = Missing.Value;
		Object _trueObj = true;
		Object _falseObj = false;
		public WordTemplate(string name, string path)
		{
			if ( !string.IsNullOrEmpty(path) && !string.IsNullOrEmpty(name) )
			{
				PathToTemplate = path;
				Name = name;
			}
		}
		public Word.Application _Application { get; private set; }
		public Word.Document _Document { get; private set; }
		public Word.Bookmarks _Bookmarks { get; private set; }
		public string PathToTemplate { get; set; }
		public string Name { get; set; }
		internal bool GetOpenWord( Object _PathToTemplate )
		{
			try
			{
				_Application = new Word.Application();
				_Document = _Application.Documents.Add(ref _PathToTemplate , ref _missingObj , ref _missingObj , ref _missingObj);
			}
			catch ( Exception )
			{
				_Document.Close(ref _falseObj , ref _missingObj , ref _missingObj);
				_Application.Quit(ref _missingObj , ref _missingObj , ref _missingObj);
				_Document = null;
				_Application = null;
				return false;
			}
			_Application.Visible = false;
			return true;
		}
		public bool GetSaveWord(String _PathToTemplate )
		{
			try
			{
				_Document.SaveAsQuickStyleSet(_PathToTemplate);
				GetCloseDocument();
			}
			catch(Exception)
			{
				_Document.Close(ref _falseObj , ref _missingObj , ref _missingObj);
				_Application.Quit(ref _missingObj , ref _missingObj , ref _missingObj);
				_Document = null;
				_Application = null;
				return false;
			}
			return true;
		}

		public void GetCloseDocument()
		{
			_Document.Close(ref _falseObj , ref _missingObj , ref _missingObj);
			_Application.Quit(ref _missingObj , ref _missingObj , ref _missingObj);
			_Document = null;
			_Application = null;
		}

		//public void GetInserBookmarks() //вставка в закладки текст
		//{
		//	if ( _Document.Bookmarks.Exists("Name1") )
		//	{
		//		Word.Range range = _Document.Bookmarks["Name1"].Range;
		//		range.Text = "MARTINOV KIRILL";
		//		_Document.Bookmarks.Add("Name1" , range);
		//	}
		//	GetSaveWord(PathToTemplate);
		//}
	}
}
