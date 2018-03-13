using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ChatServer
{
    public interface IConnection
    {
        void Start();

        void AddClient(Client client);

        void Broadcast(String msg);
    }

    class TcpConnection : IConnection
    {
        private TcpListener _serverSocket;
        private List<Client> clientList;
        private static TcpConnection one; 

        private TcpConnection()
        {
            _serverSocket = new TcpListener(IPAddress.Any, 7777);
            clientList = new List<Client>();
        }

        public static IConnection getInstance()
        {
            if (one == null)
            {
                one = new TcpConnection();
            }
            return one;
        }

        public void Start()
        {
            Console.WriteLine("Server started.");
            while (true)
            {
                _serverSocket.Start();
                TcpClient clientSocket = _serverSocket.AcceptTcpClient();
                int buffSize = clientSocket.ReceiveBufferSize;
                byte[] bytesFrom = new byte[buffSize];
                String username = null;

                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Read(bytesFrom, 0, buffSize);
                username = System.Text.Encoding.ASCII.GetString(bytesFrom);
                username = username.Substring(0, username.IndexOf('$'));
                Client newClient = new Client(clientSocket,username);
                newClient.Start();
                AddClient(newClient);
                Console.WriteLine("User: "+username+ " connected.");
            }
        }

        public void AddClient(Client client)
        {
            clientList.Add(client);
        }

        public void Broadcast(string msg)
        {
            foreach (var client in clientList)
            {
                TcpClient broadcastSocket = client.ClientSocket;
                NetworkStream broadcastStream = broadcastSocket.GetStream();
                Byte[] data = Encoding.ASCII.GetBytes(msg+"$");
                broadcastStream.Write(data,0,data.Length);
                broadcastStream.Flush();
                
            }
        }
    }
}