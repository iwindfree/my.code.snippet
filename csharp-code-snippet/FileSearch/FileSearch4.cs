using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using windfree.common.net.server;
namespace FileSearch
{
    class FileSearch4
    {
        public void Search(string findstr, string path)
        {
            SocketServer srv = new SocketServer();
            srv.Port = 10000;
            srv.Start();

        }
        
    }
}
