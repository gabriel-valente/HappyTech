﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happytech;
using HappyTech.Classes;

namespace HappyTech.Pages
{
    public partial class EditTemplates : UserControl
    {
        Database db = new Database();
        //y positions for the codes
        int[] codeYs = new int[5] { 55, 172, 286, 400, 514 };
        //y positions for the comments
        int[] commentYs = new int[5] { 93, 207, 321, 435, 549 };

        public EditTemplates()
        {
            InitializeComponent();
            List<Template> Templates = db.GetTemplateNames();

            foreach (Template template in Templates)
                cbSelectTemplate.Items.Insert(template.TemplateId, template.Name);
        }

        private void DisplayTemplate(object sender, EventArgs e)
        {
            //get the selected template info
            Template selectedTemplate = db.GetTemplateData(cbSelectTemplate.SelectedIndex);
            int noOfSections = selectedTemplate.Sections.Count;
            //remove the current tabs from the tab control
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tabControl1.Controls.Remove(tab);
            }
            //for each section in the template
            foreach (Section section in selectedTemplate.Sections)
            {
                //add a tab to the tab control
                TabPage tab = new TabPage();
                tab.BackColor = Color.FromArgb(39, 44, 74);
                tab.Text = section.Title;
                //filter out any spaces that may be in the section title to prevent errors using it as an object name
                tab.Name = section.Title.Replace(' ', '_');
                tab.AutoScroll = true;
                tab.AutoScrollMargin = new Size(10, 10);
                tabControl1.Controls.Add(tab);
                //add a textbox for section name
                //it's already the tab name but they might want to change it
                TextBox sectionName = new TextBox();
                sectionName.Text = section.Title;
                sectionName.Name = "sectionName";
                sectionName.Location = new Point(23, 19);
                tab.Controls.Add(sectionName);
                //for each comment
                foreach(Comment comment in section.Comments)
                {
                    //add a textbox for the code
                    TextBox code = new TextBox();
                    code.Text = comment.ShortName;
                    code.Name = comment.ShortName.Replace(' ', '_');
                    int pos = section.Comments.IndexOf(comment);
                    int y = codeYs[pos];
                    code.Location = new Point(23, y);
                    code.Size = new Size(145, 29);
                    tab.Controls.Add(code);
                    //add a textbox for the comment
                    TextBox commentBox = new TextBox();
                    commentBox.Text = comment.CommentText;
                    commentBox.Name = "Comment " + (section.Comments.IndexOf(comment) + 1);
                    y = commentYs[pos];
                    commentBox.Location = new Point(23, y);
                    commentBox.Size = new Size(889, 73);
                    commentBox.Multiline = true;
                    tab.Controls.Add(commentBox);
                }
            }
        }
    }
}