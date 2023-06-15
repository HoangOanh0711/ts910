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

        public Result(string sum, int type, int subject)
        {
            InitializeComponent();
            this.sum = sum;
            this.type = type;
            this.subject = subject;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.thpt-lehongphong-tphcm.edu.vn/");
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
                Range address = ws.Range[$"H{row}"];
                Range year = ws.Range[$"K{row}"];
                Range studentNumber = ws.Range[$"M{row}"];
                Range nv1 = ws.Range[$"O{row}"];
                Range nv2 = ws.Range[$"P{row}"];
                Range nv3 = ws.Range[$"Q{row}"];

                AddResultItem(row - 3, schoolName.Text, address.Text, year.Text, studentNumber.Text, nv1.Text, nv2.Text, nv3.Text);

            }
        }

        private void AddResultItem (int index, string schoolName, string address, string year, string studentNumber, string nv1, string nv2, string nv3)
        {
            flowLayoutPanel1.Controls.Add(new ResultItem()
            {
                index = index,
                schoolName = schoolName,
                address = address,
                year = year,
                studentNumber = studentNumber,
                nv1 = nv1,
                nv2 = nv2,
                nv3 = nv3
            });
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
