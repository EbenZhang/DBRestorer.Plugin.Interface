using System.Windows;

namespace DBRestorer.Plugin.Interface
{
    public interface IPostDbRestore 
    {
        void OnDBRestored(Window parentWnd, string sqlInstName, string dbName);
        string PluginName { get; }
    }
}
