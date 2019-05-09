using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Win32;

namespace Translator.Utils
{
	class FileService
	{
		public string OpenFile( string defaultExtension , string filter )
		{
			OpenFileDialog fd = new OpenFileDialog();
			fd.DefaultExt = defaultExtension;
			fd.Filter = filter;
			bool? result = fd.ShowDialog();

			return result.Value ? Path.GetDirectoryName(fd.FileName) : null;
		}

		//public string SaveFile( string defaultExtension , string filter )
		//{
		//	SaveFileDialog fd = new SaveFileDialog();
		//	fd.DefaultExt = defaultExtension;
		//	fd.Filter = filter;

		//	bool? result = fd.ShowDialog();

		//	return result.Value ? fd.FileName : null;
		//}
	}
}
