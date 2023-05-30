using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ts910.News
{
    public partial class News_in_Home : UserControl
    {
        public event EventHandler Click;

        public News_in_Home()
        {
            InitializeComponent();
        }

        public int soThuTu = 0;
        public string[] listTitle = new string[3] { "CÁC KÊNH THÔNG TIN HỖ TRỢ PHỤ HUYNH VÀ HỌC SINH SUỐT KỲ THI TUYỂN SINH 10",
                                                    "HỌC SINH CẦN CHUẨN BỊ GÌ ĐỂ THAM GIA KỲ THI TUYỂN SINH 10",
                                                    "NHỮNG ĐIỂM CẦN CHÚ Ý TRONG CÔNG TÁC TUYỂN SINH 10" };

        public string[] listNdung = new string[3] { "Thầy Võ Thiện Cang - Trưởng phòng Phòng Khảo thí và Kiểm định Chất lượng Giáo dục Sở Giáo dục và Đào tạo TP. HCM chia sẻ các kênh thông tin hỗ trợ phụ huynh và học sinh suốt kỳ thi tuyển sinh 10",
                                                    "Thầy Võ Thiện Cang - Trưởng phòng Phòng Khảo thí và Kiểm định Chất lượng Giáo dục Sở Giáo dục và Đào tạo TP. HCM chia sẻ về việc học sinh cần chuẩn bị gì để tham gia kỳ thi tuyển sinh 10",
                                                    "Thầy Võ Thiện Cang - Trưởng phòng Phòng Khảo thí và Kiểm định Chất lượng Giáo dục Sở Giáo dục và Đào tạo TP. HCM chia sẻ những điểm cần chú ý trong công tác tuyển sinh 10" };

        private void LoadNextInfo()
        {
            timer1.Start();
            soThuTu++;
            if (soThuTu == 3)
            {
                soThuTu = 1;
            }
            img_news.ImageLocation = string.Format(@"G:\Oanhhh\c#\ts910\ts910\Resources\new" + (soThuTu + 1) + ".jpg");
            label3.Text = listTitle[soThuTu];
            label4.Text = listNdung[soThuTu];

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextInfo();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.ParentForm?.Hide();
            Click?.Invoke(this, e);
            News_ListView new_ListView = new News_ListView();
            new_ListView.ShowDialog();
        }
    }
}
