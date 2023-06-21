namespace ts910.ChatBox
{
    partial class uc_chat_user
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
            this.tb_user = new Guna.UI2.WinForms.Guna2TextBox();
            this.ava_user = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ava_user)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.AutoSize = true;
            this.tb_user.BorderColor = System.Drawing.Color.Transparent;
            this.tb_user.BorderRadius = 20;
            this.tb_user.BorderThickness = 0;
            this.tb_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_user.DefaultText = "abc";
            this.tb_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_user.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(213)))));
            this.tb_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_user.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.ForeColor = System.Drawing.Color.DimGray;
            this.tb_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_user.Location = new System.Drawing.Point(39, 11);
            this.tb_user.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_user.MaximumSize = new System.Drawing.Size(440, 0);
            this.tb_user.MinimumSize = new System.Drawing.Size(0, 50);
            this.tb_user.Name = "tb_user";
            this.tb_user.PasswordChar = '\0';
            this.tb_user.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.tb_user.PlaceholderText = "";
            this.tb_user.ReadOnly = true;
            this.tb_user.SelectedText = "";
            this.tb_user.Size = new System.Drawing.Size(440, 50);
            this.tb_user.TabIndex = 3;
            this.tb_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ava_user
            // 
            this.ava_user.ImageRotate = 0F;
            this.ava_user.Location = new System.Drawing.Point(487, 11);
            this.ava_user.Name = "ava_user";
            this.ava_user.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ava_user.Size = new System.Drawing.Size(50, 50);
            this.ava_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ava_user.TabIndex = 2;
            this.ava_user.TabStop = false;
            // 
            // uc_chat_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.ava_user);
            this.MinimumSize = new System.Drawing.Size(546, 75);
            this.Name = "uc_chat_user";
            this.Size = new System.Drawing.Size(546, 75);
            ((System.ComponentModel.ISupportInitialize)(this.ava_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tb_user;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ava_user;
    }
}
