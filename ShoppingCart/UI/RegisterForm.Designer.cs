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
            this.txtBoxIdCard = new System.Windows.Forms.TextBox();
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.lblIdCard = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegisterUser.Location = new System.Drawing.Point(445, 377);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(122, 61);
            this.btnRegisterUser.TabIndex = 15;
            this.btnRegisterUser.Text = "Register";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // btnCancelUser
            // 
            this.btnCancelUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelUser.Location = new System.Drawing.Point(247, 377);
            this.btnCancelUser.Name = "btnCancelUser";
            this.btnCancelUser.Size = new System.Drawing.Size(136, 61);
            this.btnCancelUser.TabIndex = 14;
            this.btnCancelUser.Text = "Cancel";
            this.btnCancelUser.UseVisualStyleBackColor = true;
            this.btnCancelUser.Click += new System.EventHandler(this.btnCancelUser_Click);
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(344, 342);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(110, 28);
            this.checkBoxIsAdmin.TabIndex = 13;
            this.checkBoxIsAdmin.Text = "Is Admin";
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPassword.Location = new System.Drawing.Point(344, 199);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(125, 32);
            this.txtBoxPassword.TabIndex = 12;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxName.Location = new System.Drawing.Point(344, 137);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(125, 32);
            this.txtBoxName.TabIndex = 11;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(363, 172);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(94, 24);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(370, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 24);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegister.Location = new System.Drawing.Point(363, 24);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(83, 24);
            this.lblRegister.TabIndex = 8;
            this.lblRegister.Text = "Register";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxId.Location = new System.Drawing.Point(344, 75);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(125, 32);
            this.txtBoxId.TabIndex = 16;
            this.txtBoxId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblIdUser
            // 
            this.lblIdUser.AutoSize = true;
            this.lblIdUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdUser.Location = new System.Drawing.Point(370, 48);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(75, 24);
            this.lblIdUser.TabIndex = 17;
            this.lblIdUser.Text = "ID user";
            // 
            // txtBoxIdCard
            // 
            this.txtBoxIdCard.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxIdCard.Location = new System.Drawing.Point(343, 258);
            this.txtBoxIdCard.Name = "txtBoxIdCard";
            this.txtBoxIdCard.Size = new System.Drawing.Size(125, 32);
            this.txtBoxIdCard.TabIndex = 18;
            // 
            // txtBoxAmount
            // 
            this.txtBoxAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxAmount.Location = new System.Drawing.Point(343, 313);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.Size = new System.Drawing.Size(125, 32);
            this.txtBoxAmount.TabIndex = 19;
            // 
            // lblIdCard
            // 
            this.lblIdCard.AutoSize = true;
            this.lblIdCard.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdCard.Location = new System.Drawing.Point(363, 231);
            this.lblIdCard.Name = "lblIdCard";
            this.lblIdCard.Size = new System.Drawing.Size(69, 24);
            this.lblIdCard.TabIndex = 20;
            this.lblIdCard.Text = "IdCard";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(344, 286);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(126, 24);
            this.lblAmount.TabIndex = 21;
            this.lblAmount.Text = "Amount Card";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblIdCard);
            this.Controls.Add(this.txtBoxAmount);
            this.Controls.Add(this.txtBoxIdCard);
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
        private TextBox txtBoxIdCard;
        private TextBox txtBoxAmount;
        private Label lblIdCard;
        private Label lblAmount;
    }
}