namespace ts910.ChatBox
{
    partial class ChatBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back_chat = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_send = new System.Windows.Forms.PictureBox();
            this.tb_nhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flow_chat = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back_chat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_send)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "TƯ VẤN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_back_chat);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 64);
            this.panel1.TabIndex = 6;
            // 
            // btn_back_chat
            // 
            this.btn_back_chat.Image = global::ts910.Properties.Resources.back;
            this.btn_back_chat.ImageRotate = 0F;
            this.btn_back_chat.Location = new System.Drawing.Point(14, 16);
            this.btn_back_chat.Name = "btn_back_chat";
            this.btn_back_chat.Size = new System.Drawing.Size(30, 30);
            this.btn_back_chat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_back_chat.TabIndex = 4;
            this.btn_back_chat.TabStop = false;
            this.btn_back_chat.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(39, -155);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_send);
            this.panel2.Controls.Add(this.tb_nhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 766);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 74);
            this.panel2.TabIndex = 8;
            // 
            // btn_send
            // 
            this.btn_send.Image = global::ts910.Properties.Resources.send;
            this.btn_send.Location = new System.Drawing.Point(494, 13);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(45, 45);
            this.btn_send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_send.TabIndex = 1;
            this.btn_send.TabStop = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tb_nhap
            // 
            this.tb_nhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_nhap.DefaultText = "";
            this.tb_nhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_nhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_nhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_nhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_nhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_nhap.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_nhap.Location = new System.Drawing.Point(6, 8);
            this.tb_nhap.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_nhap.Name = "tb_nhap";
            this.tb_nhap.PasswordChar = '\0';
            this.tb_nhap.PlaceholderText = "";
            this.tb_nhap.SelectedText = "";
            this.tb_nhap.Size = new System.Drawing.Size(483, 55);
            this.tb_nhap.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.flow_chat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(546, 702);
            this.panel3.TabIndex = 9;
            // 
            // flow_chat
            // 
            this.flow_chat.BackColor = System.Drawing.Color.Transparent;
            this.flow_chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_chat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_chat.Location = new System.Drawing.Point(0, 0);
            this.flow_chat.Name = "flow_chat";
            this.flow_chat.Size = new System.Drawing.Size(546, 702);
            this.flow_chat.TabIndex = 0;
            // 
            // ChatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(193)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(546, 840);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChatBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatBox";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_back_chat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_send)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox btn_back_chat;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flow_chat;
        private Guna.UI2.WinForms.Guna2TextBox tb_nhap;
        private System.Windows.Forms.PictureBox btn_send;
    }
}