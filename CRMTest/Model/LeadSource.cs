﻿namespace CRMTest.Model
{
    public class LeadSource
    {
        public int Id { get; set; }
        public int lead_id { get; set; }
        public int source_id { get; set; }
        public Leads leads { get; set; }
        public Source source { get; set; }
    }
}
