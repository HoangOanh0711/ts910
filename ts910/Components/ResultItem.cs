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

namespace ts910.Components
{
    public partial class ResultItem : UserControl
    {

        private int _index;

        public ResultItem()
        {
            InitializeComponent();
        }

        public int index { get => _index; set { _index = value; lb_index.Text = _index.ToString(); } }
        public string schoolName { get => lk_schoolname.Text; set => lk_schoolname.Text = value; }
        public string weblink;
        public string address { get => lb_address.Text; set => lb_address.Text = value; }
        public string year { get => lb_year.Text; set => lb_year.Text = value; }
        public string studentNumber { get => lb_studentnumber.Text; set => lb_studentnumber.Text = value; }
        public string nv1 { get => lb_nv1.Text; set => lb_nv1.Text = value; }
        public string nv2 { get => lb_nv2.Text; set => lb_nv2.Text = value; }
        public string nv3 { get => lb_nv3.Text; set => lb_nv3.Text = value; }
        public Boolean isChoose { get => cb_isChoose.Checked; set => cb_isChoose.Checked = value; }

        private void lk_schoolname_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(weblink);
        }

        private void cb_isChoose_Click(object sender, EventArgs e)
        {

        }
    }
}
