using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatProgram
{
    public class ServerConnection : IConnection
    {
        private TcpClient _client;
        private List<IConnectionObserver> observerList;
        private string _name;

        protected ServerConnection() { }

        public ServerConnection(TcpClient client, String name)
        {
            this._client = client;
            this._name = name;
            observerList = new List<IConnectionObserver>();
        }

        public List<IConnectionObserver> ObserverList
        {
            get { return observerList; }
        }

        private void AwaitMessages()
        {
            while (true)
            {
                var serverStream = _client.GetStream();
                int buffSize = _client.ReceiveBufferSize;
                byte[] inStream = new byte[buffSize];
                serverStream.Read(inStream, 0, buffSize);
                String returndata = "" + Encoding.ASCII.GetString(inStream);
                returndata = returndata.Substring(0, returndata.IndexOf('$'));
                foreach (var connectionObserver in observerList)
                {
                    connectionObserver.DataReceived(returndata);
                }
            }
        }

        public void SendMessage(string msg)
        {
            var serverStream = _client.GetStream();
            msg = _name + ": " + msg;
            serverStream.Write(Encoding.ASCII.GetBytes(msg + "$"), 0, msg.Length + 1);
            serverStream.Flush();
        }

        public IConnection Start()
        {
            Thread receiverThread = new Thread(AwaitMessages);
            receiverThread.Start();
            return this;
        }

        public void AddObserver(IConnectionObserver observer)
        {
            observerList.Add(observer);
        }
    }
}