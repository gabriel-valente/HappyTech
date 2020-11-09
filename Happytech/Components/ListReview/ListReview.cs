﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Happytech.Components.ListReview
{
    public partial class ListReview : UserControl
    {
        Database db = new Database();

        public ListReview()
        {
            InitializeComponent();
            FlowLayout.HorizontalScroll.Visible = false;
        }

        public void RefreshList(int dropdownIndex) 
        {
            // Delete previous list
            FlowLayout.Controls.Clear();

            // Populate the list and assign the replyID as the name of the control
            switch (dropdownIndex)
            {
                // All Applications
                case 0:
                    var allApplications = db.FetchApplications();
                    foreach (DataRow application in allApplications.Rows)
                    {
                        var item = new ItemReview(int.Parse(application["ApplicationID"].ToString()));
                        FlowLayout.Controls.Add(item);
                    }
                    break;
                // New Applications
                case 1:
                    var newApplications = db.FetchNewApplications();
                    foreach (DataRow application in newApplications.Rows)
                    {
                        var item = new ItemReview(int.Parse(application["ApplicationID"].ToString()));
                        FlowLayout.Controls.Add(item);
                    }
                    break;
                // Replied Applications
                case 2:
                    var repliedApplications = db.FetchRepliedApplications();
                    foreach (DataRow application in repliedApplications.Rows)
                    {
                        var item = new ItemReview(int.Parse(application["ApplicationID"].ToString()));
                        FlowLayout.Controls.Add(item);
                    }
                    break;
            }
        }
    }
}
