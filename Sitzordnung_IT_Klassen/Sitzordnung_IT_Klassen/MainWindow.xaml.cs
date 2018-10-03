using Microsoft.Win32;
using Sitzordnung_IT_Klassen;
using System;
using System.Collections.Generic;
using System.IO;
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
        private TextBox txtPath;
        private OpenFileDialog dlg;
        private Funktion func;
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

        private void Button_import_Click(object sender, RoutedEventArgs e)
        {
           dlg = new OpenFileDialog();
            txtPath = new TextBox();
           

            //Open the Pop-Up Window to select the file 
            if (dlg.ShowDialog() == true)
            {
                new FileInfo(dlg.FileName);
                using (Stream s = dlg.OpenFile())
                {
                    TextReader reader = new StreamReader(s);
                    string st = reader.ReadToEnd();
                    txtPath.Text = dlg.FileName;
                    Console.WriteLine(txtPath.Text);
                }

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {         
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(dlg.FileName);
            Console.WriteLine("Programmaufruf Anzeigen");
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
        }

        private void Button_add_Click(object sender, RoutedEventArgs e)
        {
            AddSchueler w2 = new AddSchueler();
            w2.InitializeComponent();
            w2.Show();

        }

        private void oeffneSchließFenster(object sender, RoutedEventArgs e)
        {
            SchließenFenster schließenFenster = new SchließenFenster();
            schließenFenster.Show();
        }
    }
}