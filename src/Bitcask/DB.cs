using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitcask
{
    public abstract class DB
    {
        private string _dbName;
        private Options _options;

        public DB(string dbName, Options options)
        {
            _dbName = dbName;
            _options = options;
        }

        public abstract bool Put(string key, string value);
        public abstract string Get(string key); 
        public abstract bool Delete(string key);
    }
}
