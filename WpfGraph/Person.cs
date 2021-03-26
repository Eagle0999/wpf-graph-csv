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

        /*
         public Person(string firstName, string lastName, int id, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            Email = email;
        }
        */

       
        public Person(double vectorX, double vectorY)
        {
            VectorX = vectorX;
            VectorY = vectorY;
        }

        public IEnumerable<Person> ReadCSV(string fileName)
        {
            // We change file extension here to make sure it's a .csv file.
            // TODO: Error checking.
            string[] lines = File.ReadAllLines(System.IO.Path.ChangeExtension(fileName, ".csv"));

            // lines.Select allows me to project each line as a Person. 
            // This will give me an IEnumerable<Person> back.
            return lines.Select(line =>
            {
                string[] data = line.Split(';');
                // We return a person with the data in order.
                // return new Person(data[0], data[1], Convert.ToInt32(data[2]), data[3]);
                

                return new Person(Convert.ToDouble(data[0]), Convert.ToDouble(data[1]));
            });
        }
       
    }
}
