namespace ShoppingCart.UI
{
    partial class frmAdminForm
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtBoxIdProduct = new System.Windows.Forms.TextBox();
            this.lblIdProduct = new System.Windows.Forms.Label();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.txtBoxProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(49, 49);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(191, 31);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtBoxIdProduct
            // 
            this.txtBoxIdProduct.Location = new System.Drawing.Point(55, 105);
            this.txtBoxIdProduct.Name = "txtBoxIdProduct";
            this.txtBoxIdProduct.Size = new System.Drawing.Size(125, 27);
            this.txtBoxIdProduct.TabIndex = 1;
            // 
            // lblIdProduct
            // 
            this.lblIdProduct.AutoSize = true;
            this.lblIdProduct.Location = new System.Drawing.Point(55, 83);
            this.lblIdProduct.Name = "lblIdProduct";
            this.lblIdProduct.Size = new System.Drawing.Size(24, 20);
            this.lblIdProduct.TabIndex = 2;
            this.lblIdProduct.Text = "ID";
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Location = new System.Drawing.Point(55, 181);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.Size = new System.Drawing.Size(125, 27);
            this.txtBoxProductName.TabIndex = 3;
            // 
            // txtBoxProductPrice
            // 
            this.txtBoxProductPrice.Location = new System.Drawing.Point(55, 261);
            this.txtBoxProductPrice.Name = "txtBoxProductPrice";
            this.txtBoxProductPrice.Size = new System.Drawing.Size(125, 27);
            this.txtBoxProductPrice.TabIndex = 4;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(55, 158);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(60, 20);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "Product";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(57, 235);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // frmAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtBoxProductPrice);
            this.Controls.Add(this.txtBoxProductName);
            this.Controls.Add(this.lblIdProduct);
            this.Controls.Add(this.txtBoxIdProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Name = "frmAdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddProduct;
        private TextBox txtBoxIdProduct;
        private Label lblIdProduct;
        private TextBox txtBoxProductName;
        private TextBox txtBoxProductPrice;
        private Label lblProductName;
        private Label lblPrice;
    }
}