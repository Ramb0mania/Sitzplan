﻿using Microsoft.Win32;
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

namespace Sitzordnung_IT_Klassen
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBox txtPath;
        private OpenFileDialog dlg;

        public MainWindow()
        {
            InitializeComponent();
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

        private void Panel_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("Object"))
            {
                // Diese Effektwerte werden im GiveFeedback Event-handler der Drag source
                // genutzt um den richtigen cursor darzustellen.
                if (e.KeyStates == DragDropKeyStates.ControlKey)
                {
                    e.Effects = DragDropEffects.Move;
                }
                else
                {
                    e.Effects = DragDropEffects.Copy;
                }
            }
        }

        private void Panel_Drop(object sender, DragEventArgs e)
        {
            // If an element in the panel has already handled the drop,
            // the panel should not also handle it.
            if (e.Handled == false)
            {
                Panel _panel = (Panel)sender;
                UIElement _element = (UIElement)e.Data.GetData("Object");

                if (_panel != null && _element != null)
                {
                    // Get the panel that the element currently belongs to,
                    // then remove it from that panel and add it the Children of
                    // the panel that its been dropped on.
                    Panel _parent = (Panel)VisualTreeHelper.GetParent(_element);

                    if (_parent != null)
                    {
                        if (e.KeyStates == DragDropKeyStates.ControlKey &&
                            e.AllowedEffects.HasFlag(DragDropEffects.Move))
                        {
                            SchuelerGUI _schuelerGUI = new SchuelerGUI((SchuelerGUI)_element);
                            _panel.Children.Add(_schuelerGUI);
                            // set the value to return to the DoDragDrop call
                            e.Effects = DragDropEffects.Move;
                        }
                        else if (e.AllowedEffects.HasFlag(DragDropEffects.Copy))
                        {
                            _parent.Children.Remove(_element);
                            _panel.Children.Add(_element);
                            // set the value to return to the DoDragDrop call
                            e.Effects = DragDropEffects.Copy;
                        }
                    }
                }
            }
        }

        private void Button_content_Click(object sender, RoutedEventArgs e)
        {

        }

            private void OeffneSchuelerListeFenster(object sender, RoutedEventArgs e)
        {
            SchließenFenster schließenFenster = new SchließenFenster();
            schließenFenster.Show();
        }

        private void Button_edit_Click(object sender, RoutedEventArgs e)
        {
            SchuelerAnsichtFenster neueAnsicht = new SchuelerAnsichtFenster();
            neueAnsicht.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Verteile_Schueler(object sender, RoutedEventArgs e)
        {
            List<int> besetztePlaetze = new List<int>();
            int maxPlaetze = 30;
            int platz;

            besetztePlaetze.Clear();

            foreach (Schueler schuelerListe in Raum.schuelerListe)
            {
                platz = RandomNumber(1, maxPlaetze);

                while (besetztePlaetze.Contains(platz))
                {
                    platz = RandomNumber(1, maxPlaetze);
                }

                besetztePlaetze.Add(platz);
                
            }
            */


        }

        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}