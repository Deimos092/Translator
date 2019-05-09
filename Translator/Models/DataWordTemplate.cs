using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace Translator.Models
{
	class DataWordTemplate
	{
		Dictionary<string , WordTemplate> WordLisDictionary;
		public DataWordTemplate(string path)
		{
			WordLisDictionary = new Dictionary<string , WordTemplate>();
			if ( !string.IsNullOrEmpty(path) )
				foreach ( var item in Directory.GetFiles(path) )
				{
					WordLisDictionary.Add(
						Path.GetFileNameWithoutExtension(item) ,
						new WordTemplate(Path.GetFileNameWithoutExtension(item) , item));
				}
		}
		public List<WordTemplate> GetWordsList( string path )
		{
			return WordLisDictionary.Values.ToList();
		}
		public void OpenWordTemplate(string Name,string Path)
		{
			WordLisDictionary[Name].GetOpenWord(Path);
		}
	}
}
