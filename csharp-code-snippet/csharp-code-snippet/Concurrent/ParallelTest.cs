using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_code_snippet.Concurrent
{
    class ParallelTest
    {
        public void Do()
        {
            double sum = 0;
            Parallel.For(0, 101, (int i) =>
            {
                sum += i;
            });
            Console.Out.WriteLine("the sum:{0}", sum);
           
        }
    }
}
