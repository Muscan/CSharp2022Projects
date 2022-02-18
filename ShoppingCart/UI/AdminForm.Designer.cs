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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminForm));
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtBoxIdProduct = new System.Windows.Forms.TextBox();
            this.lblIdProduct = new System.Windows.Forms.Label();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.txtBoxProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCancelAdminForm = new System.Windows.Forms.Button();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.lstViewProducts = new System.Windows.Forms.ListView();
            this.lstViewUsers = new System.Windows.Forms.ListView();
            this.lstViewCards = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(6, 46);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(131, 31);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtBoxIdProduct
            // 
            this.txtBoxIdProduct.Location = new System.Drawing.Point(12, 102);
            this.txtBoxIdProduct.Name = "txtBoxIdProduct";
            this.txtBoxIdProduct.Size = new System.Drawing.Size(125, 27);
            this.txtBoxIdProduct.TabIndex = 1;
            // 
            // lblIdProduct
            // 
            this.lblIdProduct.AutoSize = true;
            this.lblIdProduct.Location = new System.Drawing.Point(45, 80);
            this.lblIdProduct.Name = "lblIdProduct";
            this.lblIdProduct.Size = new System.Drawing.Size(24, 20);
            this.lblIdProduct.TabIndex = 2;
            this.lblIdProduct.Text = "ID";
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Location = new System.Drawing.Point(12, 178);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.Size = new System.Drawing.Size(125, 27);
            this.txtBoxProductName.TabIndex = 3;
            // 
            // txtBoxProductPrice
            // 
            this.txtBoxProductPrice.Location = new System.Drawing.Point(12, 258);
            this.txtBoxProductPrice.Name = "txtBoxProductPrice";
            this.txtBoxProductPrice.Size = new System.Drawing.Size(125, 27);
            this.txtBoxProductPrice.TabIndex = 4;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(28, 155);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(60, 20);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "Product";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(28, 235);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // btnCancelAdminForm
            // 
            this.btnCancelAdminForm.Location = new System.Drawing.Point(601, 383);
            this.btnCancelAdminForm.Name = "btnCancelAdminForm";
            this.btnCancelAdminForm.Size = new System.Drawing.Size(94, 29);
            this.btnCancelAdminForm.TabIndex = 7;
            this.btnCancelAdminForm.Text = "Cancel";
            this.btnCancelAdminForm.UseVisualStyleBackColor = true;
            this.btnCancelAdminForm.Click += new System.EventHandler(this.btnCancelAdminForm_Click);
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.Location = new System.Drawing.Point(253, 47);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(114, 29);
            this.btnViewProducts.TabIndex = 8;
            this.btnViewProducts.Text = "View Products";
            this.btnViewProducts.UseVisualStyleBackColor = true;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(498, 12);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(107, 29);
            this.btnAddUser.TabIndex = 9;
            this.btnAddUser.Text = "AddUser";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.Location = new System.Drawing.Point(495, 48);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(110, 29);
            this.btnViewUsers.TabIndex = 10;
            this.btnViewUsers.Text = "View Users";
            this.btnViewUsers.UseVisualStyleBackColor = true;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // lstViewProducts
            // 
            this.lstViewProducts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstViewProducts.FullRowSelect = true;
            this.lstViewProducts.GridLines = true;
            this.lstViewProducts.Location = new System.Drawing.Point(159, 102);
            this.lstViewProducts.Name = "lstViewProducts";
            this.lstViewProducts.Size = new System.Drawing.Size(324, 183);
            this.lstViewProducts.TabIndex = 11;
            this.lstViewProducts.UseCompatibleStateImageBehavior = false;
            this.lstViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // lstViewUsers
            // 
            this.lstViewUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstViewUsers.FullRowSelect = true;
            this.lstViewUsers.GridLines = true;
            this.lstViewUsers.Location = new System.Drawing.Point(488, 101);
            this.lstViewUsers.Name = "lstViewUsers";
            this.lstViewUsers.Size = new System.Drawing.Size(336, 184);
            this.lstViewUsers.TabIndex = 12;
            this.lstViewUsers.UseCompatibleStateImageBehavior = false;
            this.lstViewUsers.View = System.Windows.Forms.View.Details;
            this.lstViewUsers.SelectedIndexChanged += new System.EventHandler(this.lstViewUsers_SelectedIndexChanged);
            // 
            // lstViewCards
            // 
            this.lstViewCards.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lstViewCards.BackgroundImage")));
            this.lstViewCards.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstViewCards.FullRowSelect = true;
            this.lstViewCards.Location = new System.Drawing.Point(833, 102);
            this.lstViewCards.Name = "lstViewCards";
            this.lstViewCards.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstViewCards.Size = new System.Drawing.Size(368, 183);
            this.lstViewCards.TabIndex = 13;
            this.lstViewCards.UseCompatibleStateImageBehavior = false;
            this.lstViewCards.View = System.Windows.Forms.View.Details;
            this.lstViewCards.SelectedIndexChanged += new System.EventHandler(this.lstViewCards_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(159, 305);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // frmAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 517);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstViewCards);
            this.Controls.Add(this.lstViewUsers);
            this.Controls.Add(this.lstViewProducts);
            this.Controls.Add(this.btnViewUsers);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnViewProducts);
            this.Controls.Add(this.btnCancelAdminForm);
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
        private Button btnCancelAdminForm;
        private Button btnViewProducts;
        private Button btnAddUser;
        private Button btnViewUsers;
        private ListView lstViewProducts;
        private ListView lstViewUsers;
        private ListView lstViewCards;
        private Button btnDelete;
    }
}