using System;
using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        private Dictionary<string, string> _dictionary;
        // key and values should both be strings

        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        // declare an indexer
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}