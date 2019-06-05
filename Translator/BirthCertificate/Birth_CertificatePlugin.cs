using System.Windows.Controls;
using Translator.Utils;
using Translator.Views;

namespace Translator.BirthCertificate
{
    class Birth_CertificatePlugin : TemplateBase
    {
        protected override UserControl CreateViewAndViewModel()
        {
            return new Birth_Certificate() { DataContext = new Birth_CertificateView(RelayCommand) };
        }

        public override RelayCommand RelayCommand
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }
        public override string Name
        {
            get { return "Справка о рождении"; }
        }
    }
}
