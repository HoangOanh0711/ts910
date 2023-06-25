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
        string pathIcon;
   
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
            Home home = new Home(userInfo);
            home.ShowDialog();
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
                case 1:
                    pathIcon = "Resources/angel.png";
                    flow_chat.Controls.Add(new uc_icon_user(userInfo.Ava, pathIcon,time));
                    break;
                case 2:
                    pathIcon = "Resources/happy (1).png";
                    flow_chat.Controls.Add(new uc_icon_user(userInfo.Ava, pathIcon, time));
                    break;
                case 3:
                    pathIcon = "Resources/laughing (1).png";
                    flow_chat.Controls.Add(new uc_icon_user(userInfo.Ava, pathIcon, time));
                    break;
                case 4:
                    pathIcon = "Resources/savoring-food.png";
                    flow_chat.Controls.Add(new uc_icon_user(userInfo.Ava, pathIcon, time));
                    break;

                case 5:
                    pathIcon = "Resources/clown.png";
                    flow_chat.Controls.Add(new uc_icon_user(userInfo.Ava, pathIcon, time));
                    break;

                case 6:
                    pathIcon = "Resources/sad.png";
                    flow_chat.Controls.Add(new uc_icon_user(userInfo.Ava, pathIcon, time));
                    break;

                case 7:
                    pathIcon = "Resources/crying.png";
                    flow_chat.Controls.Add(new uc_icon_user(userInfo.Ava, pathIcon, time));
                    break;

                case 8:
                    pathIcon = "Resources/sad (1).png";
                    flow_chat.Controls.Add(new uc_icon_user(userInfo.Ava, pathIcon, time));
                    break;

                case 9:
                    pathIcon = "Resources/scared.png";
                    flow_chat.Controls.Add(new uc_icon_user(userInfo.Ava, pathIcon, time));
                    break;

                case 10:
                    pathIcon = "Resources/dead.png";
                    flow_chat.Controls.Add(new uc_icon_user(userInfo.Ava, pathIcon, time));
                    break;

                case 11:
                    pathIcon = "Resources/shocked.png";
                    flow_chat.Controls.Add(new uc_icon_user(userInfo.Ava, pathIcon, time));
                    break;
                
                case 12:
                    pathIcon = "Resources/angry.png";
                    flow_chat.Controls.Add(new uc_icon_user(userInfo.Ava, pathIcon, time));
                    break;
                
                case 13:
                    pathIcon = "Resources/neutral.png";
                    flow_chat.Controls.Add(new uc_icon_user(userInfo.Ava, pathIcon, time));
                    break;
                
                case 14:
                    pathIcon = "Resources/cry.png";
                    flow_chat.Controls.Add(new uc_icon_user(userInfo.Ava, pathIcon, time));
                    break;

                case 15:
                    pathIcon = "Resources/devil.png";
                    flow_chat.Controls.Add(new uc_icon_user(userInfo.Ava, pathIcon, time));
                    break;

            }
        }
    }
}
