using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Translator.INN
{
    class INNPlugin : ModuleBase
    {
        protected override UserControl CreateViewAndViewModel()
        {
            return new INN() { DataContext = new INN() };
        }

        public override string Name
        {
            get { return "ИНН"; }
        }
    }
}
