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
using Guna.UI2.WinForms;

namespace ts910.ChatBox
{
    public partial class ChatBox : Form
    {
        UserInfo userInfo;

        SocketManager socket;
        String ipLocal;
        //String image = "Resources/user.png";
        bool isShow = false;

   
        string time = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();

        public ChatBox(UserInfo userInfo)
        {
            InitializeComponent();
            this.userInfo = userInfo;
            Connect();
            setSize1();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Home home = new Home();
            //home.ShowDialog();
            this.Close();
        }

        private void setSize1()
        {
            panel2.Size = new System.Drawing.Size(546, 74);
            pb_icon.Location = new System.Drawing.Point(7, 13);
            tb_nhap.Location = new System.Drawing.Point(60, 8);
            btn_send.Location = new System.Drawing.Point(494, 13);
            panel_icon.Visible = false;
            isShow = false;
        }

        private void setSize2()
        {
            panel2.Size = new System.Drawing.Size(546, 227);
            pb_icon.Location = new System.Drawing.Point(7, 165);
            tb_nhap.Location = new System.Drawing.Point(60, 160);
            btn_send.Location = new System.Drawing.Point(494, 165);
            panel_icon.Visible = true;
            isShow = true;
            panel_icon.Location = new System.Drawing.Point(7, 7);
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

        private void pb_icon_Click(object sender, EventArgs e)
        {
            if (isShow == false)
            {
                setSize2();
            }
            else { setSize1(); }
        }

        private void iconClick(object sender, EventArgs e)
        {
            var senderObject = (PictureBox)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            switch (buttonTag)
            {
                //case 0:
            }
            //"Resources/angel.png"
            //"Resources/happy (1).png"
            //"Resources/laughing (1).png"
            //"Resources/angry.png"
            //"Resources/clown.png"
            //"Resources/cry.png"
            //"Resources/crying.png"

            //"Resources/dead.png"
            //"Resources/devil.png"
            //"Resources/happy (1).png"
            //"Resources/neutral.png"
            //"Resources/sad (1).png"
            //"Resources/sad.png"
            //"Resources/savoring-food.png"

            //"Resources/scared.png"
            //"Resources/shocked.png"
        }
    }
}
