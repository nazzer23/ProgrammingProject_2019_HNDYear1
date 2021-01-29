namespace Assignment_Three
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading;
    using System.Windows.Forms;
    using Handlers;
    using Objects;
    using UI;

    public class Core
    {
        /* Booleans */
        public static bool startup;

        /* Strings */
        public static readonly string programStartTime = DateTime.Now.ToFileTime().ToString();
        public static readonly string configFile = "conf/config.conf";

        /* Class Instances */
        public static DatabaseHandler databaseHandler;
        public static UserObject userObject = null;

        /* Form Instances */
        public static Splash splashForm;
        public static LoginForm loginForm;
        public static StaffMenu staffMenuForm;

        /* Threads */
        public static Thread splashThread;
        public static Thread loginFormThread;
        public static Thread staffMenuThread;

        /* DataSet Lists */
        public static List<AuthorObject> authorList = new List<AuthorObject>();
        public static List<ProductObject> productList = new List<ProductObject>();
        public static List<UserObject> customerList = new List<UserObject>();

        /// <summary>
        ///     Core Environment Initialization Sequence
        /// </summary>
        public static void Init()
        {
            // Initialize Database Object
            databaseHandler = new DatabaseHandler();

            // Initiate Form Sets
            InitForms();

            // Initiate Boot Sequence
            PerformSplashStartup();

            // Initialize Login Screen
            LoginPrompt();
        }

        /// <summary>
        ///     Initializes Forms for the Application.
        /// </summary>
        private static void InitForms()
        {
            // Instantiates Form Variables
            splashForm = new Splash();
            loginForm = new LoginForm();

            // Initiates Form Threads
            splashThread = new Thread(() => { Application.Run(splashForm); });
            loginFormThread = new Thread(() => { Application.Run(loginForm); });
        }

        /// <summary>
        ///     Initializes the Core Environmental Splash Screen Startup
        /// </summary>
        private static void PerformSplashStartup()
        {
            startup = true;

            splashForm.SetLoadingProgressMax(0);

            // Show Splash on new Thread
            splashThread.Start();

            // Initialize Configuration
            splashForm.IncrementLoadingProgressMax();
            splashForm.SetProgressLabel("Initializing Configuration Files");
            ConfigHandler.Init();
            splashForm.UpdateProgress();

            // Connect to Database
            splashForm.IncrementLoadingProgressMax();
            databaseHandler.Init();
            splashForm.UpdateProgress();

            // Initialize DataSets
            splashForm.IncrementLoadingProgressMax();
            InitializeAuthors();
            splashForm.UpdateProgress();
            splashForm.IncrementLoadingProgressMax();
            InitializeProducts();
            splashForm.UpdateProgress();

            // Close Splash
            startup = false;
            splashForm.UpdateProgress();
            splashThread.Abort();
        }

        /// <summary>
        ///     Initiates all checks to ensure that the user can login.
        /// </summary>
        private static void LoginPrompt()
        {
            loginFormThread.Start();
        }

        public static void InitializeAuthors()
        {
            authorList.Clear();
            DataTable authorsTable = databaseHandler.Fetch("SELECT * FROM authors");
            for (int i = 0; i < authorsTable.Rows.Count; i++)
            {
                DataRow dr = authorsTable.Rows[i];

                AuthorObject ao = new AuthorObject(authorsTable.Columns, dr);

                Core.authorList.Add(ao);
            }
        }

        public static void InitializeProducts()
        {
            productList.Clear();
            DataTable bookTable = databaseHandler.Fetch("SELECT * FROM books");
            for (int i = 0; i < bookTable.Rows.Count; i++)
            {
                DataRow dr = bookTable.Rows[i];

                ProductObject ao = new ProductObject(bookTable.Columns, dr);

                Core.productList.Add(ao);
            }
        }

        public static void InitializeCustomers()
        {
            customerList.Clear();
            DataTable bookTable = databaseHandler.Fetch("SELECT * FROM customers");
            for (int i = 0; i < bookTable.Rows.Count; i++)
            {
                DataRow dr = bookTable.Rows[i];

                UserObject ao = new UserObject(bookTable.Columns, dr);

                customerList.Add(ao);
            }
        }

        /// <summary>
        ///     Shuts down the application gracefully through the Core.Shutdown Method
        /// </summary>
        public static void Shutdown()
        {
            databaseHandler.Shutdown();
            Environment.Exit(1);
        }

        /// <summary>
        ///     Allows Forms to trigger the shutdown even when the form closes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void ShutdownEvent(object sender, FormClosingEventArgs e)
        {
            LogHandler.Log("Event Triggered closing of application.");
            Shutdown();
        }

        /// <summary>
        ///     If in the event of a fatal error, call this method
        ///     This method will error log the error and then perform a graceful shutdown.
        /// </summary>
        /// <param name="message"></param>
        public static void Error(string message)
        {
            LogHandler.Log(message, LogTypes.ERROR);
            MessageBox.Show(
                message,
                @"Fatal Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
            );
            Shutdown();
        }

        /// <summary>
        ///     Popups an Info MessageBox and logs the message to the Log File
        /// </summary>
        /// <param name="message"></param>
        /// <param name="form"></param>
        /// <param name="logMsg"></param>
        public static void Info(string message, Form form = null, string logMsg = null)
        {
            LogHandler.Log(logMsg ?? message);
            MessageBox.Show(
                message,
                @"Oops",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
            );
            if (form == null) return;
            form.WindowState = FormWindowState.Minimized;
            form.Show();
            form.WindowState = FormWindowState.Normal;
        }
    }
}