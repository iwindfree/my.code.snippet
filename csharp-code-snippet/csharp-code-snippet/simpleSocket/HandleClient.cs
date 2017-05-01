using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_code_snippet.simpleSocket
{
    class HandleClient
    {
        TcpClient clientSock;
        public static Object lockObj = new Object();
      
        public HandleClient(TcpClient sock)
        {
            this.clientSock = sock;
        }
        public void Start()
        {
            Thread th = new Thread(new ThreadStart(Run));
            th.Start();
        }

        private void Run()
        {
            NetworkStream stream = clientSock.GetStream();
            byte[] buffer = new byte[1024];
            while (true)
            {
                stream.Read(buffer, 0, buffer.Length);
                string recvMsg = System.Text.Encoding.ASCII.GetString(buffer);
               //Console.Write("server: receive message: {0}", recvMsg);
                WriteText(recvMsg);
                int k = 0;
            }
         
            stream.Close();
            clientSock.Close();
        }

         void WriteText(string text)
        {
            lock (lockObj) {
            
            using (StreamWriter outputFile = new StreamWriter(@"c:\temp\111.txt",true))
                {
                    outputFile.Write(text);
                }
            }
        }

    }
}
