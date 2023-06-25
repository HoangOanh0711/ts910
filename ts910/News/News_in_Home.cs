using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ts910.News
{
    public partial class News_in_Home : UserControl
    {
        public event EventHandler Click;

        UserInfo userInfo;

        public News_in_Home(UserInfo userInfo)
        {
            InitializeComponent();
            setSize();
            this.userInfo = userInfo;
        }

        private void setSize()
        {
            label1.Location = new System.Drawing.Point(156, 10);
            label2.Location = new System.Drawing.Point(330, 530);

            panel_tintuc.Location = new System.Drawing.Point(3, 40);
            panel_tintuc.Size = new System.Drawing.Size(457, 459);

            uc_card_new11.Location = new System.Drawing.Point(4, 6);
            uc_card_new21.Location = new System.Drawing.Point(426, 6);
            uc_card_new31.Location = new System.Drawing.Point(848, 6);

            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //this.ParentForm?.Hide();
            //Click?.Invoke(this, e);
            News_ListView new_ListView = new News_ListView(userInfo);
            new_ListView.ShowDialog();
        }
    }
}
