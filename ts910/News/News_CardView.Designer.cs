namespace ts910.News
{
    partial class News_CardView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cardnews_ndung = new System.Windows.Forms.Label();
            this.cardnews_title = new System.Windows.Forms.Label();
            this.cardnews_img = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardnews_img)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.cardnews_ndung);
            this.guna2Panel1.Controls.Add(this.cardnews_title);
            this.guna2Panel1.Controls.Add(this.cardnews_img);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(8, 5);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(545, 134);
            this.guna2Panel1.TabIndex = 1;
            // 
            // cardnews_ndung
            // 
            this.cardnews_ndung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardnews_ndung.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardnews_ndung.Location = new System.Drawing.Point(138, 54);
            this.cardnews_ndung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cardnews_ndung.Name = "cardnews_ndung";
            this.cardnews_ndung.Size = new System.Drawing.Size(403, 74);
            this.cardnews_ndung.TabIndex = 4;
            this.cardnews_ndung.Text = "Thầy Võ Thiện Cang - Trưởng phòng Phòng Khảo thí và Kiểm định Chất lượng Giáo dục" +
    " Sở Giáo dục và Đào tạo TP. HCM chia sẻ các kênh thông tin hỗ trợ phụ huynh và h" +
    "ọc sinh suốt kỳ thi tuyển sinh 10";
            this.cardnews_ndung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardnews_title
            // 
            this.cardnews_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardnews_title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardnews_title.Location = new System.Drawing.Point(138, 6);
            this.cardnews_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cardnews_title.Name = "cardnews_title";
            this.cardnews_title.Size = new System.Drawing.Size(403, 48);
            this.cardnews_title.TabIndex = 3;
            this.cardnews_title.Text = "CÁC KÊNH THÔNG TIN HỖ TRỢ PHỤ HUYNH VÀ HỌC SINH SUỐT KỲ THI TUYỂN SINH 10";
            this.cardnews_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardnews_img
            // 
            this.cardnews_img.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cardnews_img.ImageRotate = 0F;
            this.cardnews_img.Location = new System.Drawing.Point(2, 2);
            this.cardnews_img.Margin = new System.Windows.Forms.Padding(2);
            this.cardnews_img.Name = "cardnews_img";
            this.cardnews_img.Size = new System.Drawing.Size(130, 130);
            this.cardnews_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardnews_img.TabIndex = 0;
            this.cardnews_img.TabStop = false;
            // 
            // News_CardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "News_CardView";
            this.Size = new System.Drawing.Size(562, 150);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cardnews_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label cardnews_ndung;
        private System.Windows.Forms.Label cardnews_title;
        private Guna.UI2.WinForms.Guna2PictureBox cardnews_img;
    }
}
