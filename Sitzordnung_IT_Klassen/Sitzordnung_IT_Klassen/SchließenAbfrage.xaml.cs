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

namespace Sitzordnung_IT_Klassen
{
    /// <summary>
    /// Interaktionslogik für SchließenAbfrage.xaml
    /// </summary>
    public partial class SchließenAbfrage : Window
    {
        private void schließeFenster(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void schließeAnwendung(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
