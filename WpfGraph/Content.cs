using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfGraph
{
    class Content
    {
        public static double[] VectorX;
        public static double[] VectorY;
        public string pathName;
        public Content() { }
        /*public Content(double[] VectorX, double[] VectorY)
        {
            this.VectorX = VectorX;
            this.VectorY = VectorY;
        }*/

        private int Separator(string[] message, int numberRow, char element, int numberElement)
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
        public void ReadFile()
        {
            string[] data = File.ReadAllLines(System.IO.Path.ChangeExtension(pathName, ".csv"));
            // foreach( var i in data)
            //    TxtCheck.Text += i;
            char[] separatorExcel = new char[2];
            separatorExcel[0] = ';';
            separatorExcel[1] = ',';
            double[] vectorX = new double[data.Length];
            double[] vectorY = new double[data.Length];
            bool choice = true;
            // int numberElementStart = 0;
            //  int numberElementEnd = 0;
            for (int j = 0; j < separatorExcel.Length; j++)
            {
                
                try
                {

                    for (int i = 0; i < data.Length; i++)
                    {
                        vectorX[i] = Convert.ToDouble(data[i].Substring(0, Separator(data, i, separatorExcel[j], 1)));
                        int numberElementStart = Separator(data, i, separatorExcel[j], 1);
                        int numberElementEnd = Separator(data, i, separatorExcel[j], 2) - numberElementStart;
                        vectorY[i] = Convert.ToDouble(data[i].Substring(numberElementStart + 1, numberElementEnd - 1));
                    }

                }

                catch { /*MessageBox.Show("Неверный формат разделителя для файла .csv");*/  choice = false; }
                if (j == 0 && choice == true) break;

            }
            
            VectorX = vectorX;
            VectorY = vectorY;
            /*foreach (int i in vectorX)
                p.AddedX(Convert.ToDouble(i));

            foreach (int i in vectorY)
                p.AddedY(Convert.ToDouble(i));*/
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
