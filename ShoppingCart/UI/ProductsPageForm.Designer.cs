namespace ShoppingCart
{
    partial class ProductsPageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstViewProducts = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstViewCart = new System.Windows.Forms.ListView();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstViewProducts
            // 
            this.lstViewProducts.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstViewProducts.FullRowSelect = true;
            this.lstViewProducts.GridLines = true;
            this.lstViewProducts.Location = new System.Drawing.Point(12, 22);
            this.lstViewProducts.Name = "lstViewProducts";
            this.lstViewProducts.Size = new System.Drawing.Size(633, 212);
            this.lstViewProducts.TabIndex = 0;
            this.lstViewProducts.UseCompatibleStateImageBehavior = false;
            this.lstViewProducts.View = System.Windows.Forms.View.Details;
            this.lstViewProducts.SelectedIndexChanged += new System.EventHandler(this.lstViewProducts_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(488, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 47);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add To Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstViewCart
            // 
            this.lstViewCart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstViewCart.FullRowSelect = true;
            this.lstViewCart.GridLines = true;
            this.lstViewCart.Location = new System.Drawing.Point(699, 22);
            this.lstViewCart.Name = "lstViewCart";
            this.lstViewCart.Size = new System.Drawing.Size(584, 212);
            this.lstViewCart.TabIndex = 2;
            this.lstViewCart.UseCompatibleStateImageBehavior = false;
            this.lstViewCart.View = System.Windows.Forms.View.Details;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPay.Location = new System.Drawing.Point(1079, 240);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(204, 52);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(619, 322);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(123, 32);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total Price";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(699, 242);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(204, 52);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 547);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lstViewCart);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstViewProducts);
            this.Name = "Form1";
            this.Text = "MY CART";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lstViewProducts;
        private Button btnAdd;
        private ListView lstViewCart;
        private Button btnPay;
        private Label lblTotal;
        private Button btnRemove;
    }
}