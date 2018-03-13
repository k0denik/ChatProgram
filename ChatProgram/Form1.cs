using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hostnameTextBox1.Text = "127.0.0.1";
            portTextBox3.Text = "999";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IConnection conn = null;
            switch (checkedListBox1.SelectedIndex)
            {
                case 0:
                    conn = ConnectionFactory.CreateServerConnection(hostnameTextBox1.Text, portTextBox3.Text,
                        nameTextBox2.Text);
                    break;
                case 1:
                    conn = ConnectionFactory.CreateP2PConnection(hostnameTextBox1.Text, portTextBox3.Text,
                        nameTextBox2.Text);
                    break;
                default:
                    conn = ConnectionFactory.CreateDummyConnection();
                    break;
            }

            new ServerChatForm(conn).Show();
        }

        private void listenButton_Click(object sender, EventArgs e)
        {
            new ServerChatForm(ConnectionFactory.CreateP2PListener(portTextBox3.Text, nameTextBox2.Text)).Show();
        }
    }
}