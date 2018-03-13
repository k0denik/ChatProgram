using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatProgram
{
    public class ConnectionFactory
    {
        public static IConnection CreateServerConnection(String hostname, String port, String name)
        {
            TcpClient clientSocket = new TcpClient();
            clientSocket.Connect(hostname, int.Parse(port));
            var serverStream = clientSocket.GetStream();
            serverStream.Write(Encoding.ASCII.GetBytes(name + "$"), 0, name.Length + 1);
            serverStream.Flush();
            return new ServerConnection(clientSocket,name).Start();
        }

        public static IConnection CreateP2PListener(String port, String name)
        {
            TcpListener listenerSocket = new TcpListener(IPAddress.Any, int.Parse(port));
            listenerSocket.Start();
            var receiveSocket = listenerSocket.AcceptTcpClient();
//            byte[] usernameBytes = new byte[255];
//            receiveSocket.GetStream().Read(usernameBytes, 0, (int)receiveSocket.ReceiveBufferSize);
//            String username = Encoding.ASCII.GetString(usernameBytes);
            
            return new P2PConnection(receiveSocket, name).Start();
        }

        public static IConnection CreateP2PConnection(String hostname, String port, String name)
        {
            TcpClient clientSocket = new TcpClient();
            clientSocket.Connect(hostname, int.Parse(port));
            return new P2PConnection(clientSocket,name).Start();
        }

        public static IConnection CreateDummyConnection()
        {
            return new DummyConnection().Start();
        }
    }
}