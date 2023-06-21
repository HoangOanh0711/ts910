using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel.Application;
using System.Reflection;
using static System.Windows.Forms.LinkLabel;
using Microsoft.Office.Interop.Excel;

namespace ts910
{
    public partial class dang_ky : Form
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
        public dang_ky()
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
            if (tb_email.Text == "" || tb_hoten.Text == "" || tb_diachi.Text == "" || tb_sdt.Text == "" || tb_matkhau.Text == "" || tb_nhaplaimk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (tb_matkhau.Text == tb_nhaplaimk.Text)
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
                            MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            wb.Close();
                            return;
                        }
                    }

                    int id = ws.UsedRange.Rows.Count + 1;
                    Range cells = ws.Range[$"A{id}:G{id}"];
                    string[] things = { $"{id}", tb_hoten.Text, tb_email.Text, tb_sdt.Text,tb_diachi.Text, "Resources/user.png", tb_matkhau.Text };
                    cells.set_Value(XlRangeValueDataType.xlRangeValueDefault, things);
                    wb.Save();
                    wb.Close();
                    MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    dang_nhap dangnhap = new dang_nhap();
                    dangnhap.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nhập lại mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            dang_nhap dangnhap = new dang_nhap();
            dangnhap.ShowDialog();
            this.Close();
        }

        void readExcel(string filepath)
        {

            Excel excel = new Excel();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filepath);
            ws = wb.Worksheets["Tài khoản"];

            /*//đọc 1 ô
            //Range cell = ws.Cells[1, 1];
            Range cell = ws.Range["A1"];
            string cellValue = cell.Value;
            MessageBox.Show(cellValue);*/

            /*//đọc 1 cột
            Range cell = ws.Range["A1:A3"];
            foreach(string Result in cell.Value)
            {
                MessageBox.Show(Result);
            }*/

            wb.Close();
        }

        void writeExcel(string filePath)
        {
            Excel excel = new Excel();
            Workbook wb = excel.Workbooks.Open(filePath);
            Worksheet ws = wb.Worksheets[1];

            // Reading and wrtiting to one cell
            //Range cell = ws.Cells[1, 3];      // Less human friendly way
            Range cell = ws.Range["C4"];
            cell.Value = "Pizza";

            // Writing to a whole row or column
            Range cells = ws.Range["C5:F5"];
            string[] things = { "WOW!", "Hamburger", "Cars", "Trees" };
            cells.set_Value(XlRangeValueDataType.xlRangeValueDefault, things);

            wb.Save();
            //wb.SaveAs(filePath);      // If you want to save it with another name or in another folder
            wb.Close();
        }

        private void tb_hoten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
