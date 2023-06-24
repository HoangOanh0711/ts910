using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel.Application;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ts910
{
    public partial class doi_thong_tin : Form
    {
        UserInfo userInfo;
        string filePath;

        public doi_thong_tin(UserInfo userInfo)
        {
            InitializeComponent();

            setSize();

            this.userInfo = userInfo;

            tb_hoten.Text = userInfo.Hoten;
            tb_email.Text = userInfo.Email;
            tb_sdt.Text = userInfo.Sdt;
            tb_diachi.Text = userInfo.DiaChi;
            pb_ava.Image = Image.FromFile(userInfo.Ava);

        }

        private void setSize()
        {
            this.Size = new System.Drawing.Size(580, 840);

            tb_hoten.Location = new System.Drawing.Point(165, 266);
            tb_hoten.Size = new System.Drawing.Size(367, 50);

            tb_email.Location = new System.Drawing.Point(165, 326);
            tb_email.Size = new System.Drawing.Size(367, 50);

            tb_sdt.Location = new System.Drawing.Point(165, 386);
            tb_sdt.Size = new System.Drawing.Size(367, 50);

            tb_diachi.Location = new System.Drawing.Point(165, 446);
            tb_diachi.Size = new System.Drawing.Size(367, 50);

            label2.Location = new System.Drawing.Point(20, 574);
            label3.Location = new System.Drawing.Point(46, 283);
            label4.Location = new System.Drawing.Point(85, 341);
            label5.Location = new System.Drawing.Point(12, 400);
            label6.Location = new System.Drawing.Point(71, 459);

            tb_mk.Location = new System.Drawing.Point(24, 617);
            tb_mk.Size = new System.Drawing.Size(508, 50);

            tb_mkMoi.Location = new System.Drawing.Point(24, 677);
            tb_mkMoi.Size = new System.Drawing.Size(508, 50);

            pb_ava.Location = new System.Drawing.Point(207, 82);
            pb_ava.Size = new System.Drawing.Size(130, 130);

            btn_changeImg.Location = new System.Drawing.Point(297, 183);
            btn_changeImg.Size = new System.Drawing.Size(40, 40);

            btn_doithongtin.Location = new System.Drawing.Point(129, 813);
            btn_doithongtin.Size = new System.Drawing.Size(312, 63);

        }

        private void btn_changeImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filePath = openFileDialog1.FileName;
            pb_ava.Image = Image.FromFile(filePath);
        }

        private void btn_doithongtin_Click(object sender, EventArgs e)
        {
            if (tb_hoten.Text == "" || tb_email.Text == "" || tb_sdt.Text == "" || tb_diachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                        if (tb_email.Text.Equals(cellValue))
                        {
                            ws.Range[$"B{row}"].Value = tb_hoten.Text;
                            ws.Range[$"D{row}"].Value = tb_sdt.Text;
                            ws.Range[$"E{row}"].Value = tb_diachi.Text;
                            userInfo.Email = tb_email.Text;
                            userInfo.Hoten = tb_hoten.Text;
                            userInfo.Sdt = tb_sdt.Text;

                            if (tb_mk.Text != "")
                            {
                                ws.Range[$"G{row}"].Value = tb_mk.Text;
                            }

                            if (filePath != null)
                            {
                                ws.Range[$"F{row}"].Value = filePath;
                                userInfo.Ava = filePath;
                            }

                            wb.Save();
                            wb.Close();

                            MessageBox.Show("Đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
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
            Home home = new Home(userInfo);
            home.ShowDialog();
            this.Close();

        }
    }
}
