using Interop.QBXMLRP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
