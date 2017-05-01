using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace csharp_code_snippet.simpleSocket
{
    
    class ClientSocket
    {
        static int count = 0;
        TcpClient clientSock;
        private Object thisLock = new Object();
        public ClientSocket()
        {

            lock (thisLock)
            {
                count++;
            }
            

            clientSock = new TcpClient();

        }

        public void Execute()
        {
            try
            {
                IPAddress addr = IPAddress.Parse("127.0.0.1");
                clientSock.Connect(addr, 10000);
                if(clientSock.Connected)
                {
                    NetworkStream stream = clientSock.GetStream();
                    string sendMsg = "I\'m a clinet socket #" + ClientSocket.count;
                    byte[] buffer = System.Text.Encoding.ASCII.GetBytes(sendMsg);
                    stream.Write(buffer, 0, buffer.Length);
                    //Console.WriteLine("clinet: Send message -> {0}", sendMsg);
                  
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                throw e;
            }
         

        }

    }
}
