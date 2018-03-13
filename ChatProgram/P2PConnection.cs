using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatProgram
{
    internal class P2PConnection : IConnection
    {
        private string _name;
        private ServerConnection connection;

        public P2PConnection(TcpClient client, String name)
        {
            _name = name;
            connection = new ServerConnection(client,name);
        }

        public void SendMessage(string msg)
        {
            foreach (var connectionObserver in connection.ObserverList)
            {
                connectionObserver.MessageSent(_name + ": " + msg);
            }
            connection.SendMessage(msg);
        }

        public IConnection Start()
        {
            connection.Start();
            return this;
        }

        public void AddObserver(IConnectionObserver observer)
        {
            connection.AddObserver(observer);
        }
    }
}
