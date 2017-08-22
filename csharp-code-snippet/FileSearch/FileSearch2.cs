using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearch
{
    class FileSearch2
    {
        public void Search(string findstr, string path)
        {
            string[] files = GetFiles(path);
            StreamWriter sw = new StreamWriter(new FileStream( AppDomain.CurrentDomain.BaseDirectory + @"\result2.txt",FileMode.OpenOrCreate));
            

            foreach(string file in files )
            {
                StreamReader sr =  new StreamReader(new FileStream(file, FileMode.Open));
                List<String> list = new List<string>();
                string line;
                while((line = sr.ReadLine()) != null) {
                    list.Add(line);
                }

                foreach(string s in list)
                {
                    if(s.Contains(findstr)) {
                        sw.WriteLine(file + ":" + findstr);
                    }
                }
                list.Clear();

                sr.Close();
            }
            sw.Close();

        }

        public string[] GetFiles(string path)
        {
            try
            {
                return Directory.GetFiles(path);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
