using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearch
{
    class FileSearch3
    {
        public void Search(string findstr, string path)
        {
            string[] files = GetFiles(path);
            StreamWriter sw = new StreamWriter(new FileStream( AppDomain.CurrentDomain.BaseDirectory + @"\result3.txt",FileMode.OpenOrCreate));
            

            foreach(string file in files )
            {
                StreamReader sr =  new StreamReader(new FileStream(file, FileMode.Open));
                List<string> list = new List<string>();
                string line;
                while((line = sr.ReadLine()) != null) {
                    list.Add(line);
                }

                int index = 0;
                list.Sort();
                index = list.BinarySearch(findstr);
                if (index > 0)
                {
                    sw.WriteLine(file + ":" + list[index]);
                    while ((index + 1 < list.Count()) && (index = list.BinarySearch(index + 1, 1, findstr, null)) > 0)
                    {
                        sw.WriteLine(file + ":" + list[index]);
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
