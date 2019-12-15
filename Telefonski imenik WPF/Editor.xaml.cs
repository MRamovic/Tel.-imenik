using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Telefonski_imenik_WPF
{
    /// <summary>
    /// Interaction logic for Editor.xaml
    /// </summary>
    public partial class Editor : Window
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void Click_Button_OK(object sender, RoutedEventArgs e)
        {
            if (DataContext is ObservableCollection<Imenik> kolekcija)
            {
                if (string.IsNullOrEmpty(txt_Ime .Text)&& 
                    string.IsNullOrEmpty(txt_Prezime.Text) && 
                    string.IsNullOrEmpty(txt_Adresa.Text) && 
                    string.IsNullOrEmpty(txt_Broj.Text) )
                {
                    MessageBox.Show("Greska u unosu!");
                }
                
                else
                {
                    kolekcija.Add(new Imenik(txt_Ime.Text, txt_Prezime.Text, txt_Adresa.Text, txt_Broj.Text));
                }
                
            }
            else
            {
                BindingOperations.GetBindingExpression( txt_Ime, TextBox.TextProperty).UpdateSource();
                BindingOperations.GetBindingExpression(txt_Prezime, TextBox.TextProperty).UpdateSource();
                BindingOperations.GetBindingExpression(txt_Adresa, TextBox.TextProperty).UpdateSource();
                BindingOperations.GetBindingExpression(txt_Broj, TextBox.TextProperty).UpdateSource();
                this.Close();
            }
            this.Close();
        }

        private void Click_Button_Izlaz(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    
}
