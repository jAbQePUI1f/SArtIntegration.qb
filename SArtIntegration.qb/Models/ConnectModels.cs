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
        public string ticket { get; set; }
        public RequestProcessor2 rp { get; set; }
        public string maxVersion { get; set; }
        public QBFileMode mode { get; set; }



    }
}
