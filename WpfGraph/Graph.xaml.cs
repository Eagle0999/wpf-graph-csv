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
using OxyPlot.Axes;
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
        }

        /*
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
        */

     
        private  void MenuClickSaveImage(object sender, RoutedEventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            Content p = new Content();
            if (saveFileDialog.ShowDialog() == true)
            {
                p.pathName = saveFileDialog.FileName;
            
                //Plot.Axes.Add(new OxyPlot.Wpf.LinearAxis { Position = AxisPosition.Bottom, Title = "x-title"  });
                // Plot.Axes.Add(new OxyPlot.Wpf.LinearAxis { Position = AxisPosition.Left, Title = "y-title" });
                // Plot.Title = p.pathName;
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
            //this.Title = "График";

            this.Title = ConfigureGraphWindow.NameGraph;
            AxisNameX = ConfigureGraphWindow.NameX;
            AxisNameY = ConfigureGraphWindow.NameY;
            //this.Points = new List<DataPoint> { new DataPoint(Content.VectorX[0], Content.VectorY[0]) };
            Points = new List<DataPoint>();

           for (int i = 0; i < Content.VectorX.Length; i++)
                {
                   // Content.VectorX[0] = minX;
                   // Content.VectorY[0] = minY;
                    this.Points.Add(new DataPoint(Content.VectorX[i], Content.VectorY[i]));
                }

            //Content.VectorX = null;
          //  Content.VectorY = null;


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

        public string Title { get;  set; }
        public string AxisNameX { get; set; }
        public string AxisNameY { get; set; }

        public IList<DataPoint> Points { get;   private set; }



        public string NameX { get; set; }

        //public List<DataPoint> Points2 = new List<DataPoint>();




    }

   
    

}


