﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happytech.Pages
{
    public partial class ViewApplications : UserControl
    {
        public ViewApplications()
        {
            InitializeComponent();
        }

        private void backHome(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new Home());
        }
    }
}
