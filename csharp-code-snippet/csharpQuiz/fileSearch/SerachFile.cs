using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpQuiz.fileSearch
{
    class SerachFile
    {
        public void Search(string findstr, string path)
        {
            string[] files = GetFiles(path);
            string outFile = AppDomain.CurrentDomain.BaseDirectory + @"\result.txt";

            StreamWriter sw = new StreamWriter(new FileStream(outFile, FileMode.OpenOrCreate));
            foreach(string fileName in files)
            {
                using(StreamReader sr = new StreamReader(new FileStream(fileName,FileMode.Open)))
                {
                    string line; 
                    while((line = sr.ReadLine()) != null)
                    {
                        if(line.Contains(findstr))
                        {
                            sw.WriteLine(fileName + ":" + findstr);
                        }
                    }
                   
                }
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
