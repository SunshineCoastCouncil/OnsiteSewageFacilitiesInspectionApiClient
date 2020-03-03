using System;

namespace OnsiteSewageFacilitiesInspectionApiClient.Models
{
    public class Inspection
    {
        public OSF OSF { get; set; }

        public DateTime ServiceDateTime { get; set; }

        public string TesterFirstName { get; set; }
        public string TesterLastName { get; set; }
        public string TesterLicenceNo { get; set; }

        public string TesterComments { get; set; }

        public bool? ProblemIdentified { get; set; }

        public string InspectionTypeId { get; set; }
        public string InspectionTypeDescription { get; set; }

        public string InspectionResultId { get; set; }
        public string InspectionResultDescription { get; set; }

        /// <summary>
        /// Single or multiple Cause IDs (separated by comma) are accepted
        /// </summary>
        public string CauseId { get; set; }
        public string CauseDescription { get; set; }

        public string AlarmConditionId { get; set; }
        public string AlarmConditionDescription { get; set; }

        public string DisposalConditionId { get; set; }
        public string DisposalConditionDescription { get; set; }

        public string SludgeConditionId { get; set; }
        public string SludgeConditionDescription { get; set; }

        /// <summary>
        /// Report as a Base64 string
        /// </summary>
        public string Report { get; set; }
        /// <summary>
        /// The name of the report file
        /// </summary>
        public string ReportFilename { get; set; }
    }
}
