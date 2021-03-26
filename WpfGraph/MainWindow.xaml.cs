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
using System.Windows.Shapes;
using Microsoft.Win32;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace WpfGraph
{
    /// <summary>
    /// Логика взаимодействия для Graph.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static int Separator(string[] message, int numberRow, char element, int numberElement)
        {

            int i = 0;
            int j = 0;
            for (i = 0; i < message[numberRow].Length; i++)
            {
                if (message[numberRow][i] == element)
                    j++;
                if (j == numberElement)
                    break;
            }

            return i;

        }
        public MainWindow()
        {
            //MainViewModel model = new MainViewModel();
            //Person person = new Person();

            InitializeComponent();
        }

        private void BtnPathClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            PersonBuilder p = new PersonBuilder();
            if (openFileDialog.ShowDialog() == true)
            {
                p.pathName = openFileDialog.FileName;
                ListViewPeople.ItemsSource = p.ReadCSV(p.pathName);
                string[] data = File.ReadAllLines(System.IO.Path.ChangeExtension(p.pathName, ".csv"));
               // foreach( var i in data)
                //    TxtCheck.Text += i;

                double[] vectorX = new double[data.Length];
                double[] vectorY = new double[data.Length];
                // int numberElementStart = 0;
                //  int numberElementEnd = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    vectorX[i] = Convert.ToDouble(data[i].Substring(0, Separator(data, i, ';', 1)));
                    int numberElementStart = Separator(data, i, ';', 1);
                    int numberElementEnd = Separator(data, i, ';', 2) - numberElementStart;
                    vectorY[i] = Convert.ToDouble(data[i].Substring(numberElementStart + 1, numberElementEnd - 1));
                }
                foreach (int i in vectorX)
                    p.AddedX(Convert.ToDouble(i));

                foreach (int i in vectorY)
                    p.AddedY(Convert.ToDouble(i));
            }




        }

        private void BtnGraphClick(object sender, RoutedEventArgs e)
        {
            try
            {

              //  Person p = new Person();
             
                    Graph graphWindow = new Graph();
                    graphWindow.Show();
                    Hide();
               
                
            }
           catch { MessageBox.Show("Укажите путь к файлу .csv"); }
        }
    }





}