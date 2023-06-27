using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ts910
{
    public partial class quen_mat_khau_sdt : Form
    {
        Random random = new Random();
        int otp;
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
            try
            {
                otp = random.Next(1000, 9999);
                var fromAddress = new MailAddress("kaitothompson273@gmail.com");
                var toAddress = new MailAddress(tb_email.Text);
                const string fromPass = "pptvlpeztlmimmge";
                const string subject = "OTP code";
                string body = otp.ToString();

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPass),
                    Timeout = 20000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body,
                })
                {
                    smtp.Send(message);
                }
                MessageBox.Show("otp gui xong");
                this.Hide();
                quen_mat_khau quen_Mat_Khau = new quen_mat_khau(tb_email.Text, otp.ToString());
                quen_Mat_Khau.ShowDialog();
                this.Close();

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

            
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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
