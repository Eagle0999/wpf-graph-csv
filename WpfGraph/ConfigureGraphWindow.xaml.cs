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

namespace WpfGraph
{
    /// <summary>
    /// Логика взаимодействия для ConfigureGraphWindow.xaml
    /// </summary>
    public partial class ConfigureGraphWindow : Window
    {
        public static string NameX;
        public static string NameY;
        public static string NameGraph;
        public ConfigureGraphWindow()
        {
           
            InitializeComponent();
        }

        private void BtnGraphBuilderClick(object sender, RoutedEventArgs e)
        {
            try
             {
                NameX = TextBoxNameX.Text;
                NameY = TextBoxNameY.Text;
                NameGraph = HeaderNameGraph.Text;
                Graph graphWindow = new Graph();
                graphWindow.Show();
                Hide();
            }
            catch { MessageBox.Show("Укажите путь к файлу .csv"); }
        }
    }
}
