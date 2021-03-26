using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGraph
{
    class PersonBuilder : Person
    {
        public List<Person> Persons = new List<Person>();

        public void AddedX(double vectorX)
        {
            Person person = new Person();
            person.VectorX = vectorX;
            Persons.Add(new Person() { VectorX = vectorX });
        }

        public void AddedY(double vectorY)
        {
            Person person = new Person();
            person.VectorY = vectorY;
            Persons.Add(new Person() { VectorY = vectorY });
        }
    }
}
