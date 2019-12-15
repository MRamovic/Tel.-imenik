using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections.ObjectModel;

namespace Telefonski_imenik_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Imenik> Lista = new ObservableCollection<Imenik>();
        public MainWindow()
        {
            InitializeComponent();
            dg.ItemsSource = Lista;

            if (File.Exists("tel.txt"))
            {
                foreach (string art in File.ReadLines("tel.txt"))
                {
                    string[] a = art.Split(';');
                    
                    Lista.Add(new Imenik(a[0], a[1], a[2], a[3]));
                }
            }
        }

        private void Click_Button_Dodaj(object sender, RoutedEventArgs e)
        {
            Editor NoviProzor = new Editor();
            NoviProzor.DataContext = Lista;
            NoviProzor.Visibility = Visibility.Visible;
        }

        private void Click_Button_Izmeni(object sender, RoutedEventArgs e)
        {
            Editor NoviProzor = new Editor();
            NoviProzor.DataContext = dg.SelectedItem;
            NoviProzor.Visibility = Visibility.Visible;
        }

        private void Click_Button_Izbrisi(object sender, RoutedEventArgs e)
        {
            Lista.Remove(dg.SelectedItem as Imenik);
        }

        private void Click_Button_Izlaz(object sender, RoutedEventArgs e)
        {
            if (File.Exists("tel.txt"))
            {
                File.Delete("tel.txt");
            }
            foreach (Imenik x in Lista)
            {
                File.AppendAllText("tel.txt", $"{x.Ime};{x.Prezime};{x.Adresa};{x.Broj }");
            }
            Close();
        }
    }
}
