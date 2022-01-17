
namespace CRUDWithLoginExample.Forms
{
    partial class frmMain
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lstUsers = new System.Windows.Forms.ListView();
            this.btnPrintAllUsers = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.txtBoxEditName = new System.Windows.Forms.TextBox();
            this.txtBoxEditPassword = new System.Windows.Forms.TextBox();
            this.checkBoxEditIsAdmin = new System.Windows.Forms.CheckBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txtBoxDeleteUser = new System.Windows.Forms.TextBox();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblOldName = new System.Windows.Forms.Label();
            this.lblNewName = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtBoxNewName = new System.Windows.Forms.TextBox();
            this.txtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstUsers.GridLines = true;
            this.lstUsers.Location = new System.Drawing.Point(21, 119);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(318, 166);
            this.lstUsers.TabIndex = 3;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.Details;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged_1);
            // 
            // btnPrintAllUsers
            // 
            this.btnPrintAllUsers.Location = new System.Drawing.Point(21, 66);
            this.btnPrintAllUsers.Name = "btnPrintAllUsers";
            this.btnPrintAllUsers.Size = new System.Drawing.Size(94, 29);
            this.btnPrintAllUsers.TabIndex = 4;
            this.btnPrintAllUsers.Text = "Print All Users";
            this.btnPrintAllUsers.UseVisualStyleBackColor = true;
            this.btnPrintAllUsers.Click += new System.EventHandler(this.btnPrintAllUsers_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(245, 66);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(94, 29);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(502, 12);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(94, 29);
            this.btnEditUser.TabIndex = 6;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // txtBoxEditName
            // 
            this.txtBoxEditName.Location = new System.Drawing.Point(502, 68);
            this.txtBoxEditName.Name = "txtBoxEditName";
            this.txtBoxEditName.Size = new System.Drawing.Size(125, 27);
            this.txtBoxEditName.TabIndex = 7;
            // 
            // txtBoxEditPassword
            // 
            this.txtBoxEditPassword.Location = new System.Drawing.Point(502, 119);
            this.txtBoxEditPassword.Name = "txtBoxEditPassword";
            this.txtBoxEditPassword.Size = new System.Drawing.Size(125, 27);
            this.txtBoxEditPassword.TabIndex = 8;
            // 
            // checkBoxEditIsAdmin
            // 
            this.checkBoxEditIsAdmin.AutoSize = true;
            this.checkBoxEditIsAdmin.Location = new System.Drawing.Point(629, 17);
            this.checkBoxEditIsAdmin.Name = "checkBoxEditIsAdmin";
            this.checkBoxEditIsAdmin.Size = new System.Drawing.Size(75, 24);
            this.checkBoxEditIsAdmin.TabIndex = 9;
            this.checkBoxEditIsAdmin.Text = "Admin";
            this.checkBoxEditIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(502, 212);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteUser.TabIndex = 10;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // txtBoxDeleteUser
            // 
            this.txtBoxDeleteUser.Location = new System.Drawing.Point(643, 212);
            this.txtBoxDeleteUser.Name = "txtBoxDeleteUser";
            this.txtBoxDeleteUser.Size = new System.Drawing.Size(125, 27);
            this.txtBoxDeleteUser.TabIndex = 11;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(643, 382);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(125, 29);
            this.btnSignOut.TabIndex = 12;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblOldName
            // 
            this.lblOldName.AutoSize = true;
            this.lblOldName.Location = new System.Drawing.Point(502, 44);
            this.lblOldName.Name = "lblOldName";
            this.lblOldName.Size = new System.Drawing.Size(77, 20);
            this.lblOldName.TabIndex = 13;
            this.lblOldName.Text = "Old Name";
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(643, 44);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(83, 20);
            this.lblNewName.TabIndex = 14;
            this.lblNewName.Text = "New Name";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(502, 96);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(98, 20);
            this.lblOldPassword.TabIndex = 15;
            this.lblOldPassword.Text = "Old Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(643, 98);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(104, 20);
            this.lblNewPassword.TabIndex = 16;
            this.lblNewPassword.Text = "New Password";
            // 
            // txtBoxNewName
            // 
            this.txtBoxNewName.Location = new System.Drawing.Point(643, 67);
            this.txtBoxNewName.Name = "txtBoxNewName";
            this.txtBoxNewName.Size = new System.Drawing.Size(125, 27);
            this.txtBoxNewName.TabIndex = 17;
            this.txtBoxNewName.TextChanged += new System.EventHandler(this.txtBoxNewName_TextChanged);
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Location = new System.Drawing.Point(643, 119);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.Size = new System.Drawing.Size(125, 27);
            this.txtBoxNewPassword.TabIndex = 18;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(502, 381);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(94, 29);
            this.btnClearFields.TabIndex = 19;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.txtBoxNewPassword);
            this.Controls.Add(this.txtBoxNewName);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.lblOldName);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.txtBoxDeleteUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.checkBoxEditIsAdmin);
            this.Controls.Add(this.txtBoxEditPassword);
            this.Controls.Add(this.txtBoxEditName);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnPrintAllUsers);
            this.Controls.Add(this.lstUsers);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListView lstUsers;
        private System.Windows.Forms.Button btnPrintAllUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.TextBox txtBoxEditName;
        private System.Windows.Forms.TextBox txtBoxEditPassword;
        private System.Windows.Forms.CheckBox checkBoxEditIsAdmin;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TextBox txtBoxDeleteUser;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblOldName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtBoxNewName;
        private System.Windows.Forms.TextBox txtBoxNewPassword;
        private System.Windows.Forms.Button btnClearFields;
    }
}