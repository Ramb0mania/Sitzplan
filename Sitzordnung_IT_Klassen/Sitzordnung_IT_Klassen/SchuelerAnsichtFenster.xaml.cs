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
        void ErstmalAllesSauberMachen()
        {
            datagrid1.Columns.Clear();
        }

        void ReadCSV(String file)
        {
            ErstmalAllesSauberMachen();
            String rowValue;
            string[] cellValue;

            if (System.IO.File.Exists (file))
            {
                StreamReader streamReader = new StreamReader(file);
                rowValue = streamReader.ReadLine();
                cellValue = rowValue.Split(';');

                for (int i = 0;i<= cellValue.Count()-1 ;i++)
                {
                    DataGridColumn c = new DataGridTextColumn();

                    //c.Name = cellValue[i];
                    c.Header = cellValue[i];
                    datagrid1.Columns.Add(c);
                }

                while (streamReader.Peek() != -1)
                {
                    rowValue = streamReader.ReadLine();
                    cellValue = rowValue.Split(';');
                    
                }

                streamReader.Close();
            }

            void Button_import_Click(object sender, RoutedEventArgs e)
            {
                TextBox txtPath;
                OpenFileDialog dlg;
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
        }
    }
}
