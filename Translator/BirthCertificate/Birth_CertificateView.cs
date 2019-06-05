using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.Utils;
using System.Windows.Controls;
using Translator.ViewModels;

namespace Translator.BirthCertificate
{
    class Birth_CertificateView : BaseViewModel
    {
        string childName, childPlaceBirth, name1P, nationality1P, citizen1P,
                name2P, nationality2P, citizen2P, actNumber, actDate, placeRegistration,
                placeRegistration2, registrator;

        MicrosoftTransater MicrosoftTransater;
        public Birth_CertificateView(RelayCommand relayCommand)
        {
            MicrosoftTransater = new MicrosoftTransater();
            relayCommand = new RelayCommand(GetTranslate);
        }

        List<Items> Fields { get; set; }

        string ChildName
        {
            get { return childName; }
            set
            {
                childName = value;
                OnPropertyChanged("ChildName");
            }
        }
        string ChildPlaceBirth
        {
            get { return childPlaceBirth; }
            set
            {
                childPlaceBirth = value;
                OnPropertyChanged("ChildPlaceBirth");
            }
        }
        string Name1P
        {
            get { return name1P; }
            set
            {
                name1P = value;
                OnPropertyChanged("Name1P");
            }
        }
        string Nationality1P
        {
            get { return nationality1P; }
            set
            {
                nationality1P = value;
                OnPropertyChanged("Nationality1P");
            }
        }
        string Citizen1P
        {
            get { return citizen1P; }
            set
            {
                citizen1P = value;
                OnPropertyChanged("Citizen1P");
            }
        }
        string Name2P
        {
            get { return name2P; }
            set
            {
                name2P = value;
                OnPropertyChanged("Name2P");
            }
        }
        string Nationality2P
        {
            get { return nationality2P; }
            set
            {
                nationality2P = value;
                OnPropertyChanged("Nationality2P");
            }
        }
        string Citizen2P
        {
            get { return citizen2P; }
            set
            {
                citizen2P = value;
                OnPropertyChanged("Citizen2P");
            }
        }
        string ActNumber
        {
            get { return actNumber; }
            set
            {
                actNumber = value;
                OnPropertyChanged("ActNumber");
            }
        }
        string ActDate
        {
            get { return actDate; }
            set
            {
                actDate = value;
                OnPropertyChanged("ActDate");
            }
        }
     
        string PlaceRegistration
        {
            get { return placeRegistration; }
            set
            {
                placeRegistration = value;
                OnPropertyChanged("PlaceRegistration");
            }
        }
        string PlaceRegistration2
        {
            get { return placeRegistration2; }
            set
            {
                placeRegistration2 = value;
                OnPropertyChanged("PlaceRegistration2");
            }
        }
        string Registrator
        {
            get { return registrator; }
            set
            {
                registrator = value;
                OnPropertyChanged("Registrator");
            }
        }
        void GetTranslate()
        {
            //ChildName ChildBirth ChildPlaceBirth
            //Name1P Nationality1P Citizen1P
            //Name2P Nationality2P Citizen2P
            //ActNumber ActDate DateIssue
            //PlaceRegistration PlaceRegistration2 Registrator
            string[] fields = new string[] { ChildName, ChildPlaceBirth,
            Name1P,Nationality1P,Citizen1P,Name2P, Nationality2P, Citizen2P,ActNumber,ActDate,
            PlaceRegistration,PlaceRegistration2,Registrator};
            List<Items> AlreadyTranslateFields = MicrosoftTransater.Translate(fields);

            for (int i = 0; i < AlreadyTranslateFields.Count; i++)
            {
                fields[i] = AlreadyTranslateFields[i].translations[0].text;
            }
        }
    }
}
