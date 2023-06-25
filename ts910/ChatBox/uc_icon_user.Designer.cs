namespace ts910.ChatBox
{
    partial class uc_icon_user
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
            this.ava_user = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.icon_user = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lb_time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ava_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_user)).BeginInit();
            this.SuspendLayout();
            // 
            // ava_user
            // 
            this.ava_user.ImageRotate = 0F;
            this.ava_user.Location = new System.Drawing.Point(487, 11);
            this.ava_user.Name = "ava_user";
            this.ava_user.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ava_user.Size = new System.Drawing.Size(50, 50);
            this.ava_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ava_user.TabIndex = 3;
            this.ava_user.TabStop = false;
            // 
            // icon_user
            // 
            this.icon_user.ImageRotate = 0F;
            this.icon_user.Location = new System.Drawing.Point(364, 11);
            this.icon_user.Name = "icon_user";
            this.icon_user.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.icon_user.Size = new System.Drawing.Size(110, 110);
            this.icon_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_user.TabIndex = 4;
            this.icon_user.TabStop = false;
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(310, 103);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(48, 18);
            this.lb_time.TabIndex = 5;
            this.lb_time.Text = "17:00";
            // 
            // uc_icon_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.icon_user);
            this.Controls.Add(this.ava_user);
            this.Name = "uc_icon_user";
            this.Size = new System.Drawing.Size(546, 132);
            ((System.ComponentModel.ISupportInitialize)(this.ava_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox ava_user;
        private Guna.UI2.WinForms.Guna2CirclePictureBox icon_user;
        private System.Windows.Forms.Label lb_time;
    }
}
