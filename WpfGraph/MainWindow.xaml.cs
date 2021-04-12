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
using System.Threading;


namespace WpfGraph
{
    /// <summary>
    /// Логика взаимодействия для Graph.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public char delimeter;

      
        public MainWindow()
        {
            //MainViewModel model = new MainViewModel();
            //Person person = new Person();
            InitializeComponent();
          
        }

        private void BtnPathClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            Content p = new Content();
            if (openFileDialog.ShowDialog() == true)
            {
                p.pathName = openFileDialog.FileName;
                ListViewPeople.ItemsSource = p.ReadCSV(p.pathName, textHeaderX.Text, textHeaderY.Text, delimeter);

            }

        }


        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        private void test()
        {
            try
            {
                ConfigureGraphWindow configureGraphWindow = new ConfigureGraphWindow();
                configureGraphWindow.Show();
            }
            catch { MessageBox.Show("Укажите путь к файлу .csv"); }
        }
   
        private void BtnGraphClick(object sender, RoutedEventArgs e)
        {

            /*try
                {
                    Graph graphWindow = new Graph();
                    graphWindow.Show();

                }
                catch { MessageBox.Show("Укажите путь к файлу .csv"); }
             */
            try
               {
               ConfigureGraphWindow configureGraphWindow = new ConfigureGraphWindow();
               configureGraphWindow.Show();
               }
            catch { MessageBox.Show("Укажите путь к файлу .csv"); }

            

       }

       private void DelimeterListSelectionChanged(object sender, SelectionChangedEventArgs e)
       {

           // textDelimeter.Text = delimeterList.SelectedIndex.ToString();
           int separator = delimeterList.SelectedIndex;
           switch(separator)
           {
               case 0:
                   delimeter = Convert.ToChar(semicolon.Text);
                   break;
               case 1:
                   delimeter = Convert.ToChar(comma.Text);
                   break;
               default:
                   delimeter = Convert.ToChar(comma.Text);
                   break;
           }
       }


   }

 }


