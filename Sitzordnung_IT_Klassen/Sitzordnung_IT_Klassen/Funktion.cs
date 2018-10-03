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
        
        public void LeseDatei(string csvPfad)
        {
            String wert;
            string[] arraywert;

            if (File.Exists(csvPfad))
            {
                StreamReader streamReader = new StreamReader(csvPfad);
                wert = streamReader.ReadLine();
                arraywert = wert.Split(';');

                for(int i=0;i<= arraywert.Length -1;i++)
                {
                     
                }
            }
            else
            {
                MessageBox.Show("Der zum Laden angegebene Pfad wurde nicht gefunden:\n" + csvPfad, "Datei laden", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        public void LoeschenSchueler()
        {
            throw new System.NotImplementedException();
        }

        public void EinfuegenSchueler()
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
