using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace csharp_code_snippet.simpleSocket
{
    class NetworkMessage
    {
        private const int HEADER_LENGTH = 6;
        private int dataLength;
        private int headerLength;
        private byte[] buffer;
        
        private MessageProtocol protocol = MessageProtocol.PERFORMANCE_DATA;
        private string message;
        private TcpClient sock;

        public int DataLength
        {
            get { return DataLength; }
            set { this.dataLength = value; }
        }

        public int HeaderLength
        {
            get { return headerLength; }
            set { this.headerLength = value; }
        }

        public MessageProtocol Protocol
        {
            get { return protocol; }
            set { this.protocol = value; }
        }

        public string Message
        {
            get { return message; }
            set { this.message = value; }
        }

        public NetworkMessage()
        {
            
        }

        public NetworkMessage(TcpClient sock)
        {
            this.sock = sock;
        }

       
        public void SendMessage()
        {
          //  byte[] lenBytes = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(this.message.Length));
          //  byte[] protocolBytes = BitConverter.GetBytes(IPAddress.HostToNetworkOrder((short)this.protocol));
          //  byte[] messageBytes = System.Text.Encoding.UTF8.GetBytes(this.message);
          //  this.buffer = new byte[HEADER_LENGTH + messageBytes.Length];
            MemoryStream mStream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(mStream,Encoding.UTF8);

            writer.Write(IPAddress.HostToNetworkOrder(this.message.Length));
            writer.Write(IPAddress.HostToNetworkOrder((short)this.protocol));
            writer.Write(this.message);
            byte[] buffer = mStream.ToArray();

            NetworkStream nStream = this.sock.GetStream();
            nStream.Write(buffer, 0, buffer.Length);
            
        }

        public void SendMessage(TcpClient sock)
        {
            MemoryStream mStream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(mStream, Encoding.UTF8);

            writer.Write(IPAddress.HostToNetworkOrder(this.message.Length));
            writer.Write(IPAddress.HostToNetworkOrder((short)this.protocol));
            writer.Write(this.message);
            byte[] buffer = mStream.ToArray();

            NetworkStream nStream = sock.GetStream();
            nStream.Write(buffer, 0, buffer.Length);
        }

        public void ReadMessage()
        {
            NetworkStream nStream = this.sock.GetStream();
            BinaryReader reader = new BinaryReader(nStream);
            this.dataLength = reader.ReadInt32();
            this.protocol = (MessageProtocol) reader.ReadInt16();
            this.message = reader.ReadString();
        }

    }
}
