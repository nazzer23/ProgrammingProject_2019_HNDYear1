namespace Assignment_Three.Objects
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using Handlers;

    public class AuthorObject
    {
        private readonly Dictionary<string, object> _authorDictionary = new Dictionary<string, object>();

        public AuthorObject(DataColumnCollection columnData, DataRow dataRow)
        {
            LogHandler.Log("Constructing a new AuthorObject");

            for (var i = 0; i < columnData.Count; i++)
            {
                DataColumn dc = columnData[i];
                this._authorDictionary.Add(dc.ColumnName.ToLower(), dataRow[i]);
            }
        }

        /// <summary>
        ///     Pulls a <c>string</c> from the Dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetString(string key)
        {
            try
            {
                if (this._authorDictionary.ContainsKey(key.ToLower()))
                {
                    return (string) this._authorDictionary[key.ToLower()];
                }

                throw new NullReferenceException();
            }
            catch (Exception e)
            {
                LogHandler.Log("AuthorObject 'GetString' Exception - " + e.Message, LogTypes.WARNING);
            }

            return "";
        }

        /// <summary>
        ///     Pulls a <c>integer</c> from the Dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int GetInt(string key)
        {
            try
            {
                if (this._authorDictionary.ContainsKey(key.ToLower()))
                {
                    return (int) this._authorDictionary[key.ToLower()];
                }

                throw new NullReferenceException();
            }
            catch (Exception e)
            {
                LogHandler.Log("AuthorObject 'GetInt' Exception - " + e.Message, LogTypes.WARNING);
            }

            return 0;
        }

        /// <summary>
        ///     Pulls a <c>boolean</c> from the Dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool GetBool(string key)
        {
            try
            {
                return bool.Parse(this.GetString(key));
            }
            catch (Exception e)
            {
                LogHandler.Log("AuthorObject 'GetBool' Exception - " + e.Message, LogTypes.WARNING);
            }

            return false;
        }
    }
}