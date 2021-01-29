namespace Assignment_Three.Objects
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using Handlers;

    public class UserObject
    {
        private readonly Dictionary<string, object> _userData = new Dictionary<string, object>();

        /// <summary>
        ///     Constructor for UserObject
        ///     Access [0 -> Banned] [1 -> Customer] [2 -> Staff] [3 -> Manager]
        /// </summary>
        /// <param name="userDataTable"></param>
        public UserObject(DataColumnCollection userDataTable, DataRow userDataRow)
        {
            LogHandler.Log("Constructing a new UserObject");

            for (var i = 0; i < userDataTable.Count; i++)
            {
                DataColumn dc = userDataTable[i];
                this._userData.Add(dc.ColumnName.ToLower(), userDataRow[i]);
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
                if (this._userData.ContainsKey(key.ToLower()))
                {
                    return (string) this._userData[key.ToLower()];
                }

                throw new NullReferenceException();
            }
            catch (Exception e)
            {
                LogHandler.Log("UserObject 'GetString' Exception - " + e.Message, LogTypes.WARNING);
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
                if (this._userData.ContainsKey(key.ToLower()))
                {
                    return (int) this._userData[key.ToLower()];
                }

                throw new NullReferenceException();
            }
            catch (Exception e)
            {
                LogHandler.Log("UserObject 'GetInt' Exception - " + e.Message, LogTypes.WARNING);
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
                LogHandler.Log("UserObject 'GetBool' Exception - " + e.Message, LogTypes.WARNING);
            }

            return false;
        }
    }
}