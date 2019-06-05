using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Translator.Utils;

namespace Translator.INN
{
    class INNPlugin : TemplateBase
    {
        protected override UserControl CreateViewAndViewModel()
        {
            return new INN() { DataContext = new INN() };
        }

        public override RelayCommand RelayCommand
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public override string Name
        {
            get { return "Инн"; }
        }
    }
}
