using OxyPlot;
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

        
     
    }



    public class MainViewModel
    {
        
        public MainViewModel()
        {
            //   MainViewModel model = new MainViewModel();
            //PersonBuilder person = new PersonBuilder();
            Content content = new Content();
            this.Title = "График";
            this.Points = new List<DataPoint> { new DataPoint(0, 0) };

            
               for (int i = 0; i < Content.VectorX.Length; i++)
               {
                   Points.Add(new DataPoint(Content.VectorX[i], Content.VectorY[i]));
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

        public string TextTest { get; set; }

        //public List<DataPoint> Points2 = new List<DataPoint>();




    }

   
    

}


