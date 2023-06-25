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
    public partial class uc_icon_admin : UserControl
    {
        public uc_icon_admin()
        {
            InitializeComponent();
        }

        public uc_icon_admin(string ava, string icon, string time)
        {
            InitializeComponent();

            Ava = Image.FromFile(ava);
            Icon = Image.FromFile(icon);
            Time = time;
        }
        string time;
        public string Time { get => lb_time.Text; set => lb_time.Text = value; }
        public Image Ava { get => ava_admin.Image; set => ava_admin.Image = value; }
        public Image Icon { get => icon_admin.Image; set => icon_admin.Image = value; }

    }
}
