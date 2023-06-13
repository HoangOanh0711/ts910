using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ts910
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.thpt-lehongphong-tphcm.edu.vn/");
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
