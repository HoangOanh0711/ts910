using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel.Application;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace ts910
{
    public partial class quen_mat_khau : Form
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
        String email;
        public quen_mat_khau(String email)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.email = email;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (tb_maXacNhan.Text == "" || tb_mk.Text == "" || tb_mkMoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (tb_mk.Text == tb_mkMoi.Text)
                {
                    Excel excel = new Excel();
                    Workbook wb = excel.Workbooks.Open(Program.filePathExcel);
                    Worksheet ws = wb.Worksheets["Tài khoản"];


                    for (int row = 2; row <= ws.UsedRange.Rows.Count; ++row)//đọc row hiện có trong Excel
                    {
                        Range cell = ws.Range[$"C{row}"];
                        string cellValue = cell.Text;

                        if (email.Equals(cellValue))
                        {
                            Range cellMK = ws.Range[$"G{row}"];
                            cellMK.Value = tb_mk.Text;
                            wb.Save();
                            wb.Close();
                            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            dang_nhap dangnhap = new dang_nhap();
                            dangnhap.ShowDialog();
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nhập lại mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
