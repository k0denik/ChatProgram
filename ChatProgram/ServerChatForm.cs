using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ChatProgram
{
    public partial class ServerChatForm : Form
    {
        private readonly IConnection _connection;
        public ServerChatForm(IConnection conn)
        {
            InitializeComponent();
            _connection = conn;
            conn.AddObserver(new ServerChatFormObserver(messageTextBox1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _connection.SendMessage(msgInputTextBox1.Text);
            msgInputTextBox1.Text = "";
            msgInputTextBox1.Focus();
        }

        private void ServerChatForm_Load(object sender, EventArgs e)
        {

        }
    }
}
