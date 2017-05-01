using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharp_code_snippet.simpleSocket
{
    class SocketServer
    {
        TcpListener listener;
        bool running = false;
        public SocketServer()
        {
            init();
        }
        public void Start()
        {
            Thread th = new Thread(new ThreadStart(Run));
            th.Start();
        }

        private void init()
        {
            IPAddress addr = IPAddress.Any;
            listener = new TcpListener(addr, 10000);
        }

        private void Run()
        {
            try
            {
                listener.Start();
                running = true;
                while (running)
                {
                    TcpClient clientSock = listener.AcceptTcpClient();
                    HandleClient handler = new HandleClient(clientSock);
                    handler.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
