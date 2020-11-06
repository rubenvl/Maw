using System.Configuration;

namespace Maw.Helpers
{
    public static class ConfigHelper
    {
        public static string GetConnectionString(string name) =>
            ConfigurationManager.ConnectionStrings[name].ConnectionString;
        public static string GetConfigValue(string name) => ConfigurationManager.AppSettings.Get(name);
    }
}
