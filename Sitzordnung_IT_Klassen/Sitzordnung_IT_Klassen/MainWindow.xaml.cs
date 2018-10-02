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

namespace Projekt_Sitzordnung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GenerateRadioButtons(Convert.ToInt32(Text_Anzahl.Text));
        }

        private void GenerateRadioButtons(int Anzahl)
        {
            for (int x = 0; x < Anzahl; x++)
            {

                for (int i = 0; i < 6; i++)
                {
                    RadioButton rb = new RadioButton() { Content = "Radio button " + i, IsChecked = i == 0 };
                    rb.Checked += (sender, args) =>
                    {
                        Console.WriteLine("Pressed " + (sender as RadioButton).Tag);
                    };
                    rb.Unchecked += (sender, args) => { /* Do stuff */ };
                    rb.Tag = i;
                }
            }
        }
    }
}