namespace Assignment_Three.UI
{
    partial class StaffMenu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSellProduct = new System.Windows.Forms.TabPage();
            this.btnEmptyCart = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.comboProductCart = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.comboCustomerCart = new System.Windows.Forms.ComboBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.userCart = new System.Windows.Forms.ListBox();
            this.divider4 = new System.Windows.Forms.Label();
            this.divider3 = new System.Windows.Forms.Label();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.comboAuthors = new System.Windows.Forms.ComboBox();
            this.strRemaining = new System.Windows.Forms.TextBox();
            this.strISBN = new System.Windows.Forms.TextBox();
            this.strPrice = new System.Windows.Forms.TextBox();
            this.strDesc = new System.Windows.Forms.TextBox();
            this.strBookName = new System.Windows.Forms.TextBox();
            this.btnUnhide = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.lblQuantityRemain = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.divider1 = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnInsertProduct = new System.Windows.Forms.Button();
            this.btnPreviousProduct = new System.Windows.Forms.Button();
            this.btnNextProduct = new System.Windows.Forms.Button();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.strPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.strUserEmail = new System.Windows.Forms.TextBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.strLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.comboUserRole = new System.Windows.Forms.ComboBox();
            this.strFirstName = new System.Windows.Forms.TextBox();
            this.lblROle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.divider2 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnPreviousUser = new System.Windows.Forms.Button();
            this.btnNextUser = new System.Windows.Forms.Button();
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.menuStaff = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabSellProduct.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.menuStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSellProduct);
            this.tabControl1.Controls.Add(this.tabProducts);
            this.tabControl1.Controls.Add(this.tabCustomers);
            this.tabControl1.Location = new System.Drawing.Point(13, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(698, 399);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSellProduct
            // 
            this.tabSellProduct.Controls.Add(this.btnRefresh);
            this.tabSellProduct.Controls.Add(this.btnEmptyCart);
            this.tabSellProduct.Controls.Add(this.lblProduct);
            this.tabSellProduct.Controls.Add(this.comboProductCart);
            this.tabSellProduct.Controls.Add(this.lblCustomer);
            this.tabSellProduct.Controls.Add(this.comboCustomerCart);
            this.tabSellProduct.Controls.Add(this.btnAddToCart);
            this.tabSellProduct.Controls.Add(this.btnCheckout);
            this.tabSellProduct.Controls.Add(this.lblTotalCost);
            this.tabSellProduct.Controls.Add(this.userCart);
            this.tabSellProduct.Controls.Add(this.divider4);
            this.tabSellProduct.Controls.Add(this.divider3);
            this.tabSellProduct.Location = new System.Drawing.Point(4, 22);
            this.tabSellProduct.Name = "tabSellProduct";
            this.tabSellProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabSellProduct.Size = new System.Drawing.Size(690, 373);
            this.tabSellProduct.TabIndex = 1;
            this.tabSellProduct.Text = "Sell a Product";
            this.tabSellProduct.UseVisualStyleBackColor = true;
            // 
            // btnEmptyCart
            // 
            this.btnEmptyCart.Location = new System.Drawing.Point(236, 317);
            this.btnEmptyCart.Name = "btnEmptyCart";
            this.btnEmptyCart.Size = new System.Drawing.Size(218, 50);
            this.btnEmptyCart.TabIndex = 36;
            this.btnEmptyCart.Text = "Empty Cart";
            this.btnEmptyCart.UseVisualStyleBackColor = true;
            this.btnEmptyCart.Click += new System.EventHandler(this.BtnEmptyCart_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(13, 39);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 35;
            this.lblProduct.Text = "Product";
            // 
            // comboProductCart
            // 
            this.comboProductCart.FormattingEnabled = true;
            this.comboProductCart.Location = new System.Drawing.Point(63, 36);
            this.comboProductCart.Name = "comboProductCart";
            this.comboProductCart.Size = new System.Drawing.Size(158, 21);
            this.comboProductCart.TabIndex = 34;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(6, 10);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(51, 13);
            this.lblCustomer.TabIndex = 33;
            this.lblCustomer.Text = "Customer";
            // 
            // comboCustomerCart
            // 
            this.comboCustomerCart.FormattingEnabled = true;
            this.comboCustomerCart.Location = new System.Drawing.Point(63, 7);
            this.comboCustomerCart.Name = "comboCustomerCart";
            this.comboCustomerCart.Size = new System.Drawing.Size(158, 21);
            this.comboCustomerCart.TabIndex = 32;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(236, 63);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(218, 50);
            this.btnAddToCart.TabIndex = 31;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(236, 7);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(218, 50);
            this.btnCheckout.TabIndex = 30;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalCost.Location = new System.Drawing.Point(468, 345);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(216, 23);
            this.lblTotalCost.TabIndex = 29;
            this.lblTotalCost.Text = "Total Cost";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userCart
            // 
            this.userCart.FormattingEnabled = true;
            this.userCart.Location = new System.Drawing.Point(467, 6);
            this.userCart.Name = "userCart";
            this.userCart.Size = new System.Drawing.Size(217, 329);
            this.userCart.TabIndex = 28;
            // 
            // divider4
            // 
            this.divider4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider4.Location = new System.Drawing.Point(227, 0);
            this.divider4.Name = "divider4";
            this.divider4.Size = new System.Drawing.Size(2, 373);
            this.divider4.TabIndex = 27;
            // 
            // divider3
            // 
            this.divider3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider3.Location = new System.Drawing.Point(460, 0);
            this.divider3.Name = "divider3";
            this.divider3.Size = new System.Drawing.Size(2, 373);
            this.divider3.TabIndex = 26;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.comboAuthors);
            this.tabProducts.Controls.Add(this.strRemaining);
            this.tabProducts.Controls.Add(this.strISBN);
            this.tabProducts.Controls.Add(this.strPrice);
            this.tabProducts.Controls.Add(this.strDesc);
            this.tabProducts.Controls.Add(this.strBookName);
            this.tabProducts.Controls.Add(this.btnUnhide);
            this.tabProducts.Controls.Add(this.btnHide);
            this.tabProducts.Controls.Add(this.lblQuantityRemain);
            this.tabProducts.Controls.Add(this.labelISBN);
            this.tabProducts.Controls.Add(this.labelPrice);
            this.tabProducts.Controls.Add(this.labelDesc);
            this.tabProducts.Controls.Add(this.labelAuthor);
            this.tabProducts.Controls.Add(this.labelBookName);
            this.tabProducts.Controls.Add(this.divider1);
            this.tabProducts.Controls.Add(this.lblProductID);
            this.tabProducts.Controls.Add(this.btnUpdateProduct);
            this.tabProducts.Controls.Add(this.btnInsertProduct);
            this.tabProducts.Controls.Add(this.btnPreviousProduct);
            this.tabProducts.Controls.Add(this.btnNextProduct);
            this.tabProducts.Location = new System.Drawing.Point(4, 22);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Size = new System.Drawing.Size(690, 373);
            this.tabProducts.TabIndex = 2;
            this.tabProducts.Text = "Products";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // comboAuthors
            // 
            this.comboAuthors.FormattingEnabled = true;
            this.comboAuthors.Location = new System.Drawing.Point(328, 50);
            this.comboAuthors.Name = "comboAuthors";
            this.comboAuthors.Size = new System.Drawing.Size(219, 21);
            this.comboAuthors.TabIndex = 19;
            // 
            // strRemaining
            // 
            this.strRemaining.Location = new System.Drawing.Point(328, 214);
            this.strRemaining.Name = "strRemaining";
            this.strRemaining.Size = new System.Drawing.Size(111, 20);
            this.strRemaining.TabIndex = 18;
            // 
            // strISBN
            // 
            this.strISBN.Location = new System.Drawing.Point(328, 180);
            this.strISBN.Name = "strISBN";
            this.strISBN.Size = new System.Drawing.Size(152, 20);
            this.strISBN.TabIndex = 17;
            // 
            // strPrice
            // 
            this.strPrice.Location = new System.Drawing.Point(328, 150);
            this.strPrice.Name = "strPrice";
            this.strPrice.Size = new System.Drawing.Size(111, 20);
            this.strPrice.TabIndex = 16;
            // 
            // strDesc
            // 
            this.strDesc.Location = new System.Drawing.Point(328, 84);
            this.strDesc.Multiline = true;
            this.strDesc.Name = "strDesc";
            this.strDesc.Size = new System.Drawing.Size(219, 60);
            this.strDesc.TabIndex = 15;
            // 
            // strBookName
            // 
            this.strBookName.Location = new System.Drawing.Point(328, 18);
            this.strBookName.Name = "strBookName";
            this.strBookName.Size = new System.Drawing.Size(219, 20);
            this.strBookName.TabIndex = 14;
            // 
            // btnUnhide
            // 
            this.btnUnhide.Location = new System.Drawing.Point(245, 290);
            this.btnUnhide.Name = "btnUnhide";
            this.btnUnhide.Size = new System.Drawing.Size(75, 23);
            this.btnUnhide.TabIndex = 13;
            this.btnUnhide.Text = "Un-Hide";
            this.btnUnhide.UseVisualStyleBackColor = true;
            this.btnUnhide.Click += new System.EventHandler(this.BtnUnhide_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(245, 261);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 12;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.BtnHide_Click);
            // 
            // lblQuantityRemain
            // 
            this.lblQuantityRemain.Location = new System.Drawing.Point(235, 214);
            this.lblQuantityRemain.Name = "lblQuantityRemain";
            this.lblQuantityRemain.Size = new System.Drawing.Size(85, 36);
            this.lblQuantityRemain.TabIndex = 11;
            this.lblQuantityRemain.Text = "Quantity Remaining";
            this.lblQuantityRemain.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(261, 183);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(60, 13);
            this.labelISBN.TabIndex = 10;
            this.labelISBN.Text = "Book ISBN";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(261, 151);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(59, 13);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "Book Price";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(233, 84);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(88, 13);
            this.labelDesc.TabIndex = 8;
            this.labelDesc.Text = "Book Description";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(283, 50);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 7;
            this.labelAuthor.Text = "Author";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(258, 18);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(63, 13);
            this.labelBookName.TabIndex = 6;
            this.labelBookName.Text = "Book Name";
            // 
            // divider1
            // 
            this.divider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider1.Location = new System.Drawing.Point(225, 0);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(2, 373);
            this.divider1.TabIndex = 5;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductID.Location = new System.Drawing.Point(3, 353);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(158, 20);
            this.lblProductID.TabIndex = 4;
            this.lblProductID.Text = "PRODUCT ID HERE";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(4, 246);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(75, 75);
            this.btnUpdateProduct.TabIndex = 3;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.BtnUpdateProduct_Click);
            // 
            // btnInsertProduct
            // 
            this.btnInsertProduct.Location = new System.Drawing.Point(4, 165);
            this.btnInsertProduct.Name = "btnInsertProduct";
            this.btnInsertProduct.Size = new System.Drawing.Size(75, 75);
            this.btnInsertProduct.TabIndex = 2;
            this.btnInsertProduct.Text = "Insert New Product";
            this.btnInsertProduct.UseVisualStyleBackColor = true;
            this.btnInsertProduct.Click += new System.EventHandler(this.BtnInsertProduct_Click);
            // 
            // btnPreviousProduct
            // 
            this.btnPreviousProduct.Location = new System.Drawing.Point(4, 84);
            this.btnPreviousProduct.Name = "btnPreviousProduct";
            this.btnPreviousProduct.Size = new System.Drawing.Size(75, 75);
            this.btnPreviousProduct.TabIndex = 1;
            this.btnPreviousProduct.Text = "Previous Record";
            this.btnPreviousProduct.UseVisualStyleBackColor = true;
            this.btnPreviousProduct.Click += new System.EventHandler(this.BtnPreviousProduct_Click);
            // 
            // btnNextProduct
            // 
            this.btnNextProduct.Location = new System.Drawing.Point(4, 3);
            this.btnNextProduct.Name = "btnNextProduct";
            this.btnNextProduct.Size = new System.Drawing.Size(75, 75);
            this.btnNextProduct.TabIndex = 0;
            this.btnNextProduct.Text = "Next Record";
            this.btnNextProduct.UseVisualStyleBackColor = true;
            this.btnNextProduct.Click += new System.EventHandler(this.BtnNextProduct_Click);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.strPassword);
            this.tabCustomers.Controls.Add(this.lblPassword);
            this.tabCustomers.Controls.Add(this.strUserEmail);
            this.tabCustomers.Controls.Add(this.lblUserEmail);
            this.tabCustomers.Controls.Add(this.strLastName);
            this.tabCustomers.Controls.Add(this.lblLastName);
            this.tabCustomers.Controls.Add(this.comboUserRole);
            this.tabCustomers.Controls.Add(this.strFirstName);
            this.tabCustomers.Controls.Add(this.lblROle);
            this.tabCustomers.Controls.Add(this.lblFirstName);
            this.tabCustomers.Controls.Add(this.divider2);
            this.tabCustomers.Controls.Add(this.lblUserID);
            this.tabCustomers.Controls.Add(this.btnUpdateUser);
            this.tabCustomers.Controls.Add(this.btnPreviousUser);
            this.tabCustomers.Controls.Add(this.btnNextUser);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Size = new System.Drawing.Size(690, 373);
            this.tabCustomers.TabIndex = 3;
            this.tabCustomers.Text = "Customer Management";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // strPassword
            // 
            this.strPassword.Location = new System.Drawing.Point(327, 122);
            this.strPassword.Name = "strPassword";
            this.strPassword.Size = new System.Drawing.Size(219, 20);
            this.strPassword.TabIndex = 35;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(268, 125);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 34;
            this.lblPassword.Text = "Password";
            // 
            // strUserEmail
            // 
            this.strUserEmail.Location = new System.Drawing.Point(327, 96);
            this.strUserEmail.Name = "strUserEmail";
            this.strUserEmail.Size = new System.Drawing.Size(219, 20);
            this.strUserEmail.TabIndex = 33;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(289, 99);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(32, 13);
            this.lblUserEmail.TabIndex = 32;
            this.lblUserEmail.Text = "Email";
            // 
            // strLastName
            // 
            this.strLastName.Location = new System.Drawing.Point(327, 43);
            this.strLastName.Name = "strLastName";
            this.strLastName.Size = new System.Drawing.Size(219, 20);
            this.strLastName.TabIndex = 31;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(263, 46);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 30;
            this.lblLastName.Text = "Last Name";
            // 
            // comboUserRole
            // 
            this.comboUserRole.FormattingEnabled = true;
            this.comboUserRole.Items.AddRange(new object[] {
            "Banned",
            "User",
            "Staff",
            "Manager"});
            this.comboUserRole.Location = new System.Drawing.Point(327, 69);
            this.comboUserRole.Name = "comboUserRole";
            this.comboUserRole.Size = new System.Drawing.Size(219, 21);
            this.comboUserRole.TabIndex = 29;
            // 
            // strFirstName
            // 
            this.strFirstName.Location = new System.Drawing.Point(327, 17);
            this.strFirstName.Name = "strFirstName";
            this.strFirstName.Size = new System.Drawing.Size(219, 20);
            this.strFirstName.TabIndex = 28;
            // 
            // lblROle
            // 
            this.lblROle.AutoSize = true;
            this.lblROle.Location = new System.Drawing.Point(292, 72);
            this.lblROle.Name = "lblROle";
            this.lblROle.Size = new System.Drawing.Size(29, 13);
            this.lblROle.TabIndex = 27;
            this.lblROle.Text = "Role";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(264, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 26;
            this.lblFirstName.Text = "First Name";
            // 
            // divider2
            // 
            this.divider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider2.Location = new System.Drawing.Point(224, -1);
            this.divider2.Name = "divider2";
            this.divider2.Size = new System.Drawing.Size(2, 373);
            this.divider2.TabIndex = 25;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUserID.Location = new System.Drawing.Point(2, 352);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(126, 20);
            this.lblUserID.TabIndex = 24;
            this.lblUserID.Text = "USER ID HERE";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(3, 164);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(75, 75);
            this.btnUpdateUser.TabIndex = 23;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.BtnUpdateUser_Click);
            // 
            // btnPreviousUser
            // 
            this.btnPreviousUser.Location = new System.Drawing.Point(3, 83);
            this.btnPreviousUser.Name = "btnPreviousUser";
            this.btnPreviousUser.Size = new System.Drawing.Size(75, 75);
            this.btnPreviousUser.TabIndex = 21;
            this.btnPreviousUser.Text = "Previous Record";
            this.btnPreviousUser.UseVisualStyleBackColor = true;
            this.btnPreviousUser.Click += new System.EventHandler(this.BtnPreviousUser_Click);
            // 
            // btnNextUser
            // 
            this.btnNextUser.Location = new System.Drawing.Point(3, 2);
            this.btnNextUser.Name = "btnNextUser";
            this.btnNextUser.Size = new System.Drawing.Size(75, 75);
            this.btnNextUser.TabIndex = 20;
            this.btnNextUser.Text = "Next Record";
            this.btnNextUser.UseVisualStyleBackColor = true;
            this.btnNextUser.Click += new System.EventHandler(this.BtnNextUser_Click);
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDetails.Location = new System.Drawing.Point(405, 9);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(306, 27);
            this.lblUserDetails.TabIndex = 1;
            this.lblUserDetails.Text = "lblUserDetails";
            this.lblUserDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStaff
            // 
            this.menuStaff.BackColor = System.Drawing.SystemColors.Control;
            this.menuStaff.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStaff.Location = new System.Drawing.Point(0, 0);
            this.menuStaff.Name = "menuStaff";
            this.menuStaff.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStaff.Size = new System.Drawing.Size(723, 24);
            this.menuStaff.TabIndex = 2;
            this.menuStaff.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(236, 261);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(218, 50);
            this.btnRefresh.TabIndex = 37;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // StaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.lblUserDetails);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStaff;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.StaffMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSellProduct.ResumeLayout(false);
            this.tabSellProduct.PerformLayout();
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            this.menuStaff.ResumeLayout(false);
            this.menuStaff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSellProduct;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.Label lblUserDetails;
        private System.Windows.Forms.MenuStrip menuStaff;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnPreviousProduct;
        private System.Windows.Forms.Button btnNextProduct;
        internal System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label divider1;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label lblQuantityRemain;
        internal System.Windows.Forms.TabPage tabProducts;
        internal System.Windows.Forms.TextBox strBookName;
        internal System.Windows.Forms.TextBox strRemaining;
        internal System.Windows.Forms.TextBox strISBN;
        internal System.Windows.Forms.TextBox strPrice;
        internal System.Windows.Forms.TextBox strDesc;
        internal System.Windows.Forms.ComboBox comboAuthors;
        internal System.Windows.Forms.Button btnInsertProduct;
        internal System.Windows.Forms.Button btnUpdateProduct;
        internal System.Windows.Forms.Button btnUnhide;
        internal System.Windows.Forms.Button btnHide;
        internal System.Windows.Forms.TextBox strLastName;
        private System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.ComboBox comboUserRole;
        internal System.Windows.Forms.TextBox strFirstName;
        private System.Windows.Forms.Label lblROle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label divider2;
        internal System.Windows.Forms.Label lblUserID;
        internal System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnPreviousUser;
        private System.Windows.Forms.Button btnNextUser;
        internal System.Windows.Forms.TextBox strUserEmail;
        private System.Windows.Forms.Label lblUserEmail;
        internal System.Windows.Forms.TextBox strPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label divider4;
        private System.Windows.Forms.Label divider3;
        internal System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnEmptyCart;
        internal System.Windows.Forms.ListBox userCart;
        internal System.Windows.Forms.ComboBox comboCustomerCart;
        internal System.Windows.Forms.ComboBox comboProductCart;
        private System.Windows.Forms.Button btnRefresh;
    }
}