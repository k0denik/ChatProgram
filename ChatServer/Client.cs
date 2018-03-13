using System;
using System.Net.Sockets;
using System.Threading;

namespace ChatServer
{
    public class Client
    {
        TcpClient _clientSocket;
        String _username;

        public Client(TcpClient clientSocket, string username)
        {
            _clientSocket = clientSocket;
            _username = username;
        }

        public TcpClient ClientSocket
        {
            get { return _clientSocket; }
        }

        public void Start()
        {
            Thread th = new Thread(HandleChat);
            th.Start();
        }

        private void HandleChat()
        {
            int buffSize = _clientSocket.ReceiveBufferSize;
            byte[] bytesFrom = new byte[buffSize];
            while (true)
            {
                NetworkStream networkStream = _clientSocket.GetStream();
                networkStream.Read(bytesFrom, 0, buffSize);
                String data = System.Text.Encoding.ASCII.GetString(bytesFrom);
                data = data.Substring(0, data.IndexOf('$'));
                Console.WriteLine(data);
                TcpConnection.getInstance().Broadcast(data);
            }

        }
    }
}