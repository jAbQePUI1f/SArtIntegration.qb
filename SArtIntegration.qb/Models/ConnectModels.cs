using Interop.QBXMLRP2;

namespace SArtIntegration.qb.Models
{
    public class ConnectModels
    {
        public  string Ticket { get; set; }
        public  RequestProcessor2 Rp { get; set; }
        public  string MaxVersion { get; set; }
        public QBFileMode Mode { get; set; }
    }
}
