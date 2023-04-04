using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPMultiChat
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        TcpListener server;
        Dictionary<int, TcpClient> clientList;

        private void bt_listen_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse(txt_ip.Text);
                int port = int.Parse(txt_port.Text);
                server = new TcpListener(ipAddress, port);
                server.Start();
                clientList = new Dictionary<int, TcpClient>();
                Thread listenThread = new Thread(() =>
                {
                    while (true)
                    {
                        TcpClient client = server.AcceptTcpClient();
                        Thread clientThread = new Thread(() => HandleClient(client));
                        clientThread.IsBackground = true;
                        clientThread.Start();
                    }
                });
                listenThread.IsBackground = true;
                listenThread.Start();
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại !");
            }
        }

        void HandleClient(TcpClient client)
        {
            int clientId = Thread.CurrentThread.ManagedThreadId;
            clientList.Add(clientId, client);
            NetworkStream stream = client.GetStream();
            byte[] data = new byte[256];
            string clientName = txt_name.Text;
            int i;

            while ((i = stream.Read(data, 0, data.Length)) != 0)
            {
                string message = System.Text.Encoding.UTF8.GetString(data, 0, i);

                if (clientName == null)
                {
                    clientName = message.Trim();
                    string welcomeMessage = $"Welcome, {clientName}!\r\n";
                    byte[] welcomeData = System.Text.Encoding.UTF8.GetBytes(welcomeMessage);
                    stream.Write(welcomeData, 0, welcomeData.Length);
                }
                else
                {
                    string responseMessage = $"{clientName}: {message}";
                    byte[] responseData = System.Text.Encoding.UTF8.GetBytes(responseMessage);
                    SendToAllClients(responseData);
                }
            }

            clientList.Remove(clientId);
            client.Close();
        }

        void SendToAllClients(byte[] data)
        {
            foreach (TcpClient client in clientList.Values)
            {
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (TcpClient client in clientList.Values)
            {
                client.Close();
            }
            clientList.Clear();
        }
    }
}
