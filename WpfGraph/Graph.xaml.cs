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
            MainViewModel model = new MainViewModel();
           // model.BuilderViewModel();
            InitializeComponent();
            
        }
    }



    public class MainViewModel
    {
        
        public MainViewModel()
        {
            PersonBuilder persons = new PersonBuilder();
            this.Title = "Graph Builderrr";
            this.Points = new List<DataPoint>
                               {
                                    
                                   new DataPoint(0, 0),
                                  // new DataPoint(33, 66)
                                   
                               };
            
               for (int i = 0; i < 10; i++)
               {
                   Points.Add(new DataPoint(i, i+60));
               }


            foreach (var i in persons.Persons)
                TextTest += i.VectorX;
            /*foreach (var i in persons.Persons)
            {
                
                Points.Add(new DataPoint(i.VectorX, i.VectorY));
            }*/


            //Points.Add((DataPoint)persons.Persons);
            //  Points.Add(new DataPoint(10,13));
            /*for (int i = 2; i < 10; i++)
            {
                Points = new List<DataPoint>
                              {
                                  new DataPoint(i, i+5),
            
                              };
            }*/

            /*foreach (var i in persons.Persons)
                this.Points = new List<DataPoint> {
                                  new DataPoint(0, 4),
                                  new DataPoint(10, 13),
                                  new DataPoint(20, 15),
                                  new DataPoint(30, 16),
                                  new DataPoint(40, 12),
                                  new DataPoint(50, 12)
                };
            */
        }


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

           /*
            double[] vectorX = new double[graph.persons.Count];
            double[] vectorY = new double[graph.persons.Count];
            int ch = 0;
            foreach (var i in graph.persons)
            {
                vectorX[ch] = i.VectorX;
                vectorY[ch] = i.VectorY;
                ch += 1;
            }
            */
               
                 


        }

        public string Title { get; private set; }

        public IList<DataPoint> Points { get;   private set; }

        public string TextTest { get; set; }

        //public List<DataPoint> Points2 = new List<DataPoint>();




    }
}


