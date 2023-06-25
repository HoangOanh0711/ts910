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
        UserInfo userInfo;

        SocketManager socket;
        String ipLocal;
        //String image = "Resources/user.png";

   
        string time = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();

        public ChatBox(UserInfo userInfo)
        {
            InitializeComponent();
            this.userInfo = userInfo;
            Connect();

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(userInfo);
            home.ShowDialog();
            this.Close();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {

            //int date = DateTime.Now.Date;
            time = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            flow_chat.Controls.Add(new uc_chat_user(tb_nhap.Text, userInfo.Ava, time));
            socket.Send(new SocketData((int)SocketCommand.SEND_MESSAGE, tb_nhap.Text, userInfo.Ava, time));
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

        delegate void SetTextCallback(Form f, Control ctrl, string text, string anh, string time);

        public static void SetText(Form form, Control ctrl, string text, string anh, string time)
        {
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, text, anh, time });
            }
            else
            {
                ctrl.Controls.Add(new uc_chat_admin(text, anh, time));
            }
        }

        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.SEND_MESSAGE:
                    SetText(this, flow_chat, data.Message, data.Image, data.Time);
                    break;

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
