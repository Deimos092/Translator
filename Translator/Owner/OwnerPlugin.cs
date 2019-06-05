using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using Translator.Views;
using Translator.Utils;

namespace Translator.Owner
{
    class OwnerPlugin : TemplateBase
    {
        protected override UserControl CreateViewAndViewModel()
        {
            return new Owner() { DataContext = new Owner() };
        }
      
        public override string Name
        {
            get { return "Собственность"; }
        }
    }
}
