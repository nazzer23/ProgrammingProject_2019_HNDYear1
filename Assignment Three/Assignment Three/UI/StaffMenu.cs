using System;
using System.Data;
using System.Windows.Forms;
using Assignment_Three;
using Assignment_Three.Handlers;
using Assignment_Three.Objects;
using Assignment_Three.UI;
using MySql.Data.MySqlClient;
namespace Assignment_Three.UI
{
    using System.Windows.Forms;
    using System;
    using Assignment_Three;

    public partial class StaffMenu : Form
    {
        private ProductsTab productTab;
        private CustomerTab customerTab;
        private UserCart cartTab;

        public StaffMenu()
        {
            this.InitializeComponent();
            this.InitForm();
        }

        private void StaffMenu_Load(object sender, EventArgs e)
        {
            // Calls the ShutdownEvent function that is situation within the Core Class. This is because FormClosing is an event.
            this.FormClosing += Core.ShutdownEvent;
        }

        private void InitForm()
        {
            this.lblUserDetails.Text = Core.userObject.GetString("FirstName") + @" " +
                                       Core.userObject.GetString("LastName") + @" - " +
                                       Core.userObject.GetInt("CustomerID");


            if (Core.userObject.GetInt("access") != 3) // If user isn't a manager, hide panels.
            {
                this.tabControl1.TabPages.Remove(this.tabCustomers);
            }
            else
            {
                // Will initialize the tabs here
            }

            this.productTab = new ProductsTab(this);
            this.customerTab = new CustomerTab(this);
            this.cartTab = new UserCart(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Core.Shutdown();
        }

        private void BtnPreviousProduct_Click(object sender, EventArgs e)
        {
            this.productTab.PreviousItem();
        }

        private void BtnInsertProduct_Click(object sender, EventArgs e)
        {
            this.productTab.InsertBook();
        }

        private void BtnNextProduct_Click(object sender, EventArgs e)
        {
            this.productTab.NextItem();
        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            this.productTab.UpdateBook();
        }

        private void BtnHide_Click(object sender, EventArgs e)
        {
            this.productTab.Hide();
        }

        private void BtnUnhide_Click(object sender, EventArgs e)
        {
            this.productTab.UnHide();
        }

        private void BtnNextUser_Click(object sender, EventArgs e)
        {
            this.customerTab.NextItem();
        }

        private void BtnPreviousUser_Click(object sender, EventArgs e)
        {
            this.customerTab.PreviousItem();
        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            this.customerTab.UpdateUser();
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            this.cartTab.AddToCart();
        }

        private void BtnEmptyCart_Click(object sender, EventArgs e)
        {
            this.cartTab.EmptyCart();
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            this.cartTab.Checkout();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.cartTab.Refresh();
        }
    }
}

class ProductsTab
{
    private StaffMenu menu;

    private int productIndex = 0;

    public ProductsTab(StaffMenu menu)
    {
        this.menu = menu;
        this.FetchProduct();
    }

    public void NextItem()
    {
        this.productIndex++;
        this.FetchProduct();
    }

    public void PreviousItem()
    {
        if (this.productIndex > 0)
        {
            this.productIndex--;
            this.FetchProduct();
        }
    }

    public void InsertBook()
    {
        string bookName = this.menu.strBookName.Text;
        string bookDesc = this.menu.strDesc.Text;
        long bookISBN = Convert.ToInt64(this.menu.strISBN.Text);
        double bookPrice = Convert.ToDouble(this.menu.strPrice.Text);
        int remaining = int.Parse(this.menu.strRemaining.Text);
        int AuthorID = Core.authorList[this.menu.comboAuthors.SelectedIndex].GetInt("AuthorID");

        string query =
            "INSERT INTO books (BookName,AuthorID,BookDescription, BookPrice,BookISBN,QuantityRemain) VALUES " +
            "(@bookName,@authorID,@bookDesc,@bookPrice,@bookISBN,@quantity);";
        DatabaseHandler.instance.Execute(query, new MySqlParameter[]
        {
            new MySqlParameter("@bookName", bookName),
            new MySqlParameter("@authorID", AuthorID),
            new MySqlParameter("@bookDesc", bookDesc),
            new MySqlParameter("@bookPrice", bookPrice),
            new MySqlParameter("@bookISBN", bookISBN),
            new MySqlParameter("@quantity", remaining),
        });

        var product = new ProductObject();
        product.SetInt("BookID", this.productIndex + 1);
        product.SetString("BookName", bookName);
        product.SetInt("AuthorID", AuthorID);
        product.SetString("BookDescription", bookDesc);
        product.SetDouble("BookPrice", bookPrice);
        product.SetLong("BookISBN", bookISBN);
        product.SetInt("QuantityRemain", remaining);
        product.SetBool("Hidden", false);
        Core.productList.Add(product);

        this.FetchProduct();
    }

    public void UpdateBook()
    {
        string bookName = this.menu.strBookName.Text;
        string bookDesc = this.menu.strDesc.Text;
        long bookISBN = Convert.ToInt64(this.menu.strISBN.Text);
        double bookPrice = Convert.ToDouble(this.menu.strPrice.Text);
        int remaining = int.Parse(this.menu.strRemaining.Text);
        int AuthorID = Core.authorList[this.menu.comboAuthors.SelectedIndex].GetInt("AuthorID");

        string query =
            "UPDATE books SET BookName=@bookName,AuthorID=@authorID,BookDescription=@bookDesc, BookPrice=@bookPrice,BookISBN=@bookISBN,QuantityRemain=@quantity WHERE BookID='" +
            (this.productIndex + 1) + "';";

        DatabaseHandler.instance.Execute(query, new MySqlParameter[]
        {
            new MySqlParameter("@bookName", bookName),
            new MySqlParameter("@authorID", AuthorID),
            new MySqlParameter("@bookDesc", bookDesc),
            new MySqlParameter("@bookPrice", bookPrice),
            new MySqlParameter("@bookISBN", bookISBN),
            new MySqlParameter("@quantity", remaining),
        });

        ProductObject product = Core.productList[this.productIndex];
        product.SetInt("BookID", this.productIndex + 1);
        product.SetString("BookName", bookName);
        product.SetInt("AuthorID", AuthorID);
        product.SetString("BookDescription", bookDesc);
        product.SetDouble("BookPrice", bookPrice);
        product.SetLong("BookISBN", bookISBN);
        product.SetInt("QuantityRemain", remaining);
        Core.productList[this.productIndex] = product;

        this.FetchProduct();
    }

    private void FetchProduct()
    {
        this.menu.comboAuthors.Items.Clear();
        for (var i = 0; i < Core.authorList.Count; i++)
        {
            this.menu.comboAuthors.Items.Add(Core.authorList[i].GetString("AuthorName"));
        }

        if (this.productIndex >= Core.productList.Count)
        {
            this.productIndex = Core.productList.Count - 1;
            this.menu.strBookName.Text = "";
            this.menu.strDesc.Text = "";
            this.menu.strISBN.Text = "";
            this.menu.strPrice.Text = "";
            this.menu.strRemaining.Text = "";
            this.menu.btnInsertProduct.Enabled = true;
            this.menu.btnUpdateProduct.Enabled = false;
            this.menu.btnHide.Visible = false;
            this.menu.btnUnhide.Visible = false;
            this.menu.comboAuthors.SelectedIndex = 0;
        }
        else
        {
            ProductObject po = Core.productList[this.productIndex];
            this.menu.strBookName.Text = po.GetString("BookName");
            this.menu.strDesc.Text = po.GetString("BookDescription");
            this.menu.strISBN.Text = "" + po.GetLong("BookISBN");
            this.menu.strPrice.Text = "" + po.GetDouble("BookPrice");
            this.menu.strRemaining.Text = "" + po.GetInt("QuantityRemain");
            this.menu.btnInsertProduct.Enabled = false;
            this.menu.btnUpdateProduct.Enabled = true;
            if (po.GetBool("Hidden"))
            {
                this.menu.btnHide.Visible = false;
                this.menu.btnUnhide.Visible = true;
            }
            else
            {
                this.menu.btnHide.Visible = true;
                this.menu.btnUnhide.Visible = false;
            }

            for (var i = 0; i < Core.authorList.Count; i++)
            {
                if (Core.authorList[i].GetInt("AuthorID") == po.GetInt("AuthorID"))
                {
                    this.menu.comboAuthors.SelectedIndex = i;
                }
            }
        }

        this.UpdateProductID();
    }

    public void Hide()
    {
        string query = "UPDATE books SET Hidden = 1 WHERE BookID='" + (this.productIndex + 1) + "';";
        DatabaseHandler.instance.Execute(query);
        ProductObject product = Core.productList[this.productIndex];
        product.SetBool("Hidden", true);
        Core.productList[this.productIndex] = product;
        this.FetchProduct();
    }

    public void UnHide()
    {
        string query = "UPDATE books SET Hidden = 0 WHERE BookID='" + (this.productIndex + 1) + "';";
        DatabaseHandler.instance.Execute(query);

        ProductObject product = Core.productList[this.productIndex];
        product.SetBool("Hidden", false);
        Core.productList[this.productIndex] = product;
        this.FetchProduct();
    }

    public void UpdateProductID()
    {
        this.menu.lblProductID.Text = "Product ID: " + (this.productIndex + 1);
    }
}

class CustomerTab
{
    private StaffMenu menu;

    private int customerIndex = 0;

    private DataTable customers;

    public CustomerTab(StaffMenu menu)
    {
        this.menu = menu;
        this.FetchCustomer();
    }

    private void FetchUserData()
    {
        this.customers = DatabaseHandler.instance.Fetch("SELECT * FROM customers");
    }

    public void NextItem()
    {
        this.customerIndex++;
        this.FetchCustomer();
    }

    public void PreviousItem()
    {
        if (this.customerIndex > 0)
        {
            this.customerIndex--;
            this.FetchCustomer();
        }
    }

    private void FetchCustomer()
    {
        this.FetchUserData();
        if (this.customerIndex >= this.customers.Rows.Count)
        {
            this.customerIndex = this.customers.Rows.Count;
            this.menu.strFirstName.Text = "";
            this.menu.strLastName.Text = "";
            this.menu.strPassword.Text = "";
            this.menu.strUserEmail.Text = "";
            this.menu.comboUserRole.SelectedIndex = 1;
        }
        else
        {
            DataRow dr = this.customers.Rows[this.customerIndex];
            this.menu.strFirstName.Text = (string) dr["FirstName"];
            this.menu.strLastName.Text = (string) dr["LastName"];
            this.menu.strPassword.Text = (string) dr["Password"];
            this.menu.strUserEmail.Text = (string) dr["Email"];
            this.menu.comboUserRole.SelectedIndex = (int) dr["Access"];
        }

        this.UpdateUserID();
    }

    public void UpdateUser()
    {
        string firstName = this.menu.strFirstName.Text;
        string lastName = this.menu.strLastName.Text;
        string password = this.menu.strPassword.Text;
        string email = this.menu.strUserEmail.Text;
        int userAccess = this.menu.comboUserRole.SelectedIndex;

        string query =
            "UPDATE customers SET FirstName=@firstname,LastName=@lastname,Password=@password, Email=@email,Access=@access WHERE CustomerID='" +
            (this.customerIndex + 1) + "';";

        DatabaseHandler.instance.Execute(query, new MySqlParameter[]
        {
            new MySqlParameter("@firstname", firstName),
            new MySqlParameter("@lastname", lastName),
            new MySqlParameter("@password", password),
            new MySqlParameter("@email", email),
            new MySqlParameter("@access", userAccess)
        });

        this.FetchCustomer();
    }

    private void UpdateUserID()
    {
        this.menu.lblUserID.Text = "User ID: " + (this.customerIndex + 1);
    }
}

class UserCart
{
    private StaffMenu menu;

    public UserCart(StaffMenu menu)
    {
        this.menu = menu;
        this.Initialize();
    }

    private void Initialize()
    {
        this.EmptyCart();
        this.CalculateTotal();

        Core.InitializeAuthors();
        Core.InitializeProducts();
        Core.InitializeCustomers();

        this.menu.comboProductCart.Items.Clear();
        this.menu.comboCustomerCart.Items.Clear();

        // Populate Combo Boxes
        for (var i = 0; i < Core.productList.Count; i++)
        {
            this.menu.comboProductCart.Items.Add(Core.productList[i].GetString("BookName"));
        }

        for (var i = 0; i < Core.customerList.Count; i++)
        {
            this.menu.comboCustomerCart.Items.Add(Core.customerList[i].GetString("Email"));
        }

    }

    public void EmptyCart()
    {
        this.menu.userCart.Items.Clear();
        this.CalculateTotal();
    }

    public void AddToCart()
    {
        this.menu.userCart.DisplayMember = "BookName";
        this.menu.userCart.ValueMember = "BookID";

        if (this.menu.comboProductCart.SelectedIndex >= 0)
        {
            this.menu.userCart.Items.Add(new Book
            {
                BookName = Core.productList[this.menu.comboProductCart.SelectedIndex].GetString("BookName"),
                BookID = Core.productList[this.menu.comboProductCart.SelectedIndex].GetInt("BookID")
            });
        }

        this.CalculateTotal();
    }

    public void Checkout()
    {
        if (this.menu.comboCustomerCart.SelectedIndex < 0)
        {
            MessageBox.Show("Please select a customer from the dropdown list.");
        } else if (this.menu.userCart.Items.Count == 0)
        {
            MessageBox.Show("Your Cart is empty");
        }
        else
        {
            int CustomerID = -1;
            for (int i = 0; i < Core.customerList.Count; i++)
            {
                if (Core.customerList[i].GetString("Email") == (string)this.menu.comboCustomerCart.SelectedItem)
                {
                    CustomerID = Core.customerList[i].GetInt("CustomerID");
                }
            }

            if (CustomerID == -1)
            {
                Core.Info("Couldn't find a Customer with that email.");
            }
            else
            {
                for (int i = 0; i < this.menu.userCart.Items.Count; i++)
                {
                    Book tempBook = this.menu.userCart.Items[i] as Book;
                    string query = "INSERT INTO sales(CustomerID, BookID) VALUES (@customerID, @bookID);";
                    DatabaseHandler.instance.Execute(query, new MySqlParameter[]
                    {
                        new MySqlParameter("@customerID", CustomerID),
                        new MySqlParameter("@bookID", tempBook.BookID)
                    });

                    DatabaseHandler.instance.Execute(
                        "UPDATE books SET QuantityRemain=QuantityRemain-1 WHERE BookID=@bookID",
                        new MySqlParameter("@bookID", tempBook.BookID));

                }

                this.EmptyCart();
            }
        }
    }

    private void CalculateTotal()
    {
        var cost = 0.00;
        for (var i = 0; i < this.menu.userCart.Items.Count; i++)
        {
            var temp = this.menu.userCart.Items[i] as Book;
            int productID = temp.BookID;
            for (var a = 0; a < Core.productList.Count; a++)
            {
                if (Core.productList[a].GetInt("BookID") == productID)
                {
                    cost += Core.productList[a].GetDouble("BookPrice");
                }
            }
        }

        this.menu.lblTotalCost.Text = "£" + cost;
    }

    public void Refresh()
    {
        this.Initialize();
    }
}

class Book
{
    public string BookName { get; set; }
    public int BookID { get; set; }
}