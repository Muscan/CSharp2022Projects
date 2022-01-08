
namespace CRUDWithLoginExample.Forms
{
    partial class RegisterForm
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
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.btnCancelUser = new System.Windows.Forms.Button();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(317, 90);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(63, 20);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Register";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(317, 130);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(310, 183);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(290, 153);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(125, 27);
            this.txtBoxName.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(290, 216);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(125, 27);
            this.txtBoxPassword.TabIndex = 4;
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(310, 261);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(89, 24);
            this.checkBoxIsAdmin.TabIndex = 5;
            this.checkBoxIsAdmin.Text = "Is Admin";
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            this.checkBoxIsAdmin.CheckedChanged += new System.EventHandler(this.checkBoxIsAdmin_CheckedChanged);
            // 
            // btnCancelUser
            // 
            this.btnCancelUser.Location = new System.Drawing.Point(211, 347);
            this.btnCancelUser.Name = "btnCancelUser";
            this.btnCancelUser.Size = new System.Drawing.Size(94, 29);
            this.btnCancelUser.TabIndex = 6;
            this.btnCancelUser.Text = "Cancel";
            this.btnCancelUser.UseVisualStyleBackColor = true;
            this.btnCancelUser.Click += new System.EventHandler(this.btnCancelUser_Click);
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Location = new System.Drawing.Point(389, 347);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(94, 29);
            this.btnRegisterUser.TabIndex = 7;
            this.btnRegisterUser.Text = "Register";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegisterUser);
            this.Controls.Add(this.btnCancelUser);
            this.Controls.Add(this.checkBoxIsAdmin);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRegister);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxIsAdmin;
        private System.Windows.Forms.Button btnCancelUser;
        private System.Windows.Forms.Button btnRegisterUser;
    }
}