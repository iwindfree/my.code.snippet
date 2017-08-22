using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using windfree.common.net.client;
using windfree.common.net.message;

namespace TestSocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientSocket sock = new ClientSocket();
            sock.RemoteAddr = "127.0.0.1";
            sock.RemotePort = 10000;
            sock.Connect();
            
            while(true)
            {
                string input = Console.ReadLine();
                if (sock.IsConnect())
                {
                    NetworkMessage msg = new NetworkMessage(sock.GetSock());
                    msg.WriteString(input);
                    msg.SendMessage();
                }
            }
        }
    }
}
