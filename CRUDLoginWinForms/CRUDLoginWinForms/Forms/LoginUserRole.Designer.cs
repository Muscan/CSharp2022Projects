
namespace CRUDWithLoginExample.Forms
{
    partial class LoginUserRole
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
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnEditLoggedUser = new System.Windows.Forms.Button();
            this.txtBoxNewName = new System.Windows.Forms.TextBox();
            this.txtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewUserName = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(619, 374);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(106, 43);
            this.btnSignOut.TabIndex = 0;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(42, 23);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(80, 20);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Welcome...";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // btnEditLoggedUser
            // 
            this.btnEditLoggedUser.Location = new System.Drawing.Point(211, 40);
            this.btnEditLoggedUser.Name = "btnEditLoggedUser";
            this.btnEditLoggedUser.Size = new System.Drawing.Size(125, 36);
            this.btnEditLoggedUser.TabIndex = 5;
            this.btnEditLoggedUser.Text = "Edit User";
            this.btnEditLoggedUser.UseVisualStyleBackColor = true;
            this.btnEditLoggedUser.Click += new System.EventHandler(this.btnEditLoggedUser_Click);
            // 
            // txtBoxNewName
            // 
            this.txtBoxNewName.Location = new System.Drawing.Point(211, 110);
            this.txtBoxNewName.Name = "txtBoxNewName";
            this.txtBoxNewName.Size = new System.Drawing.Size(125, 27);
            this.txtBoxNewName.TabIndex = 6;
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Location = new System.Drawing.Point(211, 172);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.Size = new System.Drawing.Size(125, 27);
            this.txtBoxNewPassword.TabIndex = 7;
            // 
            // lblNewUserName
            // 
            this.lblNewUserName.AutoSize = true;
            this.lblNewUserName.Location = new System.Drawing.Point(211, 79);
            this.lblNewUserName.Name = "lblNewUserName";
            this.lblNewUserName.Size = new System.Drawing.Size(83, 20);
            this.lblNewUserName.TabIndex = 8;
            this.lblNewUserName.Text = "New Name";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(211, 144);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(104, 20);
            this.lblNewPassword.TabIndex = 9;
            this.lblNewPassword.Text = "New Password";
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(472, 374);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(94, 43);
            this.btnClearFields.TabIndex = 10;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // LoginUserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblNewUserName);
            this.Controls.Add(this.txtBoxNewPassword);
            this.Controls.Add(this.txtBoxNewName);
            this.Controls.Add(this.btnEditLoggedUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnSignOut);
            this.Name = "LoginUserRole";
            this.Text = "User Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnEditLoggedUser;
        private System.Windows.Forms.TextBox txtBoxNewName;
        private System.Windows.Forms.TextBox txtBoxNewPassword;
        private System.Windows.Forms.Label lblNewUserName;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnClearFields;
    }
}