namespace ShoppingCart.UI
{
    partial class PaymentForm
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxCard = new System.Windows.Forms.TextBox();
            this.lblCard = new System.Windows.Forms.Label();
            this.btnPatWithCard = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxName.Location = new System.Drawing.Point(12, 57);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(225, 32);
            this.txtBoxName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(12, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtBoxCard
            // 
            this.txtBoxCard.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxCard.Location = new System.Drawing.Point(12, 136);
            this.txtBoxCard.Name = "txtBoxCard";
            this.txtBoxCard.Size = new System.Drawing.Size(225, 32);
            this.txtBoxCard.TabIndex = 2;
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCard.Location = new System.Drawing.Point(12, 101);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(51, 24);
            this.lblCard.TabIndex = 3;
            this.lblCard.Text = "Card";
            // 
            // btnPatWithCard
            // 
            this.btnPatWithCard.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPatWithCard.Location = new System.Drawing.Point(386, 73);
            this.btnPatWithCard.Name = "btnPatWithCard";
            this.btnPatWithCard.Size = new System.Drawing.Size(208, 80);
            this.btnPatWithCard.TabIndex = 4;
            this.btnPatWithCard.Text = "Pay with Card";
            this.btnPatWithCard.UseVisualStyleBackColor = true;
            this.btnPatWithCard.Click += new System.EventHandler(this.btnPatWithCard_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(386, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(208, 72);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel Transaction";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPatWithCard);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.txtBoxCard);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxName);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxName;
        private Label lblName;
        private TextBox txtBoxCard;
        private Label lblCard;
        private Button btnPatWithCard;
        private Button btnCancel;
    }
}