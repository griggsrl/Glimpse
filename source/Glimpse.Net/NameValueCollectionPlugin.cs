﻿using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web;
using Glimpse.Protocol;

namespace Glimpse.Net
{
    public abstract class NameValueCollectionPlugin : IGlimpsePlugin
    {
        public abstract object GetData(HttpApplication application);
        public abstract string Name { get; }

        protected IDictionary<string, string> Process(NameValueCollection collection, HttpApplication application)
        {
            var result = new Dictionary<string, string>();
            foreach (var key in collection.AllKeys)
            {
                result.Add(key,collection[key]);
            }

            if (result.Count == 0) return null;

            return result;
        }
    }
}