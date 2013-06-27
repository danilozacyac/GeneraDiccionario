using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;

namespace GeneraDiccionario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSeparar_Click(object sender, RoutedEventArgs e)
        {
            List<string> listaPalabras = Utils.StandarizaCadena(TxtTexto.Text).Split(' ').ToList();
            listaPalabras.Distinct();

            string temp = Path.GetTempFileName() + ".txt";

            TextWriter tw = new StreamWriter(temp, true);

            foreach (string line in listaPalabras)
            {
                if(String.IsNullOrWhiteSpace(line) || String.IsNullOrEmpty(line) || line.Length < 4){}
                else
                tw.WriteLine(line);
            }

            
            tw.Close();

            Process.Start(temp);
        }
    }
}
