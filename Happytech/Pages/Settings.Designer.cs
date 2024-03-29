﻿namespace Happytech.Pages
{
    partial class Settings
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.lblErrorInsertingUser = new System.Windows.Forms.Label();
            this.lblSelectRoleError = new System.Windows.Forms.Label();
            this.lblErrorInsertingRole = new System.Windows.Forms.Label();
            this.lblNewRoleError = new System.Windows.Forms.Label();
            this.btnSaveRole = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRoleName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRemoveRoleError = new System.Windows.Forms.Label();
            this.lblErrorRemovingRole = new System.Windows.Forms.Label();
            this.btnRemoveRole = new System.Windows.Forms.Button();
            this.cbRemoveRole = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lstEmployees = new Happytech.Components.ListComponent.List();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            this.btnBack.Location = new System.Drawing.Point(663, 500);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 45);
            this.btnBack.TabIndex = 16;
            this.btnBack.Tag = "";
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(326, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "New Employee";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbUsername.ForeColor = System.Drawing.Color.White;
            this.tbUsername.Location = new System.Drawing.Point(331, 70);
            this.tbUsername.MaxLength = 256;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(215, 26);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Tag = "Username";
            this.tbUsername.Leave += new System.EventHandler(this.CheckAvailability);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(327, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(327, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Role";
            // 
            // cbRole
            // 
            this.cbRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbRole.ForeColor = System.Drawing.Color.White;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(331, 205);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(215, 27);
            this.cbRole.TabIndex = 24;
            this.cbRole.Tag = "Role";
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSaveUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            this.btnSaveUser.Location = new System.Drawing.Point(331, 269);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(215, 27);
            this.btnSaveUser.TabIndex = 25;
            this.btnSaveUser.Tag = "";
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.UseVisualStyleBackColor = false;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.AutoSize = true;
            this.lblUsernameError.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsernameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblUsernameError.Location = new System.Drawing.Point(327, 99);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(179, 19);
            this.lblUsernameError.TabIndex = 26;
            this.lblUsernameError.Text = "Errors for username textbox";
            this.lblUsernameError.Visible = false;
            // 
            // lblErrorInsertingUser
            // 
            this.lblErrorInsertingUser.AutoSize = true;
            this.lblErrorInsertingUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblErrorInsertingUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblErrorInsertingUser.Location = new System.Drawing.Point(327, 299);
            this.lblErrorInsertingUser.Name = "lblErrorInsertingUser";
            this.lblErrorInsertingUser.Size = new System.Drawing.Size(196, 19);
            this.lblErrorInsertingUser.TabIndex = 27;
            this.lblErrorInsertingUser.Text = "Oppsy Daisy user not addedsy";
            this.lblErrorInsertingUser.Visible = false;
            // 
            // lblSelectRoleError
            // 
            this.lblSelectRoleError.AutoSize = true;
            this.lblSelectRoleError.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSelectRoleError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblSelectRoleError.Location = new System.Drawing.Point(327, 235);
            this.lblSelectRoleError.Name = "lblSelectRoleError";
            this.lblSelectRoleError.Size = new System.Drawing.Size(123, 19);
            this.lblSelectRoleError.TabIndex = 28;
            this.lblSelectRoleError.Text = "Please select a role";
            this.lblSelectRoleError.Visible = false;
            // 
            // lblErrorInsertingRole
            // 
            this.lblErrorInsertingRole.AutoSize = true;
            this.lblErrorInsertingRole.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblErrorInsertingRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblErrorInsertingRole.Location = new System.Drawing.Point(585, 178);
            this.lblErrorInsertingRole.Name = "lblErrorInsertingRole";
            this.lblErrorInsertingRole.Size = new System.Drawing.Size(193, 19);
            this.lblErrorInsertingRole.TabIndex = 34;
            this.lblErrorInsertingRole.Text = "Oppsy Daisy role not addedsy";
            this.lblErrorInsertingRole.Visible = false;
            // 
            // lblNewRoleError
            // 
            this.lblNewRoleError.AutoSize = true;
            this.lblNewRoleError.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNewRoleError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblNewRoleError.Location = new System.Drawing.Point(585, 99);
            this.lblNewRoleError.Name = "lblNewRoleError";
            this.lblNewRoleError.Size = new System.Drawing.Size(142, 19);
            this.lblNewRoleError.TabIndex = 33;
            this.lblNewRoleError.Text = "Errors for role textbox";
            this.lblNewRoleError.Visible = false;
            // 
            // btnSaveRole
            // 
            this.btnSaveRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.btnSaveRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRole.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSaveRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            this.btnSaveRole.Location = new System.Drawing.Point(589, 148);
            this.btnSaveRole.Name = "btnSaveRole";
            this.btnSaveRole.Size = new System.Drawing.Size(215, 27);
            this.btnSaveRole.TabIndex = 32;
            this.btnSaveRole.Tag = "";
            this.btnSaveRole.Text = "Save";
            this.btnSaveRole.UseVisualStyleBackColor = false;
            this.btnSaveRole.Click += new System.EventHandler(this.btnSaveRole_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(585, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Role";
            // 
            // tbRoleName
            // 
            this.tbRoleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.tbRoleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRoleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRoleName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbRoleName.ForeColor = System.Drawing.Color.White;
            this.tbRoleName.Location = new System.Drawing.Point(589, 70);
            this.tbRoleName.MaxLength = 256;
            this.tbRoleName.Name = "tbRoleName";
            this.tbRoleName.Size = new System.Drawing.Size(215, 26);
            this.tbRoleName.TabIndex = 29;
            this.tbRoleName.Tag = "Role";
            this.tbRoleName.Leave += new System.EventHandler(this.CheckAvailability);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.Location = new System.Drawing.Point(584, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 28);
            this.label8.TabIndex = 30;
            this.label8.Text = "New Role";
            // 
            // lblRemoveRoleError
            // 
            this.lblRemoveRoleError.AutoSize = true;
            this.lblRemoveRoleError.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRemoveRoleError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblRemoveRoleError.Location = new System.Drawing.Point(327, 425);
            this.lblRemoveRoleError.Name = "lblRemoveRoleError";
            this.lblRemoveRoleError.Size = new System.Drawing.Size(123, 19);
            this.lblRemoveRoleError.TabIndex = 40;
            this.lblRemoveRoleError.Text = "Please select a role";
            this.lblRemoveRoleError.Visible = false;
            // 
            // lblErrorRemovingRole
            // 
            this.lblErrorRemovingRole.AutoSize = true;
            this.lblErrorRemovingRole.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblErrorRemovingRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblErrorRemovingRole.Location = new System.Drawing.Point(327, 487);
            this.lblErrorRemovingRole.Name = "lblErrorRemovingRole";
            this.lblErrorRemovingRole.Size = new System.Drawing.Size(229, 19);
            this.lblErrorRemovingRole.TabIndex = 39;
            this.lblErrorRemovingRole.Text = "This role is assigned to an employee";
            this.lblErrorRemovingRole.Visible = false;
            // 
            // btnRemoveRole
            // 
            this.btnRemoveRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.btnRemoveRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRole.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRemoveRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            this.btnRemoveRole.Location = new System.Drawing.Point(331, 457);
            this.btnRemoveRole.Name = "btnRemoveRole";
            this.btnRemoveRole.Size = new System.Drawing.Size(215, 27);
            this.btnRemoveRole.TabIndex = 38;
            this.btnRemoveRole.Tag = "";
            this.btnRemoveRole.Text = "Save";
            this.btnRemoveRole.UseVisualStyleBackColor = false;
            this.btnRemoveRole.Click += new System.EventHandler(this.btnRemoveRole_Click);
            // 
            // cbRemoveRole
            // 
            this.cbRemoveRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.cbRemoveRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemoveRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRemoveRole.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbRemoveRole.ForeColor = System.Drawing.Color.White;
            this.cbRemoveRole.FormattingEnabled = true;
            this.cbRemoveRole.Location = new System.Drawing.Point(331, 395);
            this.cbRemoveRole.Name = "cbRemoveRole";
            this.cbRemoveRole.Size = new System.Drawing.Size(215, 27);
            this.cbRemoveRole.TabIndex = 37;
            this.cbRemoveRole.Tag = "Role";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.Location = new System.Drawing.Point(327, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "Role";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.Location = new System.Drawing.Point(326, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 28);
            this.label10.TabIndex = 35;
            this.label10.Text = "Remove Role";
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(626, 48);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(108, 19);
            this.chkAdmin.TabIndex = 42;
            this.chkAdmin.Text = "Is administrator";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(327, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(331, 148);
            this.tbPassword.MaxLength = 256;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(215, 26);
            this.tbPassword.TabIndex = 43;
            this.tbPassword.Tag = "Password";
            // 
            // lstEmployees
            // 
            this.lstEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.lstEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstEmployees.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstEmployees.ForeColor = System.Drawing.Color.White;
            this.lstEmployees.Location = new System.Drawing.Point(15, 48);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(302, 513);
            this.lstEmployees.TabIndex = 41;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(this.lstEmployees);
            this.Controls.Add(this.lblRemoveRoleError);
            this.Controls.Add(this.lblErrorRemovingRole);
            this.Controls.Add(this.btnRemoveRole);
            this.Controls.Add(this.cbRemoveRole);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblErrorInsertingRole);
            this.Controls.Add(this.lblNewRoleError);
            this.Controls.Add(this.btnSaveRole);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbRoleName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSelectRoleError);
            this.Controls.Add(this.lblErrorInsertingUser);
            this.Controls.Add(this.lblUsernameError);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(869, 585);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.Label lblErrorInsertingUser;
        private System.Windows.Forms.Label lblSelectRoleError;
        private System.Windows.Forms.Label lblErrorInsertingRole;
        private System.Windows.Forms.Label lblNewRoleError;
        private System.Windows.Forms.Button btnSaveRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRoleName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRemoveRoleError;
        private System.Windows.Forms.Label lblErrorRemovingRole;
        private System.Windows.Forms.Button btnRemoveRole;
        private System.Windows.Forms.ComboBox cbRemoveRole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Components.ListComponent.List lstEmployees;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassword;
    }
}
