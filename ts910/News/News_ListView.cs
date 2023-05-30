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

namespace ts910.News
{
    public partial class News_ListView : Form
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
        public News_ListView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public void AddItem(string title, string ndung, string anh)
        {
            flowLayoutPanel1.Controls.Add(new ts910.News.News_CardView()
            {
                cardnewsTitle = title,
                cardnewsNdung = ndung,
                tenAnh = anh,
                cardnewsImg = Image.FromFile("Resources/new" + anh + ".jpg"),
            });

        }

        private void News_ListView_Shown(object sender, EventArgs e)
        {
            AddItem("CÁC KÊNH THÔNG TIN HỖ TRỢ PHỤ HUYNH VÀ HỌC SINH SUỐT KỲ THI TUYỂN SINH 10",
                "Thầy Võ Thiện Cang - Trưởng phòng Phòng Khảo thí và Kiểm định Chất lượng Giáo dục Sở Giáo dục và Đào tạo TP. HCM chia sẻ các kênh thông tin hỗ trợ phụ huynh và học sinh suốt kỳ thi tuyển sinh 10",
                "1");

            AddItem("HỌC SINH CẦN CHUẨN BỊ GÌ ĐỂ THAM GIA KỲ THI TUYỂN SINH 10",
                "Thầy Võ Thiện Cang - Trưởng phòng Phòng Khảo thí và Kiểm định Chất lượng Giáo dục Sở Giáo dục và Đào tạo TP. HCM chia sẻ về việc học sinh cần chuẩn bị gì để tham gia kỳ thi tuyển sinh 10",
                "2");

            AddItem("NHỮNG ĐIỂM CẦN CHÚ Ý TRONG CÔNG TÁC TUYỂN SINH 10",
                "Thầy Võ Thiện Cang - Trưởng phòng Phòng Khảo thí và Kiểm định Chất lượng Giáo dục Sở Giáo dục và Đào tạo TP. HCM chia sẻ những điểm cần chú ý trong công tác tuyển sinh 10",
                "3");
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
