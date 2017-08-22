using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpQuiz
{
    class Combination
    {
        public static void Main(string[] args)
        {
            Combination c = new Combination();
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            Stack<int> picked = new Stack<int>();
           // Combination c = new Combination();
            c.Pick(a.Length, picked, 2);
            Console.ReadLine();
        }

        private void Pick(int n, Stack<int> picked, int toPick)
        {
            if(toPick == 0)
            {
                foreach(int k in picked)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
                return;
            }

            int smallest = 0; 
            if(picked.Count == 0 )
            {
                smallest = 0;
            } else
            {
                smallest = picked.Peek() + 1;
            }

            for(int i = smallest; i < n; i++)
            {
                picked.Push(i);
                Pick(n, picked, toPick - 1);
                picked.Pop();
            }
        }


        //Console.r
    }
}
