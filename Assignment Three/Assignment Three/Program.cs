namespace Assignment_Three
{
    using System;
    using System.Windows.Forms;

    static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize Core Environment
            Core.Init();
        }
    }
}