using Microsoft.Win32;
using OxyPlot;
using OxyPlot.Wpf;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Graph : Window
    {

    
        public Graph()
        {
            
            InitializeComponent();
            MainViewModel model = new MainViewModel();

        }

        private void Menu_Click_SaveImage(object sender, RoutedEventArgs e)
        {
            //Content con = new Content();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            Content p = new Content();
            if (saveFileDialog.ShowDialog() == true)
            {
                p.pathName = saveFileDialog.FileName;
                Plot.SaveBitmap(p.pathName, 960, 540, OxyColor.FromRgb(255, 255, 255));

            }


            
        }
    }



    public class MainViewModel
    {
        
        public MainViewModel()
        {
            //   MainViewModel model = new MainViewModel();
            //PersonBuilder person = new PersonBuilder();
            Content content = new Content();
            this.Title = "График";
            this.NameX = "x";
            //this.Points = new List<DataPoint> { new DataPoint(Content.VectorX[0], Content.VectorY[0]) };
            this.Points = new List<DataPoint>();

            for (int i = 0; i < Content.VectorX.Length; i++)
               {
                this.Points.Add(new DataPoint(Content.VectorX[i], Content.VectorY[i]));
               }
               
        }

        /*
        public void BuilderViewModel()
            {
            Title = "Graph BuilderRRR";
            Points = new List<DataPoint>
                              {
                                  new DataPoint(0, 4),
                                  new DataPoint(10, 13),
                                  new DataPoint(20, 15),
                                  new DataPoint(30, 16),
                                  new DataPoint(40, 12),
                                  new DataPoint(50, 12)
                              }; 


        }
        */

        public string Title { get; private set; }

        public IList<DataPoint> Points { get;   private set; }

        public string NameX { get; set; }

        //public List<DataPoint> Points2 = new List<DataPoint>();




    }

   
    

}


