
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGraph
{
    class Person
    {
        public double VectorX { get; set; }
        public double VectorY { get; set; }
        public string pathName;
        

      //  public string FirstName { get; set; }
       // public string LastName { get; set; }
        //public int ID { get; set; }
        // public string Email { get; set; }
        public Person() { }


       
        public Person(double vectorX, double vectorY)
        {
            VectorX = vectorX;
            VectorY = vectorY;
        }

        
       
    }
}

