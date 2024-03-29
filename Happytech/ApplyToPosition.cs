﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happytech.Classes;

namespace Happytech
{
    public partial class ApplyToPosition : Form
    {
        Database db = new Database();
        Role[] roles; //Roles list

        private OpenFileDialog curriculumLocation = null;

        public ApplyToPosition()
        {
            InitializeComponent();

            roles = db.ListRoles(); //Gets the available roles

            //Sorts the array instead of being the comboboxes sorting
            Array.Sort(roles, (aRole, bRole) => string.Compare(aRole.RoleName, bRole.RoleName, StringComparison.Ordinal));

            foreach (Role role in roles) cbRole.Items.Add(role.RoleName); //Adds the roles to the combobox
        }

        private void btnSelectFile_Click(object sender, EventArgs e) => fileDialogForm(); //Opens Windows file dialog

        private void fileDialogForm()
        {
            //definition of the file dialog
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = @"PDF (.pdf)|*.pdf|Word Files (.docx ,.doc)|*.docx;*.doc|All Files|*.docx;*.doc;*.pdf",
                Title = "Select your curriculum file",
                Multiselect = false
            };

            //In case there is some file selected
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    curriculumLocation = dialog; //Saves in global variable
                    lblFileName.Text = dialog.SafeFileName; //Displays file name
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Security error.\n\nError message: {e.Message}\n\n" +
                                    $"Details:\n\n{e.StackTrace}");
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblErrorName.Visible = CheckError(tbName); //Checks for errors in Name
            lblErrorEmail.Visible = CheckError(tbEmail); //Checks for errors in Email
            lblErrorPosition.Visible = SelectedRole(); //Checks if there is any role selected
            lblErrorCurriculum.Visible = curriculumLocation == null || !File.Exists(curriculumLocation.FileName); //Checks if there is file and if exists

            bool existsErrors = VisibleChanged(); //Validates that everything is valid

            if (!existsErrors) //If there is no errors
            {
                lblErrorSubmit.Visible = !db.ApplyToPosition(tbName.Text, tbEmail.Text, roles[cbRole.SelectedIndex].RoleId, SaveCV()); //Tries to save in the database and save the file in the file explorer

                if (!lblErrorSubmit.Visible) //If there is no errors submitting it will reset the page
                {
                    tbName.Text = null;
                    tbEmail.Text = null;
                    cbRole.SelectedIndex = -1;
                    lblFileName.Text = null;
                }
            }
        }

        //Checks if there is an error in the textboxes
        private bool CheckError(object sender, EventArgs e = null)
        {
            TextBox txtbx = (TextBox)sender; //Sets the object as a textbox
            bool error;

            //Is empty?
            if (txtbx.Text.Trim().Length == 0) error = true; //Oopsy Daisy there is an error bruh
            else if (!txtbx.Text.Contains("@") && txtbx.Tag == "Email") error = true; //Hey, we need to contact you...
            else error = false; //No problemo boss

            return error;
        }

        //Checks if there is any selected role
        private bool SelectedRole() => cbRole.SelectedIndex == -1; //Error if nothing is selected

        private bool VisibleChanged()
        {
            if (lblErrorName.Visible || lblErrorEmail.Visible || lblErrorPosition.Visible || lblErrorCurriculum.Visible)
                return true;

            return false;
        }

        /// <summary>
        /// Saves the file in a specific folder in the application.
        /// </summary>
        /// <returns>File path or null.</returns>
        private string SaveCV()
        {
            //File name with a unique variable, GUID
            //Gets just the file name without extension
            //Adds the GUID to the end
            //Adds the extension
            string finalFileName = Path.GetFileNameWithoutExtension(curriculumLocation.SafeFileName) +
                                   Guid.NewGuid() +
                                   Path.GetExtension(curriculumLocation.SafeFileName);

            try
            {
                //Tries to copy the file to the specific location
                File.Copy(curriculumLocation.FileName, Directory.GetCurrentDirectory() + "\\cv\\" + finalFileName);

                return Path.GetFileNameWithoutExtension(finalFileName); //Returns file name without extension
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null; //If there is an error will return null
            }
        }
    }
}