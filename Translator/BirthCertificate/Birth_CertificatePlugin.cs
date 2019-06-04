using System.Windows.Controls;
using Translator.Views;

namespace Translator.BirthCertificate
{
    class Birth_CertificatePlugin : ModuleBase
    {
        protected override UserControl CreateViewAndViewModel()
        {
            return new Birth_Certificate() { DataContext = new Birth_Certificate() };
        }

        public override string Name
        {
            get { return "Сертификат о рождении"; }
        }
    }
}
