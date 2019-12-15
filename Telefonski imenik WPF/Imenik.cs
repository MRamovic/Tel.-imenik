using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonski_imenik_WPF
{
    class Imenik : INotifyPropertyChanged
    {
        private string ime;
        private string prezime;
        private string adresa;
        private string broj;
        public string Ime
        {
            get => ime;

            set
            {
                ime = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs("Ime"));
            }
        }

        public string Prezime
        {
            get => prezime;

            set
            {
                prezime = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs("Prezime"));
            }
        }
        public string Adresa
        {
            get => adresa;

            set
            {
                adresa = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs("Adresa"));
            }
        }
        public string Broj
        {
            get => broj;

            set
            {
                broj = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs("Broj"));
            }
        }

        public Imenik(string i, string p, string a, string b)
        {
            Ime = i;
            Prezime = p;
            Adresa = a;
            Broj = b;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }

}
