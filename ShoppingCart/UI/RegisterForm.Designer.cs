namespace ShoppingCart.UI
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
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.btnCancelUser = new System.Windows.Forms.Button();
            this.checkBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.lblIdUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Location = new System.Drawing.Point(442, 339);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(94, 29);
            this.btnRegisterUser.TabIndex = 15;
            this.btnRegisterUser.Text = "Register";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // btnCancelUser
            // 
            this.btnCancelUser.Location = new System.Drawing.Point(264, 339);
            this.btnCancelUser.Name = "btnCancelUser";
            this.btnCancelUser.Size = new System.Drawing.Size(94, 29);
            this.btnCancelUser.TabIndex = 14;
            this.btnCancelUser.Text = "Cancel";
            this.btnCancelUser.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(363, 253);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(89, 24);
            this.checkBoxIsAdmin.TabIndex = 13;
            this.checkBoxIsAdmin.Text = "Is Admin";
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(343, 208);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(125, 27);
            this.txtBoxPassword.TabIndex = 12;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(343, 145);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(125, 27);
            this.txtBoxName.TabIndex = 11;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(363, 175);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(370, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(363, 24);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(63, 20);
            this.lblRegister.TabIndex = 8;
            this.lblRegister.Text = "Register";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(343, 92);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(125, 27);
            this.txtBoxId.TabIndex = 16;
            this.txtBoxId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblIdUser
            // 
            this.lblIdUser.AutoSize = true;
            this.lblIdUser.Location = new System.Drawing.Point(369, 60);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(55, 20);
            this.lblIdUser.TabIndex = 17;
            this.lblIdUser.Text = "ID user";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdUser);
            this.Controls.Add(this.txtBoxId);
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
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegisterUser;
        private Button btnCancelUser;
        private CheckBox checkBoxIsAdmin;
        private TextBox txtBoxPassword;
        private TextBox txtBoxName;
        private Label lblPassword;
        private Label lblName;
        private Label lblRegister;
        private TextBox txtBoxId;
        private Label lblIdUser;
    }
}