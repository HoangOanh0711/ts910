﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ts910
{
    public partial class History : Form
    { 
        UserInfo UserInfo;
        public History(UserInfo userInfo)
        {
            InitializeComponent();
            this.UserInfo = userInfo;
            label8.Text = userInfo.Hoten;
        }
    }
}