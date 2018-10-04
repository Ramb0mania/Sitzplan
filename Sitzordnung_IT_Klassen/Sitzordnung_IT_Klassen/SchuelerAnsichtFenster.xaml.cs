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
        String txtPath;
        SaveFileDialog sfg;

        public SchuelerAnsichtFenster()
        {
            if (Raum.schuelerListe.Count() != 0)
            {
                try
                {
                    list1.Items.Add("");
                    list1.ItemsSource = Raum.schuelerListe;
                }
                catch (NullReferenceException)
                {

                }
            }

            InitializeComponent();
        }

        private List<Schueler> LadeSchuelerAusCSV(string file)
        {
            List<Schueler> schuelerListe = new List<Schueler>();
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

                    String line = reader.ReadLine();
                    String[] values = line.Split(';');

                    name = values[0];
                    vorname = values[1];
                    beruf = values[2];
                    betrieb = values[3];
                    geschlecht = values[4];

                    Console.WriteLine(name + " " + vorname + " " + beruf + " " + betrieb + " " + geschlecht);
                    Schueler schueler = new Schueler(name, vorname, beruf, betrieb, geschlecht);
                    Raum.schuelerListe.Add(schueler);
                }
                Console.WriteLine("---------------------");
                list1.ItemsSource = Raum.schuelerListe;
                return Raum.schuelerListe;
            }
        }

        private void Click_btn_oeffne(object sender, RoutedEventArgs e)
            {
                dlg = new OpenFileDialog();

                if (dlg.ShowDialog() == true)
                {
                    new FileInfo(dlg.FileName);
                    using (Stream s = dlg.OpenFile())
                    {
                        TextReader reader   = new StreamReader(s);
                        string st           = reader.ReadToEnd();
                        txtPath             = dlg.FileName;
                        Console.WriteLine(txtPath);
                    }
                }
            LadeSchuelerAusCSV(txtPath);
            }

        private void Click_btn_speicher(object sender, RoutedEventArgs e)
        {
            sfg = new SaveFileDialog();

            if (sfg.ShowDialog() == true)
            {
                    foreach (Schueler schueler in Raum.schuelerListe)
                    {
                        string datensatz = schueler.Name + ";" + schueler.Vorname + ";" + schueler.Beruf + ";" + schueler.Betrieb + ";" + schueler.Geschlecht;
                        File.AppendAllText(sfg.FileName, datensatz);
                    }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void list1_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {

        }
    }
}
