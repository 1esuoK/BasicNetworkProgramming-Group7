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
                clientList = new Dictionary<int, TcpClient>();
                Thread listen = new Thread(() =>
                {
                    server.Start();
                    txt_messages.Text += "Server đã khởi động !";
                    Thread newClient = new Thread(() =>
                    {
                        int id = 0;
                        while (true)
                        {
                            TcpClient client = server.AcceptTcpClient();
                            id++;
                            clientList.Add(id, client);
                            Thread receive = new Thread(HandleClient);
                            receive.IsBackground = true;
                            receive.Start(id);
                        }
                    });
                    newClient.Start();
                });
                listen.IsBackground = true;
                listen.Start();
                
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại !");
            }
        }

        void HandleClient(object obj)
        {
            int id = (int)obj;
            byte[] Data = new byte[256];
            TcpClient client = clientList[id];
            String Mess = null;
            NetworkStream stream = client.GetStream();
            int i;
            string ResponseMessage = "";
            CheckForIllegalCrossThreadCalls = false;
            while ((i = stream.Read(Data, 0, Data.Length)) != 0)
            {
                Mess = System.Text.Encoding.UTF8.GetString(Data, 0, i);
                txt_messages.Text += "Client: " + id + ": " + Mess + "\r\n";
                ResponseMessage = "Client" + id + ": " + Mess+ "\r\n";
                BroadCast(ResponseMessage);
            }
        }

        void BroadCast(string ResponseMessages)
        {
            byte[] ResponseData = System.Text.Encoding.UTF8.GetBytes(ResponseMessages);
            foreach (TcpClient Client in clientList.Values)
            {
                NetworkStream Stream = Client.GetStream();
                Stream.Write(ResponseData, 0, ResponseData.Length);
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
