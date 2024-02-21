using System.Configuration;

namespace SArtIntegration.qb.Manager.Config
{
    public static class Configuration
    {
        public static string GetUrl()
        {
            return ConfigurationManager.AppSettings["URL"];
        }
        public static string getCollectionIsAutoApply()
        {
            return ConfigurationManager.AppSettings["collectionIsAutoApply"];
        }
    }
}
