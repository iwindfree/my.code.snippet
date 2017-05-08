using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharp_code_snippet.DatetimeUtil
{
    class DtUtil
    {
        public void GetSeconds()
        {
            DateTime time1 = DateTime.Now;
            Thread.Sleep(2000);
            DateTime time2 = DateTime.Now;
            TimeSpan duration =  time2.Subtract(time1);
            Console.Out.WriteLine("total duration: {0}", (int)duration.TotalSeconds);
        }

        public void StringToDatetime()
        {
            string s = "2010-01-02 23:43:11";
            DateTime dt = Convert.ToDateTime(s);
            Console.Out.WriteLine("time:{0}", dt);

            DateTime dt1 =  DateTime.ParseExact(s, "yyyy-MM-dd HH:mm:ss",null);
            Console.Out.WriteLine("time:{0}", dt1);
        }
    }
}
