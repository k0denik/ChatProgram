using System;
using System.Collections.Generic;

namespace ChatProgram
{
    public interface IConnection
    {
        void SendMessage(String msg);
        IConnection Start();
        void AddObserver(IConnectionObserver observer);
    }

    class DummyConnection : IConnection
    {
        private List<IConnectionObserver> observerList;

        public DummyConnection()
        {
            observerList = new List<IConnectionObserver>();
        }

        public void SendMessage(string msg)
        {
            foreach (var connectionObserver in observerList)
            {
                connectionObserver.MessageSent(msg);
            }
            foreach (var connectionObserver in observerList)
            {
                connectionObserver.DataReceived("User: I'm responding to: \'"+msg+"\'");
            }
        }

        public IConnection Start()
        {
            return this;
        }

        public void AddObserver(IConnectionObserver observer)
        {
            observerList.Add(observer);
        }
    }
}