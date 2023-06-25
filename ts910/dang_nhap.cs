using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel.Application;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ts910
{
    public partial class dang_nhap : Form
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

        public dang_nhap()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }


        private void btn_dangky_Click(object sender, EventArgs e)
        {
            this.Hide();
            dang_ky dangky = new dang_ky();
            dangky.ShowDialog();
            this.Close();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (tb_email.Text == "" || tb_mk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Excel excel = new Excel();
                Workbook wb = excel.Workbooks.Open(Program.filePathExcel);
                Worksheet ws = wb.Worksheets["Tài khoản"];

                for (int row = 2; row <= ws.UsedRange.Rows.Count; ++row)//đọc row hiện có trong Excel
                {
                    Range db_email = ws.Range[$"C{row}"];
                    string emailValue = db_email.Text;

                    if (tb_email.Text.Equals(emailValue))
                    {
                        Range db_mk = ws.Range[$"G{row}"];
                        string mkValue = db_mk.Text;
                        if (tb_mk.Text.Equals(mkValue))
                        {
                            UserInfo userInfo = new UserInfo(ws.Range[$"B{row}"].Text, ws.Range[$"C{row}"].Text, ws.Range[$"D{row}"].Text, ws.Range[$"E{row}"].Text, ws.Range[$"F{row}"].Text);
                            wb.Close();
                            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Home home = new Home(userInfo);
                            home.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            wb.Close();
                            MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                wb.Close();
                MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            quen_mat_khau_sdt quen_Mat_Khau_Sdt = new quen_mat_khau_sdt();
            quen_Mat_Khau_Sdt.Show();
        }
    }
}
