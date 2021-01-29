namespace Assignment_Three.Handlers
{
    using System.Collections.Generic;
    using System.Data;
    using MySql.Data.MySqlClient;

    public class DatabaseHandler
    {
        public static DatabaseHandler instance;

        private readonly Dictionary<string, object> _connectionStringValues = new Dictionary<string, object>();
        public MySqlConnection mysqlConnection;

        /// <summary>
        ///     Constructor for the database handler class
        /// </summary>
        public DatabaseHandler()
        {
            instance = this;
        }

        /// <summary>
        ///     Allows initialization of class to be performed during the startup sequence
        /// </summary>
        public void Init()
        {
            Core.splashForm.IncrementLoadingProgressMax();
            Core.splashForm.SetProgressLabel("Initializing Database Handler");

            // Add the default connection values from the configuration file
            this.DefaultConnectionValues();

            // Initiate Database Object
            this.mysqlConnection = new MySqlConnection(this.ConstructConnectionString());

            // Perform Database Test
            this.PerformBasicTests();

            Core.splashForm.UpdateProgress();
        }

        /// <summary>
        ///     Performs tasks to ensure that queries are tested to ensure that all of the required tables exist within the
        ///     database
        /// </summary>
        private void PerformBasicTests()
        {
            Core.splashForm.IncrementLoadingProgressMax();
            Core.splashForm.SetProgressLabel("Testing the Databases authenticity");
            LogHandler.Log("Performing Database Tests.");
            new Test("SELECT * FROM authors;");
            new Test("SELECT * FROM books;");
            new Test("SELECT * FROM customers;");
            new Test("SELECT * FROM sales;");
            //new Test("SELECT * FROM failme;");
            Core.splashForm.SetProgressLabel("Database Tests Completed.");
            LogHandler.Log("All tests succeeded.", LogTypes.SUCCESS);
            Core.splashForm.UpdateProgress();
        }

        /// <summary>
        ///     Initializes the directory with the default connection values pulled from the configuration file.
        /// </summary>
        private void DefaultConnectionValues()
        {
            /*
             * @String MySQL Host
             * @String Value brought from the Configuration File
             */
            this.AddConnectionStringValue(
                "server",
                ConfigHandler.GetString("mysqlHost")
            );

            /*
             * @String MySQL Database
             * @String Value brought from the Configuration File
             */
            this.AddConnectionStringValue(
                "database",
                ConfigHandler.GetString("mysqlDb")
            );

            /*
             * @String MySQL Username
             * @String Value brought from the Configuration File
             */
            this.AddConnectionStringValue(
                "uid",
                ConfigHandler.GetString("mysqlUser")
            );

            /*
             * @String MySQL Password
             * @String Value brought from the Configuration File
             */
            this.AddConnectionStringValue(
                "password",
                ConfigHandler.GetString("mysqlPass")
            );

            /*
             * @String MySQL Port
             * @String Value brought from the Configuration File
             */
            this.AddConnectionStringValue(
                "port",
                ConfigHandler.GetInt("mysqlPort")
            );
        }

        /// <summary>
        ///     Connects to the database
        /// </summary>
        private bool OpenConnection()
        {
            try
            {
                this.mysqlConnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Core.Error("Database Connection failed. Please contact the system administrator.");
                        break;
                    case 1045:
                        Core.Error(
                            "Database Connection failed. The Username and Password combination supplied is incorrect. Please try again later.");
                        break;
                    default:
                        Core.Error(ex.Message);
                        break;
                }

                return false;
            }
        }

        private void CloseConnection()
        {
            try
            {
                this.mysqlConnection.Close();
            }
            catch (MySqlException ex)
            {
                Core.Error(ex.Message);
            }
        }

        /// <summary>
        ///     Adds connection string key and values to the dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        private void AddConnectionStringValue(string key, object value)
        {
            LogHandler.Log("Key -> " + key + "; Value -> " + value + ";", LogTypes.DEBUG);
            this._connectionStringValues[key.ToUpper()] = value;
        }

        /// <summary>
        ///     Initiates shutdown for a graceful shutdown
        /// </summary>
        public void Shutdown()
        {
            LogHandler.Log("Shutting down DatabaseHandler gracefully");
            if (this.mysqlConnection != null)
            {
                if (this.mysqlConnection.State != ConnectionState.Closed)
                {
                    this.CloseConnection();
                }
            }

            LogHandler.Log("DatabaseHandler has been shutdown");
        }

        /// <summary>
        ///     Constructs a connection string from the keys and values that are within the dictionary
        /// </summary>
        /// <returns></returns>
        private string ConstructConnectionString()
        {
            var value = "";
            foreach (KeyValuePair<string, object> f in this._connectionStringValues)
            {
                value += f.Key + "=" + f.Value + ";";
            }

            return value;
        }

        public DataTable Fetch(string query)
        {
            var dt = new DataTable();

            if (this.OpenConnection())
            {
                var cmd = new MySqlCommand(query, this.mysqlConnection);
                dt.Load(cmd.ExecuteReader());
                this.CloseConnection();
            }

            return dt;
        }

        public void Execute(string query)
        {
            if (this.OpenConnection())
            {
                var command = new MySqlCommand(query, this.mysqlConnection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void Execute(string query, params MySqlParameter[] parameters)
        {
            if (this.OpenConnection())
            {
                var command = new MySqlCommand(query, this.mysqlConnection);
                for (int i = 0; i < parameters.Length; i++)
                {
                    command.Parameters.Add(parameters[i]);
                }
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        ///     Pulls the amount of rows that are within the data table
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public int GetNumberOfRows(string query)
        {
            return this.Fetch(query).Rows.Count;
        }
    }

    class Test
    {
        private readonly string _test;

        /// <summary>
        ///     Takes in a query into the constructor to perform a task
        /// </summary>
        /// <param name="query"></param>
        public Test(string query)
        {
            this._test = query;
            this.ExecuteTest();
        }

        /// <summary>
        ///     Executes a test
        /// </summary>
        private void ExecuteTest()
        {
            try
            {
                Core.splashForm.IncrementLoadingProgressMax();
                if (ConfigHandler.GetBool("debug"))
                {
                    Core.splashForm.SetProgressLabel("[Database Test] " + this._test);
                }

                LogHandler.Log("[Test] Performing test (" + this._test + ")", LogTypes.DEBUG);

                // This is where it will fail if the query cannot be executed
                DatabaseHandler.instance.Fetch(this._test);

                LogHandler.Log("[Test] (" + this._test + ") Succeeded", LogTypes.DEBUG);
                Core.splashForm.UpdateProgress();
            }
            catch (MySqlException ex)
            {
                Core.Error("[Test] There was an error when executing the test queries. Error:" + ex.Message);
            }
        }
    }
}