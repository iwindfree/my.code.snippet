using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearch
{
    class MyComparer : IComparer<String>
    {
        public int Compare(string x, string y)
        {
            return x.CompareTo(y);
        }
    }
}
