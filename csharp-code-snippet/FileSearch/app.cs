using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearch
{
    class app
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                //FileSearch fs = new FileSearch();
                //fs.Search(args[0], @"C:\workspace\ws.study\my.code.snippet\files");


                //FileSearch2 fs2 = new FileSearch2();
                //fs2.Search(args[0], @"C:\workspace\ws.study\my.code.snippet\files");


                //FileSearch3 fs3 = new FileSearch3();
                //fs3.Search(args[0], @"C:\workspace\ws.study\my.code.snippet\files");

                FileSearch4 fs4 = new FileSearch4();
                fs4.Search(args[0], @"C:\workspace\ws.study\my.code.snippet\files");
                Console.ReadLine();
                
            }
        }
    }
}


