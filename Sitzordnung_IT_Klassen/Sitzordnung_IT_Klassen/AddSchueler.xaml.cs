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
using System.Windows.Shapes;
using Sitzordnung_IT_Klassen;

namespace Sitzordnung_IT_Klassen
{
    /// <summary>
    /// Interaktionslogik für Window2.xaml
    /// </summary>
    public partial class AddSchueler : Window
    {
        public AddSchueler()
        {
            InitializeComponent();
        }
        private void Button_add_Click(object sender, RoutedEventArgs e)
        {
            string geschlecht;
            string name = Box_Name.Text;
            string vorname = Box_Vorname.Text;
            string beruf = cBox_Beruf.Text;
            string betrieb = Box_Betrieb.Text;
            if (Men.IsChecked == true)
            {
                geschlecht = "maennlich";
            } else
            {
                geschlecht = "weiblich";
            }
            Raum.AddSchueler(new Schueler(name, vorname, beruf, betrieb, geschlecht));
            this.Close();
        }
    }
}