using System;
using System.Collections.Generic;
using System.Windows;
using System.Xml.Serialization;
using System.IO;

namespace Sitzordnung_IT_Klassen
{
    class Funktion
    {
        //CSV-Datei Anbindung für Schüler.csv
        public List<Schueler> SchuelerListe = new List<Schueler>();

        public void leseDatei(string csvPfad)
        {
            if (Directory.Exists(csvPfad))
            {
                XmlSerializer serialiser;
                TextReader FileStream;
                if (File.Exists(csvPfad + "\\Schueler.xml"))
                {
                    serialiser = new XmlSerializer(typeof(List<Schueler>));
                    FileStream = new StreamReader(csvPfad + "\\Schueler.xml");
                    SchuelerListe = (List<Schueler>)serialiser.Deserialize(FileStream);
                    FileStream.Close();
                }
                else
                {
                    MessageBox.Show("Die Datei \"Schueler.xml\" wurde in dem Ortner nicht gefunden:\n" + csvPfad, "Datei laden", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Der zum Laden angegebene Ordner wurde nicht gefunden:\n" + csvPfad, "Datei laden", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void verteileSchueler()
        {
            throw new System.NotImplementedException();
        }

        public void loeschenSchueler()
        {
            throw new System.NotImplementedException();
        }

        public void einfuegenSchueler()
        {
            throw new System.NotImplementedException();
        }

        private void Button_End()
        {
            Environment.Exit(0);
            //this.Close();
        }
    }
}
