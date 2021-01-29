namespace Assignment_Three.Handlers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class ConfigHandler
    {
        // Private Variables
        private static readonly Dictionary<string, object> values = new Dictionary<string, object>();

        /// <summary>
        ///     Initialization of the Configuration Handler
        /// </summary>
        public static void Init()
        {
            try
            {
                LogHandler.Log("Loading Configuration File '" + Core.configFile + "'");
                if (File.Exists(Core.configFile))
                {
                    LogHandler.Log("Found Configuration File '" + Core.configFile + "'", LogTypes.SUCCESS);
                    var streamReader = new StreamReader(Core.configFile);
                    var counter = 0;
                    while (!streamReader.EndOfStream)
                    {
                        counter++;

                        Core.splashForm.IncrementLoadingProgressMax();
                        Core.splashForm.SetProgressLabel("Reading Line #" + counter + " of the configuration file");

                        string line = streamReader.ReadLine();

                        const char configDelimiter = '=';
                        const char configComment = '#';

                        // This check sees if the line doesn't start with a @configComment and contains @configDelimiter
                        if (line != null && !line.StartsWith("" + configComment) && line.Contains(configDelimiter))
                        {
                            // Splits the string into a string array based on the value within the config delimiter
                            string[] temp = line.Split(configDelimiter);

                            /*
                             * @String[] temp is an object array 
                             * @String temp[0].toLower() -> Dictionary Key forced to be lowercase
                             * @String temp[1] -> Dictionary Value
                             */
                            values.Add(temp[0].ToLower(), temp[1]);
                        }

                        Core.splashForm.UpdateProgress();
                    }

                    /*
                     * Closes the stream reader therefore preventing data corruption and releasing the object from memory.
                     * Once a reader has been closed, it isn't possible to reopen the stream.
                     **/
                    streamReader.Close();
                    LogHandler.Log("ConfigHandler initialized", LogTypes.SUCCESS);
                    LogHandler.Log("ConfigHandler initialized with " + values.Keys.Count + " KeyPairs.",
                        LogTypes.DEBUG);
                }
                else
                {
                    LogHandler.Log("Configuration File wasn't found.", LogTypes.WARNING);
                    throw new FileNotFoundException();
                }
            }
            catch (Exception e)
            {
                LogHandler.Log("ConfigHandler Exception - " + e.Message, LogTypes.WARNING);
                Core.Error("There was an error whilst initializing the ConfigHandler");
            }
        }

        /// <summary>
        ///     Pulls a <c>string</c> from the Configuration Dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetString(string key)
        {
            try
            {
                if (values.ContainsKey(key.ToLower()))
                {
                    return (string) values[key.ToLower()];
                }

                throw new NullReferenceException();
            }
            catch (Exception e)
            {
                LogHandler.Log("ConfigHandler 'GetString' Exception - " + e.Message, LogTypes.WARNING);
            }

            return "";
        }

        /// <summary>
        ///     Pulls a <c>integer</c> from the Configuration Dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int GetInt(string key)
        {
            try
            {
                return int.Parse(GetString(key));
            }
            catch (Exception e)
            {
                LogHandler.Log("ConfigHandler 'GetInt' Exception - " + e.Message, LogTypes.WARNING);
            }

            return 0;
        }

        /// <summary>
        ///     Pulls a <c>boolean</c> from the Configuration Dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool GetBool(string key)
        {
            try
            {
                return bool.Parse(GetString(key));
            }
            catch (Exception e)
            {
                LogHandler.Log("ConfigHandler 'GetBool' Exception - " + e.Message, LogTypes.WARNING);
            }

            return false;
        }
    }
}