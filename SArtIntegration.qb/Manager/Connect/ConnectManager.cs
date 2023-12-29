using Interop.QBXMLRP2;
using SArtIntegration.qb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SArtIntegration.qb.Manager.Connect
{
    public class ConnectManager
    {

        private static string appID = "SArt1";
        private static string appName = "SalesArtIntegration";

        public ConnectModels connectToQB()
        {
            ConnectModels connectModels = new ConnectModels();

            connectModels.rp = new RequestProcessor2(); //new RequestProcessor2Class();
            connectModels.rp.OpenConnection(appID, appName);
            connectModels.ticket = connectModels.rp.BeginSession("", connectModels.mode);
            string[] versions = connectModels.rp.get_QBXMLVersionsForSession(connectModels.ticket);
            connectModels.maxVersion = versions[versions.Length - 1];

            return connectModels;
        }
        public void disconnectFromQB(ConnectModels connect)
        {
            if (connect.ticket != null)
            {
                try
                {
                    connect.rp.EndSession(connect.ticket);
                    connect.ticket = null;
                    connect.rp.CloseConnection();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public string processRequestFromQB(ConnectModels connect,string request)
        {
            try
            {
                return connect.rp.ProcessRequest(connect.ticket, request);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
