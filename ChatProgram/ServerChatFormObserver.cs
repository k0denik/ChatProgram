using System;
using System.Windows.Forms;

namespace ChatProgram
{
    public class ServerChatFormObserver : IConnectionObserver
    {
        private RichTextBox _richTextBox;

        public ServerChatFormObserver(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }


        public void UserConnected(string msg)
        {
            if (_richTextBox.FindForm().InvokeRequired)
            {
                _richTextBox.FindForm().Invoke(new MethodInvoker(() => UserConnected(msg)));
            }
            else
            {
                _richTextBox.AppendText("User joined: " + msg + "\n");
                trim();
            }
        }

        public void MessageSent(string data)
        {
            if (_richTextBox.FindForm().InvokeRequired)
            {
                _richTextBox.FindForm().Invoke(new MethodInvoker(() => MessageSent(data)));
            }
            else
            {
                _richTextBox.AppendText(data + "\n");
                trim();
            }
            
        }

        public void DataReceived(String data)
        {
            if (_richTextBox.FindForm().InvokeRequired)
            {
                _richTextBox.FindForm().Invoke(new MethodInvoker(() => DataReceived(data)));
            }
            else
            {
                _richTextBox.AppendText(data + "\n");
                trim();
            }
            
        }

        private void trim()
        {
            if (_richTextBox.Lines.Length > 21)
            {
                _richTextBox.Text =_richTextBox.Text.Substring(_richTextBox.Text.IndexOf('\n')+1);
                _richTextBox.ScrollToCaret();
            }
        }

        
    }
}