namespace SArtIntegration.qb.Models.Json
{
    public class CollectionSyncRequest
    {
        public IntegratedCollection[] integratedCollections { get; set; }
        public class IntegratedCollection
        {
            public string ficheNo { get; set; }
            public bool successfullyIntegrated { get; set; }
            public string remoteCollectionNumber { get; set; }
            public string errorMessage { get; set; }
        }
    }
}
