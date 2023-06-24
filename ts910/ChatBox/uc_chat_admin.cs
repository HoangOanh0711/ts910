using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ts910.ChatBox
{
    public partial class uc_chat_admin : UserControl
    {
        
        public uc_chat_admin() 
        {
          
        }
        public uc_chat_admin(string text, string anh, string time)
        {
            InitializeComponent();
            
            Text = text;
            Time = time;
            Anh = Image.FromFile(anh);

        }
        public string Text { get => tb_admin.Text; set => tb_admin.Text = value; }
        public Image Anh { get => ava_admin.Image; set => ava_admin.Image = value; }
        public string Time { get => lb_time.Text; set => lb_time.Text = value; }


    }
}
