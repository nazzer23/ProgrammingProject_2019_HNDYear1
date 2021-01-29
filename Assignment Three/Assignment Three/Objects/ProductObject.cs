namespace Assignment_Three.Objects
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using Handlers;

    public class ProductObject
    {
        private readonly Dictionary<string, object> _productDictionary = new Dictionary<string, object>();

        public ProductObject()
        {
            LogHandler.Log("Constructing a new ProductObject");
        }
        public ProductObject(DataColumnCollection columnData, DataRow dataRow)
        {
            LogHandler.Log("Constructing a new ProductObject");

            for (var i = 0; i < columnData.Count; i++)
            {
                DataColumn dc = columnData[i];
                this._productDictionary.Add(dc.ColumnName.ToLower(), dataRow[i]);
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
                if (this._productDictionary.ContainsKey(key.ToLower()))
                {
                    return (string) this._productDictionary[key.ToLower()];
                }

                throw new NullReferenceException();
            }
            catch (Exception e)
            {
                LogHandler.Log("ProductObject 'GetString' Exception - " + e.Message, LogTypes.WARNING);
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
                if (this._productDictionary.ContainsKey(key.ToLower()))
                {
                    return (int) Convert.ToInt32(this._productDictionary[key.ToLower()]);
                }

                throw new NullReferenceException();
            }
            catch (Exception e)
            {
                LogHandler.Log("ProductObject 'GetInt' Exception - " + e.Message, LogTypes.WARNING);
            }

            return 0;
        }

        /// <summary>
        ///     Pulls a <c>integer</c> from the Dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public long GetLong(string key)
        {
            try
            {
                if (this._productDictionary.ContainsKey(key.ToLower()))
                {
                    return Convert.ToInt64(this._productDictionary[key.ToLower()]);
                }

                throw new NullReferenceException();
            }
            catch (Exception e)
            {
                LogHandler.Log("ProductObject 'GetInt' Exception - " + e.Message, LogTypes.WARNING);
            }

            return 0;
        }

        /// <summary>
        ///     Pulls a <c>double</c> from the Dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public double GetDouble(string key)
        {
            try
            {
                if (this._productDictionary.ContainsKey(key.ToLower()))
                {
                    return (double) Convert.ToDouble(this._productDictionary[key.ToLower()]);
                }

                throw new NullReferenceException();
            }
            catch (Exception e)
            {
                LogHandler.Log("ProductObject 'GetDouble' Exception - " + e.Message, LogTypes.WARNING);
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
                if (this._productDictionary.ContainsKey(key.ToLower()))
                {
                    return (bool) this._productDictionary[key.ToLower()];
                }
            }
            catch (Exception e)
            {
                LogHandler.Log("ProductObject 'GetBool' Exception - " + e.Message, LogTypes.WARNING);
            }

            return false;
        }

        public void SetBool(string key, bool value)
        {
            this._productDictionary[key.ToLower()] = value;
        }

        public void SetInt(string key, int value)
        {
            this._productDictionary[key.ToLower()] = value;
        }

        public void SetDouble(string key, double value)
        {
            this._productDictionary[key.ToLower()] = value;
        }

        public void SetLong(string key, long value)
        {
            this._productDictionary[key.ToLower()] = value;
        }

        public void SetString(string key, string value)
        {
            this._productDictionary[key.ToLower()] = value;
        }
    }
}