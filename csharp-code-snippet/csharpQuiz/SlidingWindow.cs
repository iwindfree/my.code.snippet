using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpQuiz
{
    class SlidingWindow
    {
        private string[] source = new string[] { "10", "11", "-1", "0", "9", "-3", "100.4", "82", "-15" };
        private int windowSize = 4;
        private List<Double> minValues = new List<Double>();
        private List<Double> maxValues = new List<Double>();
        private List<Double> tempValues = new List<double>();
        public static void Main(string[] args)
        {
            SlidingWindow w = new SlidingWindow();
            w.Solve();
            Console.ReadLine();
        }

        public void Solve()
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (i + windowSize == source.Length +1)
                {
                    break;
                }

                for (int j = i; j < i + windowSize; j++)
                {
                    tempValues.Add(Double.Parse(source[j]));
                }

                tempValues.Sort();
                minValues.Add(tempValues[0]);
                maxValues.Add(tempValues[windowSize - 1]);
                tempValues.Clear();
            }
            for (int i = 0; i < minValues.Count; i++)
            {
                Console.Out.Write(minValues[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i <  maxValues.Count; i++)
            {
                Console.Out.Write(maxValues[i] + " ");
            }
           

        }

        
    }
}
