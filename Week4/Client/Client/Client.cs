using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace TCPChatServerClients
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        TcpClient client;
        int svport;
        IPAddress svAddr;
        string name;
       

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPort.Text.Length == 0 || txtPort.Text.Length == 0 || txtPort.Text.Length == 0 || txtUserID.Text.Length == 0)
                {
                    MessageBox.Show("Please fill the information.");
                }
                svport = Int32.Parse(txtPort.Text);
                svAddr = IPAddress.Parse(txtAddress.Text);
                name = txtUserID.Text;

                
                client = new TcpClient();
                client.Connect(svAddr, svport);
                
                NetworkStream stream = client.GetStream();


                Thread rev = new Thread(Receive);
                rev.IsBackground = true;
                rev.Start();
                connectBtn.Enabled = false;

            }
            catch 
            {
                MessageBox.Show("Cannot connect to the server.");
            }

        }

        private void Receive()
        {
            NetworkStream stream = client.GetStream();
            byte[] data = new byte[256];
            int bytes = stream.Read(data, 0, data.Length);
            string responseData = Encoding.UTF8.GetString(data, 0, bytes);
            lstMess.Items.Add(name + responseData);

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(txtSend.Text);
            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);
            txtSend.Clear();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtPort.Clear();
            txtSend.Clear();
            txtUserID.Clear();
        }
    }
}
