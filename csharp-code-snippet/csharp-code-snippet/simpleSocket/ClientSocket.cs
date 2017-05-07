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
                    NetworkMessage msg = new NetworkMessage(clientSock);
                    msg.Message = "I\'m a clinet socket #" + ClientSocket.count;
                    msg.SendMessage();
                  
                    //Console.WriteLine("clinet: Send message -> {0}", sendMsg);
                    //while(true)
                    //{
                    //    msg.ReadMessage();
                    //}
                  
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
