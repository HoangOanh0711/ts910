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
using ts910.ChatBox;
using ts910.News;

namespace ts910
{
    public partial class Home : Form
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

        UserInfo userInfo;

        public Home(UserInfo userInfo)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            setSize();

            drawer.Visible = false;

            lb_username.Text = userInfo.Hoten;
            pb_ava.Image = Image.FromFile(userInfo.Ava);

            this.userInfo = userInfo;
        }

        private void setSize()
        {
            this.Size = new Size(526, 840);

            header1.Location = new Point(0, 0);
            header1.Size = new Size(527, 96);

            pictureBox1.Location = new Point(0, 97);
            pictureBox1.Size = new Size(527, 177);

            guna2Panel1.Location = new Point(37, 274);
            guna2Panel1.Size = new Size(454, 550);

            news_in_Home1.Location = new Point(36, 870);
            news_in_Home1.Size = new Size(463, 548);

            contact1.Location = new Point(0, 1450);
            contact1.Size = new Size(523, 333);

            footer2.Location = new Point(0, 1846);
            footer2.Size = new Size(530, 400);
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbx_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_type.SelectedIndex == 0)
            {
                lb_specialSub.Visible = false;
                lb_special.Visible = false;
                tb_specialSubject.Visible = false;
                cbx_specialSubject.Visible = false;
            }
            else
            {
                lb_specialSub.Visible = true;
                lb_special.Visible = true;
                tb_specialSubject.Visible = true;
                cbx_specialSubject.Visible = true;
                tb_specialSubject.Text = string.Empty;

                if (cbx_type.SelectedIndex == 2)
                {
                    lb_specialSub.Text = "Môn tích hợp: ";
                    cbx_specialSubject.SelectedIndex = 2;
                }
                else
                {
                    lb_specialSub.Text = "Môn chuyên: ";
                    cbx_specialSubject.SelectedIndex = -1;
                }
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            float math = float.Parse(tb_math.Text);
            float liter = float.Parse(tb_liter.Text);
            float eng = float.Parse(tb_english.Text);
            float sum;


            if (cbx_type.SelectedIndex == 0) {
                if(tb_math.Text.Trim() == "" || tb_liter.Text.Trim() == "" || tb_english.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập điểm các môn", "Lỗi");
                    return;
                }
                else
                {
                    sum = math + liter + eng;
                    lb_sum.Text = Convert.ToString(sum);
                }
            }
            else if (cbx_type.SelectedIndex == 1)
            {
                if (cbx_specialSubject.SelectedIndex != -1)
                {
                    if(tb_specialSubject.Text.Trim() != "")
                    {
                        float special = float.Parse(tb_specialSubject.Text);
                        sum = math + liter + eng + special * 2;
                        lb_sum.Text = Convert.ToString(sum);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập điểm môn chuyên", "Lỗi");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn môn chuyên", "Lỗi");
                    return;
                }   
            }
            else
            {
                if (tb_specialSubject.Text.Trim() != "")
                {
                    float special = float.Parse(tb_specialSubject.Text);
                    sum = math + liter + eng + special;
                    lb_sum.Text = Convert.ToString(sum);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập điểm môn tiếng anh", "Lỗi");
                    return;
                }

            }

            Result result = new Result(lb_sum.Text, cbx_type.SelectedIndex, cbx_specialSubject.SelectedIndex);
            result.Show();
        }

        private bool check = false;
        private void timerDrawer_Tick(object sender, EventArgs e)
        {
            if (check)
            {
                drawer.Width -= 10;
                if (drawer.Width == drawer.MinimumSize.Width)
                {
                    check = false;
                    timerDrawer.Stop();
                }
            }
            else
            {
                drawer.Width += 10;
                if (drawer.Width == drawer.MaximumSize.Width)
                {
                    drawer.Visible = true;
                    check = true;
                    timerDrawer.Stop();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            timerDrawer.Start();
        }

        private void header1_Click(object sender, EventArgs e)
        {
            timerDrawer.Start();
        }

        private void panel_tuvan_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChatBox.ChatBox chatBox = new ChatBox.ChatBox(userInfo);
            chatBox.ShowDialog();
            this.Close();
        }

        private void panel_dangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            dang_nhap dang_Nhap = new dang_nhap();
            dang_Nhap.ShowDialog();
            this.Close();
        }

        private void panel_tinTuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            News_ListView news_ListView = new News_ListView();
            news_ListView.ShowDialog();
            this.Close();
        }
    }
}
