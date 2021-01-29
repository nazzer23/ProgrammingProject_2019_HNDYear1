namespace Assignment_Three.UI
{
    using System;
    using System.Data;
    using System.Threading;
    using System.Windows.Forms;
    using Handlers;
    using Objects;

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            this.InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Calls the ShutdownEvent function that is situation within the Core Class. This is because FormClosing is an event.
            this.FormClosing += Core.ShutdownEvent;

            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = this.strUsername.Text;
            string Password = this.strPassword.Text;

            if (Username == "")
            {
                Core.Info("Please enter an email.", this);
            }
            else if (Password == "")
            {
                Core.Info("Please enter a password.", this);
            }
            else
            {
                string loginQuery = "SELECT * FROM customers WHERE Email LIKE '" + Username + "' AND Password = '" +
                                    Password + "'";
                DataTable userDataTable = DatabaseHandler.instance.Fetch(loginQuery);

                if (userDataTable.Rows.Count <= 0)
                {
                    Core.Info("The Email and Password combination used was incorrect.", this);
                }
                else
                {
                    DataRow userData = userDataTable.Rows[0];
                    var userAccess = (int) userData["Access"];
                    if (userAccess <= 1)
                    {
                        Core.Info("You are not permitted to access this application.", this,
                            Username + " tried to access the application.");
                    }
                    else
                    {

                        Core.userObject = new UserObject(
                            userDataTable.Columns,
                            userData
                        );

                        Core.staffMenuForm = new StaffMenu();

                        Core.staffMenuThread = new Thread(() => { Application.Run(Core.staffMenuForm); });

                        Core.staffMenuThread.Start();

                        LogHandler.Log(Username + " has logged in.");

                        this.Dispose();
                    }
                }
            }
        }
    }
}