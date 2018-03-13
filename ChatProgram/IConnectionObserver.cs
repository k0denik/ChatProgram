using System;

namespace ChatProgram
{
    public interface IConnectionObserver
    {
        void UserConnected(String msg);

        void MessageSent(String data);
        
        void DataReceived(String data);
    }
}