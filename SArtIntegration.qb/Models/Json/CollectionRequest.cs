﻿namespace SArtIntegration.qb.Models.Json
{
    public class CollectionRequest
    {
        public CollectionRequest() { }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string[] transactionTypes { get; set; }
    }
}
