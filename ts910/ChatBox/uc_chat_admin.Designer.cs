namespace ts910.ChatBox
{
    partial class uc_chat_admin
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
            this.tb_admin = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ava_admin)).BeginInit();
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
            this.ava_admin.TabIndex = 0;
            this.ava_admin.TabStop = false;
            // 
            // tb_admin
            // 
            this.tb_admin.AcceptsReturn = true;
            this.tb_admin.AutoSize = true;
            this.tb_admin.BackColor = System.Drawing.Color.Transparent;
            this.tb_admin.BorderColor = System.Drawing.Color.Transparent;
            this.tb_admin.BorderRadius = 20;
            this.tb_admin.BorderThickness = 0;
            this.tb_admin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_admin.DefaultText = "";
            this.tb_admin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_admin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_admin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_admin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_admin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.tb_admin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_admin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_admin.ForeColor = System.Drawing.Color.DimGray;
            this.tb_admin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_admin.Location = new System.Drawing.Point(67, 11);
            this.tb_admin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_admin.MaximumSize = new System.Drawing.Size(440, 0);
            this.tb_admin.MinimumSize = new System.Drawing.Size(0, 50);
            this.tb_admin.Multiline = true;
            this.tb_admin.Name = "tb_admin";
            this.tb_admin.PasswordChar = '\0';
            this.tb_admin.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.tb_admin.PlaceholderText = "";
            this.tb_admin.ReadOnly = true;
            this.tb_admin.SelectedText = "";
            this.tb_admin.Size = new System.Drawing.Size(440, 50);
            this.tb_admin.TabIndex = 1;
            // 
            // uc_chat_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tb_admin);
            this.Controls.Add(this.ava_admin);
            this.MinimumSize = new System.Drawing.Size(546, 75);
            this.Name = "uc_chat_admin";
            this.Size = new System.Drawing.Size(546, 75);
            ((System.ComponentModel.ISupportInitialize)(this.ava_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox ava_admin;
        private Guna.UI2.WinForms.Guna2TextBox tb_admin;
    }
}
