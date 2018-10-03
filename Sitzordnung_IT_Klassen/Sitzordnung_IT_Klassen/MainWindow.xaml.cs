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
            int maxPlaetze = 31;
            int platz;

            besetztePlaetze.Clear();

            foreach (Schueler schueler in Raum.schuelerListe)
            {
                platz = RandomNumber(1, maxPlaetze);

                while (besetztePlaetze.Contains(platz))
                {
                    platz = RandomNumber(1, maxPlaetze);
                }

                besetztePlaetze.Add(platz);
                schueler.SetSitzplatz(platz);

                switch (platz)
                {
                    case 1:
                        Platz1.Text = schueler.GetName();
                        break;
                    case 2:
                        Platz2.Text = schueler.GetName();
                        break;
                    case 3:
                        Platz3.Text = schueler.GetName();
                        break;
                    case 4:
                        Platz4.Text = schueler.GetName();
                        break;
                    case 5:
                        Platz5.Text = schueler.GetName();
                        break;
                    case 6:
                        Platz6.Text = schueler.GetName();
                        break;
                    case 7:
                        Platz7.Text = schueler.GetName();
                        break;
                    case 8:
                        Platz8.Text = schueler.GetName();
                        break;
                    case 9:
                        Platz9.Text = schueler.GetName();
                        break;
                    case 10:
                        Platz10.Text = schueler.GetName();
                        break;
                    case 11:
                        Platz11.Text = schueler.GetName();
                        break;
                    case 12:
                        Platz12.Text = schueler.GetName();
                        break;
                    case 13:
                        Platz13.Text = schueler.GetName();
                        break;
                    case 14:
                        Platz14.Text = schueler.GetName();
                        break;
                    case 15:
                        Platz15.Text = schueler.GetName();
                        break;
                    case 16:
                        Platz16.Text = schueler.GetName();
                        break;
                    case 17:
                        Platz17.Text = schueler.GetName();
                        break;
                    case 18:
                        Platz18.Text = schueler.GetName();
                        break;
                    case 19:
                        Platz19.Text = schueler.GetName();
                        break;
                    case 20:
                        Platz20.Text = schueler.GetName();
                        break;
                    case 21:
                        Platz21.Text = schueler.GetName();
                        break;
                    case 22:
                        Platz22.Text = schueler.GetName();
                        break;
                    case 23:
                        Platz23.Text = schueler.GetName();
                        break;
                    case 24:
                        Platz24.Text = schueler.GetName();
                        break;
                    case 25:
                        Platz25.Text = schueler.GetName();
                        break;
                    case 26:
                        Platz26.Text = schueler.GetName();
                        break;
                    case 27:
                        Platz27.Text = schueler.GetName();
                        break;
                    case 28:
                        Platz28.Text = schueler.GetName();
                        break;
                    case 29:
                        Platz29.Text = schueler.GetName();
                        break;
                    case 30:
                        Platz30.Text = schueler.GetName();
                        break;
                    default:
                        Platz31.Text = schueler.GetName();
                        break;
                }
            }

        }

        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}