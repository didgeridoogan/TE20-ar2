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
using System.Text.RegularExpressions;
using System.IO;

namespace Kontaktlistor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Intern lagring
        //static string[] lista = new string[100];
        static List<string> lista = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            //Kolla att textfilen finns
            if (File.Exists("kontaktlist.txt"))
            {
                //Läsa in kontaktlistan
                lista = File.ReadAllLines("kontaktlist.txt").ToList();
            
                //Skriv ut alla kontakter
                foreach (string kontakt in lista)
                {
                    rutaLista.Text += kontakt + "\n";
                } 
                
                rutaStatus.Text = lista.Count + "kontakter";
            }
            else
            {
                rutaStatus.Text = "0 kontakter";
            }

        }

        //Hantera klick på knappen
        private void KlickLäggTill(object sender, RoutedEventArgs e)
        {
            //Läs av namn & mobil
            string namn  = rutaNamn.Text;
            string mobil  = rutaMobil.Text;

            //Kolla att inte tomma
            if (namn == "" || mobil == "")
            {
                rutaStatus.Text = "Namn eller mobil saknas, vg försök igen!";
            }
            else
            {
                //Kolla mobilen följer rätt format (07xxxxxxxxx)
                Regex regexMobil = new Regex("^07[0-9]{8}");
                if (!regexMobil.IsMatch(mobil))
                {
                    rutaStatus.Text = "Mobil är fel format, vg försök igen!";
                }
                else
                {
                    rutaLista.Text += namn + "\t" + mobil + "\n";

                    //Spara i lista i minnet
                    lista.Add(namn + "\t" + mobil);

                    //Spara ned i en textfil
                    File.WriteAllLines("kontaktlist.txt", lista);

                }
            }
        }
    }
}
