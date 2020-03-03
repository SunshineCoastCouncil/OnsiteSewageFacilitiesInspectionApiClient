using System;

namespace OnsiteSewageFacilitiesInspectionApiClient.Models
{
    public class OSF
    {
        /// <summary>
        /// This code is provided by SCC
        /// </summary>
        public string VendorMappingInUse { get; set; }
        public string ApplicationNumber { get; set; }
        public int? ProcessId { get; set; }
        public int? PropertyId { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }

        public string DisposalTypeId { get; set; }
        public string DisposalTypeDescription { get; set; }

        public string SystemTypeId { get; set; }
        public string SystemTypeDescription { get; set; }

        public string ServiceIntervalId { get; set; }
        public string ServiceIntervalDescription { get; set; }

        public string SerialNumber { get; set; }
        public DateTime? LastServiceDateTime { get; set; }
    }
}
