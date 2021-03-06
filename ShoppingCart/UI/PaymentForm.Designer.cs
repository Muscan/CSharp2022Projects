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
            this.btnPayWithCard = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBackToCart = new System.Windows.Forms.Button();
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
            // btnPayWithCard
            // 
            this.btnPayWithCard.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPayWithCard.Location = new System.Drawing.Point(386, 73);
            this.btnPayWithCard.Name = "btnPayWithCard";
            this.btnPayWithCard.Size = new System.Drawing.Size(208, 80);
            this.btnPayWithCard.TabIndex = 4;
            this.btnPayWithCard.Text = "Pay with Card";
            this.btnPayWithCard.UseVisualStyleBackColor = true;
            this.btnPayWithCard.Click += new System.EventHandler(this.btnPayWithCard_Click);
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
            // btnBackToCart
            // 
            this.btnBackToCart.Location = new System.Drawing.Point(386, 179);
            this.btnBackToCart.Name = "btnBackToCart";
            this.btnBackToCart.Size = new System.Drawing.Size(208, 89);
            this.btnBackToCart.TabIndex = 6;
            this.btnBackToCart.Text = "Back to cart";
            this.btnBackToCart.UseVisualStyleBackColor = true;
            this.btnBackToCart.Click += new System.EventHandler(this.btnBackToCart_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToCart);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPayWithCard);
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
        private Button btnPayWithCard;
        private Button btnCancel;
        private Button btnBackToCart;
    }
}