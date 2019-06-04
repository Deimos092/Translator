using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using Translator.Views;

namespace Translator.Owner
{
    class OwnerPlugin : ModuleBase
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
