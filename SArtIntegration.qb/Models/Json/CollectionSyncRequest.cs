using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SArtIntegration.qb.Models.Json
{
    public class CollectionSyncRequest
    {
        public IntegratedCollection[] IntegratedCollections { get; set; }
        public class IntegratedCollection
        {
            public long customerFinancialTransactionId { get; set; }
            public bool synced { get; set; }
            public string message { get; set; }
        }
    }
}
