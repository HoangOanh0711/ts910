using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ts910
{
    public partial class quen_mat_khau_sdt : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public quen_mat_khau_sdt()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btn_guima_Click(object sender, EventArgs e)
        {
            this.Hide();
            quen_mat_khau quen_Mat_Khau = new quen_mat_khau(tb_email.Text);
            quen_Mat_Khau.ShowDialog();
            this.Close();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            dang_nhap dang_Ky = new dang_nhap();
            dang_Ky.ShowDialog();
            this.Close();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

        }
    }
}
