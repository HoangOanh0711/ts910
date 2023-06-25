using Microsoft.Office.Interop.Excel;
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
using ts910.Components;

using Excel = Microsoft.Office.Interop.Excel.Application;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ts910
{
    public partial class Result : Form
    {
        string sum;
        int type, subject;

        UserInfo userInfo;

        public Result(string sum, int type, int subject, UserInfo userInfo)
        {
            InitializeComponent();
            this.sum = sum;
            this.type = type;
            this.subject = subject;
            this.userInfo = userInfo;
            label9.Text = userInfo.Hoten;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Result_Load(object sender, EventArgs e)
        {
            if (type == 0) lb_type.Text = "TS10 thường";
            else if (type == 1) lb_type.Text = "TS10 chuyên";
            else lb_type.Text = "TS10 tích hợp";

            lb_sum.Text = "Tổng điểm xét tuyển: " + sum;

            flowLayoutPanel1.Controls.Clear();

            Excel excel = new Excel();
            Workbook wb = excel.Workbooks.Open(Program.filePathExcel);
            Worksheet ws;
            if (type == 0)
            {
                ws = wb.Worksheets["Trường thường"];
            }
            else if (type == 1)
            {
                if(subject == 0) ws = wb.Worksheets["Chuyên toán"];
                else ws = wb.Worksheets["Chuyên văn"];
            }
            else
            {
                ws = wb.Worksheets["Tích hợp"];
            }

            for (int row = 4; row <= ws.UsedRange.Rows.Count; ++row)//đọc row hiện có trong Excel
            {
                Range schoolName = ws.Range[$"B{row}"];
                Range weblink = ws.Range[$"Z{row}"];
                Range address = ws.Range[$"H{row}"];
                Range year = ws.Range[$"K{row}"];
                Range studentNumber = ws.Range[$"M{row}"];
                Range nv1 = ws.Range[$"O{row}"];
                Range nv2 = ws.Range[$"P{row}"];
                Range nv3 = ws.Range[$"Q{row}"];

                AddResultItem(row - 3, schoolName.Text, weblink.Text, address.Text, year.Text, studentNumber.Text, nv1.Text, nv2.Text, nv3.Text);

            }
        }

        private void AddResultItem (int index, string schoolName, string weblink, string address, string year, string studentNumber, string nv1, string nv2, string nv3)
        {
            flowLayoutPanel1.Controls.Add(new ResultItem()
            {
                index = index,
                schoolName = schoolName,
                weblink = weblink,
                address = address,
                year = year,
                studentNumber = studentNumber,
                nv1 = nv1,
                nv2 = nv2,
                nv3 = nv3
            });
        }



        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            History history = new History(userInfo);
            history.Show();
            this.Close();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
