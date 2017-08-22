using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpQuiz.fileSearch
{
    class app
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("args:" + args[0]);
         //   Console.ReadLine();
            SerachFile sf = new SerachFile();
            sf.Search(args[0], @"C:\workspace\ws.study\my.code.snippet\files");
        }
    }
}
