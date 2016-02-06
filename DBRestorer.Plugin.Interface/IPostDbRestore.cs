using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRestorer.Plugin.Interface
{
    public interface IPostDbRestore 
    {
        void OnDBRestored(string sqlInstName, string dbName);
    }
}
