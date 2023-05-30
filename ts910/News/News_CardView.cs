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
    public partial class News_CardView : UserControl
    {
        public News_CardView()
        {
            InitializeComponent();
        }

        private string tenanh;
        public string tenAnh { get => tenanh; set => tenanh = value; }
        public string cardnewsNdung { get => cardnews_ndung.Text; set => cardnews_ndung.Text = value; }
        public string cardnewsTitle { get => cardnews_title.Text; set => cardnews_title.Text = value; }
        public Image cardnewsImg { get => cardnews_img.Image; set => cardnews_img.Image = value; }

    }
}
