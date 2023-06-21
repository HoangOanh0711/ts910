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
using System.Net.NetworkInformation;

namespace ts910.ChatBox
{
    public partial class ChatBox : Form
    {
        SocketManager socket;
        String ipLocal;
        String image = "Resources/user.png";
        public ChatBox()
        {
            InitializeComponent();
            
            Connect();

            flow_chat.Controls.Add(new uc_chat_admin("hello",image));
            flow_chat.Controls.Add(new uc_chat_user("hi", image));

        }

        /*private string getIP()
        {
            
        }*/
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Home home = new Home();
            //home.ShowDialog();
            this.Close();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            flow_chat.Controls.Add(new uc_chat_user(tb_nhap.Text, image));
            socket.Send(new SocketData((int)SocketCommand.SEND_MESSAGE, tb_nhap.Text, image));
            tb_nhap.Text = "";
           

            //if (socket.IsServer == true)
            //{
            //    flow_chat.Controls.Add(new uc_chat_user(tb_nhap.Text,""));
            //    tb_nhap.Text = "";
            //    socket.Send(new SocketData((int)SocketCommand.SEND_MESSAGE, tb_nhap.Text,""));
            //}
            //else
            //{
            //    flow_chat.Controls.Add(new uc_chat_admin(tb_nhap.Text,""));
            //    tb_nhap.Text = "";
            //    socket.Send(new SocketData((int)SocketCommand.SEND_MESSAGE, tb_nhap.Text,""));
            //}
            Listen();

        }

        private void ProcessData(SocketData data)
        {

            switch (data.Command)
            {
                case (int)SocketCommand.SEND_MESSAGE:
                    //MessageBox.Show(data.Message);
                    if (socket.IsServer)
                    {
                        MessageBox.Show(data.Message, "server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(data.Message, "client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //flow_chat.Controls.Add(new uc_chat_admin(data.Message, data.Image));
                    break;

                //case (int)SocketCommand.NAMECL:
                //    this.Invoke((MethodInvoker)(() =>
                //    {
                //        name2.Text = data.Message;
                //        board.ListPlayers[1].Name = data.Message;
                //    }));
                //    break;

                //case (int)SocketCommand.NAMESE:
                //    this.Invoke((MethodInvoker)(() =>
                //    {
                //        name1.Text = data.Message;
                //        board.ListPlayers[0].Name = data.Message;
                //        socket.Send(new SocketData((int)SocketCommand.NAMECL, name2.Text, new Point()));
                //    }));
                //    break;

                case (int)SocketCommand.QUIT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        socket.CloseConnect();
                        MessageBox.Show("Kết thúc cuộc trò chuyện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                    break;


                default:
                    break;
            }
            Listen();
        }


        private void Connect()
        {

            /*socket.IP = getIP();*/
            /*socket.IP = "192.168.100.118";*/
            socket = new SocketManager();
            ipLocal = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(ipLocal))
                ipLocal = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            socket.IP = ipLocal;
 
            if (!socket.ConnectServer())
            {
                socket.IsServer = true;
                socket.CreateServer();
                label1.Text = "server";
                //MessageBox.Show("Bạn đang là Server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //name1.Text = name;
               
            }
            else
            {
                socket.IsServer = false;
                Listen();
                label1.Text = "client";
                //MessageBox.Show("Kết nối thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //name2.Text = name;
            }
        }

        private void Listen()
        {
            Thread ListenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();
                    ProcessData(data);
                }
                catch { }
            });

            ListenThread.IsBackground = true;
            ListenThread.Start();
        }
    }
}
