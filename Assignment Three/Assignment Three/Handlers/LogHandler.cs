namespace Assignment_Three.Handlers
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    class LogHandler
    {
        /// <summary>
        ///     Constructs a log message and logs to the console and log file
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="type"></param>
        /// <param name="filepath"></param>
        /// <param name="memberName"></param>
        public static void Log(string msg, LogTypes type = LogTypes.INFO, [CallerFilePath] string filepath = "",
            [CallerMemberName] string memberName = "")
        {
            string prefix;
            switch (type)
            {
                case LogTypes.SUCCESS:
                    prefix = "Success";
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case LogTypes.WARNING:
                    prefix = "Warning";
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case LogTypes.DEBUG:
                    prefix = "Debug";
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (!ConfigHandler.GetBool("debug"))
                    {
                        return;
                    }

                    break;
                case LogTypes.ERROR:
                    prefix = "Error";
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case LogTypes.INFO:
                default:
                    prefix = "Info";
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }

            const string outputFormat = "[{0}] [{3}] [{1}]: ({4}) {2}";
            Console.WriteLine(outputFormat, prefix.ToUpper(), DateTime.Now, msg, GetClassFromFilePath(filepath),
                memberName);
            LogToFile(outputFormat, prefix.ToUpper(), DateTime.Now, msg, GetClassFromFilePath(filepath), memberName);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        ///     Logs to a log file
        /// </summary>
        /// <param name="format"></param>
        /// <param name="a"></param>
        private static void LogToFile(string format, params object[] a)
        {
            string logFile = "logs/log-" + Core.programStartTime + ".txt";
            if (!Directory.Exists(@"logs"))
            {
                Directory.CreateDirectory(@"logs");
            }

            if (!File.Exists(logFile))
            {
                File.CreateText(logFile).Close();
            }

            var streamWriter = new StreamWriter(logFile, true);
            streamWriter.WriteLine(format, a);
            streamWriter.Close();
        }

        private static string GetClassFromFilePath(string filepath)
        {
            string[] fileArr = filepath.Split('\\');
            string name = fileArr[fileArr.Length - 1].Split(new[] {".cs"}, StringSplitOptions.None)[0];
            return name;
        }
    }

    enum LogTypes
    {
        SUCCESS,
        WARNING,
        ERROR,
        DEBUG,
        INFO
    }
}