﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Translator
{
	public class Items
	{
		public Detectedlanguage detectedLanguage { get; set; }
		public Translation[] translations { get; set; }
	}

	public class Detectedlanguage
	{
		public string language { get; set; }
		public float score { get; set; }
	}

	public class Translation
	{
		public string text { get; set; }
		public string to { get; set; }
	}
}
