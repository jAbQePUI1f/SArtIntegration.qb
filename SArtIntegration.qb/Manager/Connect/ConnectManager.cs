using Interop.QBXMLRP2;
using SArtIntegration.qb.Models;

namespace SArtIntegration.qb.Manager.Connect
{
    public class ConnectManager
    {
        private static readonly string appID = "SArt1";
        private static readonly string appName = "SalesArtIntegration";
        public static ConnectModels ConnectToQB()
        {
            try
            {
                ConnectModels connectModels = new ConnectModels()
                {
                    Rp = new RequestProcessor2() //new RequestProcessor2Class();
                };

                connectModels.Rp.OpenConnection(appID, appName);
                connectModels.Ticket = connectModels.Rp.BeginSession("", connectModels.Mode);
                string[] versions = connectModels.Rp.get_QBXMLVersionsForSession(connectModels.Ticket);
                connectModels.MaxVersion = versions[versions.Length - 1];

                return connectModels;
            }
            catch (Exception)
            {
                ConnectModels connectModelss = new ConnectModels();
                connectModelss.Ticket = "";

                return connectModelss;
            }          
        }
        public static void DisconnectFromQB(ConnectModels connect)
        {
            if (connect.Ticket != null)
            {
                try
                {
                    connect.Rp.EndSession(connect.Ticket);
                    connect.Ticket = null;
                    connect.Rp.CloseConnection();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public static string ProcessRequestFromQB(ConnectModels connect,string request)
        {
            try
            {
                return connect.Rp.ProcessRequest(connect.Ticket, request);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
