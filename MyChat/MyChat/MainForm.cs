using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace MyChat
{
    public partial class MainForm : Form
    {
        Socket socket;
        EndPoint epLocal, epRemote;
        byte[] buffer;

        public MainForm()
        {
            InitializeComponent();

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            tbIpQuelle.Text = GetIP();
        }

        private string GetIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "127.0.0.1";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            byte[] recData = new byte[1500];
            recData = (byte[])aResult.AsyncState;
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            string recMessage = aEncoding.GetString(recData);

            lbChatFenster.Items.Add("Friend: " + recMessage);

            buffer = new byte[1500];
            socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void btnSenden_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendM = new byte[1500];
            sendM = aEncoding.GetBytes(tbNachricht.Text);
            socket.Send(sendM);

            lbChatFenster.Items.Add("Me: " + tbNachricht.Text);
            tbNachricht.Clear();
            tbNachricht.Focus();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            epLocal = new IPEndPoint(IPAddress.Parse(tbIpQuelle.Text), Convert.ToInt32(tbPortQuelle.Text));
            socket.Bind(epLocal);
            epRemote = new IPEndPoint(IPAddress.Parse(tbIpZiel.Text), Convert.ToInt32(tbPortZiel.Text));
            socket.Connect(epRemote);

            buffer = new byte[1500];
            socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            tbNachricht.Focus();
        }
    }
}
