using System;
using System.Linq;
using System.Windows.Controls;

namespace Translator.Utils
{
    interface ITemplate
    {
        string Name { get; }
        UserControl UserInterface { get; }
        void Deactivate();
    }
}
