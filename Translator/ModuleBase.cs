using System;
using System.Linq;
using Translator.Utils;
using System.Windows.Controls;

namespace Translator
{
    abstract class TemplateBase : ITemplate
    {
        private UserControl view;

        protected abstract UserControl CreateViewAndViewModel();

        public abstract string Name { get; }

        public abstract RelayCommand RelayCommand { get; set; }

        public UserControl UserInterface
        {
            get
            {
                if (view == null)
                {
                    view = CreateViewAndViewModel();
                }
                return view;
            }
        }

        public void Deactivate()
        {
            if (view != null)
            {
                var d = view.DataContext as IDisposable;
                if (d != null) d.Dispose();
                view = null;
            }
        }
    }
}
