using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfGraph
{
   class Content : MainWindow
    {
        public int numberPoint { get; set; }
        public  double vectorX2 { get; set; }
        public  double vectorY2 { get; set; }
        public static double[] VectorX;
        public static double[] VectorY; 
        public string pathName;

        public static List<Content> contents = new List<Content>();
        public Content() { }

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

        public static int CheckHeader(string header, string data2, int i)
        {
            int check = 0;
            for (int j = 0; j < header.Length; j++)
            {
                if (data2[i] == header[j])
                    check++;
                i++;
            }


            return check;
        }




        public List<Content> ReadCSV(string fileName, string headerX, string headerY, char delimeter)
        {
            // We change file extension here to make sure it's a .csv file.
            // TODO: Error checking.
            // string[] lines = File.ReadAllLines(System.IO.Path.ChangeExtension(fileName, ".csv"));
            string[] data = File.ReadAllLines(System.IO.Path.ChangeExtension(fileName, ".csv"), Encoding.Default);
            // lines.Select allows me to project each line as a Person. 
            // This will give me an IEnumerable<Person> back.
            VectorX = null;
            VectorY = null;
            contents.Clear();
            //string headerX = "Freq";
            // string headerY = "L";
            int indexHeaderX = 0;
            int indexHeaderY = 0;

            int indexHeaderX2 = 0;
            int indexHeaderY2 = 0;

            int counterborderX = 0;
            int counterborderY = 0;
            for (int i = 0; i < data.Length; i++)
            {


                if (data[i].Contains(headerX) && counterborderX == 1)
                {
                    indexHeaderX2 = i;
                    counterborderX = 2;
                }

                if (data[i].Contains(headerX) && counterborderX == 0)
                {
                    indexHeaderX = i;
                    counterborderX = 1;
                }

                if (data[i].Contains(headerY) && counterborderY == 1)
                {
                    indexHeaderY2 = i;
                    counterborderY = 2;
                }

                if (data[i].Contains(headerY) && counterborderY == 0)
                {
                    indexHeaderY = i;
                    counterborderY = 1;
                }

            }

            int counterData = 0;
            string[] dataX = new string[indexHeaderX2 - indexHeaderX];
            for (int i = indexHeaderX; i < indexHeaderX2; i++)
            {
                dataX[counterData] = delimeter + data[i];
                counterData++;
            }

            int counterSeparatorHeader = 0;
            for (int i = 0; i < dataX[0].Length; i++)
            {
                if (dataX[0][i] == headerX[0])
                {

                    int check = CheckHeader(headerX, dataX[0], i);
                    if (check == headerX.Length)
                        break;
                }

                if (dataX[0][i] == delimeter)
                    counterSeparatorHeader++;
            }

            int counterVector = 0;
            double[] vectorX = new double[dataX.Length - 1];
            for (int i = 1; i < dataX.Length; i++)
            {

                int numberElementStart = Separator(dataX, i, delimeter, counterSeparatorHeader);
                int numberElementEnd = Separator(dataX, i, delimeter, counterSeparatorHeader + 1) - numberElementStart;
                vectorX[counterVector] = Convert.ToDouble(dataX[i].Substring(numberElementStart + 1, numberElementEnd - 1));
                counterVector++;
            }

            counterData = 0;
            string[] dataY = new string[indexHeaderY2 - indexHeaderY];
            for (int i = indexHeaderY; i < indexHeaderY2; i++)
            {
                dataY[counterData] = data[i];
                counterData++;
            }

            counterSeparatorHeader = 0;
            for (int i = 0; i < dataY[0].Length; i++)
            {
                if (dataY[0][i] == headerY[0])
                {

                    int check = CheckHeader(headerY, dataY[0], i);
                    if (check == headerY.Length)
                        break;
                }

                if (dataY[0][i] == delimeter)
                    counterSeparatorHeader++;
            }
            counterVector = 0;
            double[] vectorY = new double[dataY.Length - 1];
            for (int i = 1; i < dataY.Length; i++)
            {
                int numberElementStart = Separator(dataY, i, delimeter, counterSeparatorHeader);
                int numberElementEnd = Separator(dataY, i, delimeter, counterSeparatorHeader + 1) - numberElementStart;
                vectorY[counterVector] = Convert.ToDouble(dataY[i].Substring(numberElementStart + 1, numberElementEnd - 1));
                counterVector++;
            }


            for (int i = 0; i < vectorX.Length; i++)
            {
                contents.Add(new Content() { vectorX2 = vectorX[i], vectorY2 = vectorY[i], numberPoint = i+1});
            }
            VectorX = vectorX;
            VectorY = vectorY;
            
            return contents;

    }

    }
}
