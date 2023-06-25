namespace ts910.ChatBox
{
    partial class uc_icon_admin
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
            this.ava_admin = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.icon_admin = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lb_time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ava_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // ava_admin
            // 
            this.ava_admin.ImageRotate = 0F;
            this.ava_admin.Location = new System.Drawing.Point(9, 11);
            this.ava_admin.Name = "ava_admin";
            this.ava_admin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ava_admin.Size = new System.Drawing.Size(50, 50);
            this.ava_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ava_admin.TabIndex = 1;
            this.ava_admin.TabStop = false;
            // 
            // icon_admin
            // 
            this.icon_admin.ImageRotate = 0F;
            this.icon_admin.Location = new System.Drawing.Point(65, 11);
            this.icon_admin.Name = "icon_admin";
            this.icon_admin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.icon_admin.Size = new System.Drawing.Size(110, 110);
            this.icon_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_admin.TabIndex = 5;
            this.icon_admin.TabStop = false;
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(181, 103);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(48, 18);
            this.lb_time.TabIndex = 6;
            this.lb_time.Text = "17:00";
            // 
            // uc_icon_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.icon_admin);
            this.Controls.Add(this.ava_admin);
            this.Name = "uc_icon_admin";
            this.Size = new System.Drawing.Size(546, 132);
            ((System.ComponentModel.ISupportInitialize)(this.ava_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox ava_admin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox icon_admin;
        private System.Windows.Forms.Label lb_time;
    }
}
