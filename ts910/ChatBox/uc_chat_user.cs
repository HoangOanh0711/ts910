﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ts910.ChatBox
{
    public partial class uc_chat_user : UserControl
    {
        public uc_chat_user() { }
        public uc_chat_user(string text, string anh)
        {
            InitializeComponent();
            Text = text;
            Anh = Image.FromFile(anh);
        }
        public string Text { get => tb_user.Text; set => tb_user.Text = value; }
        public Image Anh { get => ava_user.Image; set => ava_user.Image = value; }


    }
}
