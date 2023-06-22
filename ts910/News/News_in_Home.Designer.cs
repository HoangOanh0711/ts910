namespace ts910.News
{
    partial class News_in_Home
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_tintuc = new Guna.UI2.WinForms.Guna2Panel();
            this.uc_card_new31 = new ts910.News.uc_card_new3();
            this.uc_card_new21 = new ts910.News.uc_card_new2();
            this.uc_card_new11 = new ts910.News.uc_card_new1();
            this.panel_tintuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 538);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Xem tất cả";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "TIN TỨC";
            // 
            // panel_tintuc
            // 
            this.panel_tintuc.AutoScroll = true;
            this.panel_tintuc.Controls.Add(this.uc_card_new31);
            this.panel_tintuc.Controls.Add(this.uc_card_new21);
            this.panel_tintuc.Controls.Add(this.uc_card_new11);
            this.panel_tintuc.Location = new System.Drawing.Point(3, 46);
            this.panel_tintuc.Name = "panel_tintuc";
            this.panel_tintuc.Size = new System.Drawing.Size(457, 459);
            this.panel_tintuc.TabIndex = 8;
            // 
            // uc_card_new31
            // 
            this.uc_card_new31.Location = new System.Drawing.Point(848, 6);
            this.uc_card_new31.Name = "uc_card_new31";
            this.uc_card_new31.Size = new System.Drawing.Size(416, 429);
            this.uc_card_new31.TabIndex = 5;
            // 
            // uc_card_new21
            // 
            this.uc_card_new21.Location = new System.Drawing.Point(426, 6);
            this.uc_card_new21.Name = "uc_card_new21";
            this.uc_card_new21.Size = new System.Drawing.Size(416, 429);
            this.uc_card_new21.TabIndex = 4;
            // 
            // uc_card_new11
            // 
            this.uc_card_new11.Location = new System.Drawing.Point(4, 6);
            this.uc_card_new11.Name = "uc_card_new11";
            this.uc_card_new11.Size = new System.Drawing.Size(416, 429);
            this.uc_card_new11.TabIndex = 3;
            // 
            // News_in_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_tintuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "News_in_Home";
            this.Size = new System.Drawing.Size(463, 570);
            this.panel_tintuc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel panel_tintuc;
        private uc_card_new1 uc_card_new11;
        private uc_card_new2 uc_card_new21;
        private uc_card_new3 uc_card_new31;
    }
}
