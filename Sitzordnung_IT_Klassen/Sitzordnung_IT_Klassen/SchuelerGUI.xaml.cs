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

namespace Sitzordnung_IT_Klassen
{
    ///
    /// Interaktionslogik für SchuelerGUI.xaml
    ///
    public partial class SchuelerGUI : UserControl
    {
        private Brush _previousFill = null;

        public SchuelerGUI()
        {
            InitializeComponent();
        }

        public SchuelerGUI(SchuelerGUI s)
        {
            InitializeComponent();
            this.schuelerUI.Height = s.schuelerUI.Height;
            this.schuelerUI.Width = s.schuelerUI.Height;
            this.schuelerUI.Fill = s.schuelerUI.Fill;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            // Wenn die Linke Maustaste während einer Mausbewegung gedrückt wird
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                // Daten verpacken.
                DataObject data = new DataObject();
                data.SetData(DataFormats.StringFormat, schuelerUI.Fill.ToString());
                data.SetData("Double", schuelerUI.Height);
                data.SetData("Object", this);

                // Drag & drop Operation initiieren.
                DragDrop.DoDragDrop(this, data, DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        protected override void OnGiveFeedback(GiveFeedbackEventArgs e)
        {
            base.OnGiveFeedback(e);
            // Diese Werte werden im Event-Handler des Drop-Ziels gesetzt.
            if (e.Effects.HasFlag(DragDropEffects.Copy))
            {
                Mouse.SetCursor(Cursors.Cross);
            }
            else if (e.Effects.HasFlag(DragDropEffects.Move))
            {
                Mouse.SetCursor(Cursors.Pen);
            }
            else
            {
                Mouse.SetCursor(Cursors.No);
            }
            e.Handled = true;
        }

        protected override void OnDrop(DragEventArgs e)
        {
            base.OnDrop(e);

            // Wenn ein Benutzersteuerungselement String-Daten beinhaltet, ziehe diese raus.
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string dataString = (string)e.Data.GetData(DataFormats.StringFormat);

                // Sollte der String in einen Pinsel konvertiert werden können, 
                // konvertiere ihn und wende ihn auf dem Objekt an.
                BrushConverter converter = new BrushConverter();
                if (converter.IsValid(dataString))
                {
                    Brush newFill = (Brush)converter.ConvertFromString(dataString);
                    schuelerUI.Fill = newFill;

                    // Sag der Drag & Drop source Bescheid welchen Effekt
                    // die Drag & Drop operation hatte.
                    // (Kopiere wenn Strg gedrückt wird; ansonsten, bewege.)
                    if (e.KeyStates.HasFlag(DragDropKeyStates.ControlKey))
                    {
                        e.Effects = DragDropEffects.Move;
                    }
                    else
                    {
                        e.Effects = DragDropEffects.Copy;
                    }
                }
            }
            e.Handled = true;
        }

        protected override void OnDragOver(DragEventArgs e)
        {
            base.OnDragOver(e);
            e.Effects = DragDropEffects.None;

            // Wenn ein Benutzersteuerungselement String-Daten beinhaltet, ziehe diese raus.
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string dataString = (string)e.Data.GetData(DataFormats.StringFormat);

                // Sollte der String in einen Pinsel konvertiert werden können, erlaube kopieren oder bewegen.
                BrushConverter converter = new BrushConverter();
                if (converter.IsValid(dataString))
                {
                    // Set Effects to notify the drag source what effect
                    // the drag-and-drop operation will have. These values are 
                    // used by the drag source's GiveFeedback event handler.
                    // (Copy if CTRL is pressed; otherwise, move.)
                    if (e.KeyStates.HasFlag(DragDropKeyStates.ControlKey))
                    {
                        e.Effects = DragDropEffects.Move;
                    }
                    else
                    {
                        e.Effects = DragDropEffects.Copy;
                    }
                }
            }
            e.Handled = true;
        }

        protected override void OnDragEnter(DragEventArgs e)
        {
            base.OnDragEnter(e);
            // Speichere die aktuelle Füllfarbe des Pinsels sodass in DragLeave wieder drauf zugreifen kann.
            _previousFill = schuelerUI.Fill;

            // // Wenn ein Benutzersteuerungselement String-Daten beinhaltet, ziehe diese raus.
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string dataString = (string)e.Data.GetData(DataFormats.StringFormat);

                // Sollte der String in einen Pinsel konvertiert werden können, konvertiere.
                BrushConverter converter = new BrushConverter();
                if (converter.IsValid(dataString))
                {
                    Brush newFill = (Brush)converter.ConvertFromString(dataString.ToString());
                    schuelerUI.Fill = newFill;
                }
            }
        }

    }
}
