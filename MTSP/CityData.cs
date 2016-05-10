using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MTSP
{
    class CityData
    {

        public int Length = 48;

        public int[,] DistanceArr { get; private set; }
        public int[,] CostArr { get; private set; }

        public CityData()
        {
            DistanceArr = ReadCSV("Distance.csv");
            CostArr = ReadCSV("Cost.csv");

        }

        // Read csv files and parse them
        private int[,] ReadCSV(string filename)
        {

            int[,] arr = new int[Length, Length];

            StreamReader reader = new StreamReader(File.OpenRead(filename));

            int i = 0;
            int val = 0;
            string empty = "";
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');
                for (int j=0; j<i+1; j++)
                {
                    if (values[j] == empty) continue;
                    val = int.Parse(values[j]);
                    arr[i, j] = val;
                    arr[j, i] = val;
                    //arr[j, i] = 0;
                }
                i++;
            }
            reader.Close();

            return arr;
        
        }

    }
}
