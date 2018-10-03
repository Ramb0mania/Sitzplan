using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Collections.Generic;
using Microsoft.Win32;


namespace Sitzordnung_IT_Klassen
{
    /// <summary>
    /// Interaktionslogik für SchuelerAnsichtFenster.xaml
    /// </summary>
    public partial class SchuelerAnsichtFenster : Window
    {
        OpenFileDialog dlg;
        TextBox txtPath;

        public SchuelerAnsichtFenster()
        {
            InitializeComponent();
        }

        private void ErstmalAllesSauberMachen()
        {
            datagrid1.Columns.Clear();
        }

        private void ReadCSV(String file)
        {
            string name;
            string vorname;
            string beruf;
            string betrieb;
            string geschlecht;

            using (var reader = new StreamReader(file))
            {

                while (!reader.EndOfStream)
                {
                    name        = "";
                    vorname     = "";
                    beruf       = "";
                    betrieb     = "";
                    geschlecht  = "";

                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    name        = values[0];
                    vorname     = values[1];
                    beruf       = values[2];
                    betrieb     = values[3];
                    geschlecht  = values[4];
                }
            }
        }
            /*void Button_Click(object sender, RoutedEventArgs e)
            {
                List<Schueler> schuelerListe = new List<Schueler> {
                new Schueler("test1", "test", "test", "test", "test"),
                new Schueler("test2", "test", "test", "test", "test"),
                new Schueler("test3", "test", "test", "test", "test"),
                new Schueler("test4", "test", "test", "test", "test"),
                new Schueler("test5", "test", "test", "test", "test"),
                new Schueler("test6", "test", "test", "test", "test"),
                new Schueler("test7", "test", "test", "test", "test"),
                new Schueler("test8", "test", "test", "test", "test"),
                new Schueler("test9", "test", "test", "test", "test"),
                new Schueler("test10", "test", "test", "test", "test"),
                new Schueler("test11", "test", "test", "test", "test"),
                new Schueler("test12", "test", "test", "test", "test"),
                new Schueler("test13", "test", "test", "test", "test"),
                new Schueler("test14", "test", "test", "test", "test"),
                new Schueler("test15", "test", "test", "test", "test"),
                new Schueler("test16", "test", "test", "test", "test"),
                new Schueler("test17", "test", "test", "test", "test"),
                new Schueler("test18", "test", "test", "test", "test"),
                new Schueler("test19", "test", "test", "test", "test"),
                new Schueler("test20", "test", "test", "test", "test"),
                new Schueler("test21", "test", "test", "test", "test")
            };
                datagrid1.ItemsSource = schuelerListe;
            }*/

            private void Click_btn_oeffne(object sender, RoutedEventArgs e)
            {
                dlg = new OpenFileDialog();
                txtPath = new TextBox();

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
