using System;
using System.Linq;
using System.Threading.Tasks;
using OnsiteSewageFacilitiesInspectionApiClient;
using OnsiteSewageFacilitiesInspectionApiClient.Models;

namespace OnsiteSewageFacilitiesInspectionApiClientSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var inspection = new Inspection
            {
                OSF = new OSF
                {
                    VendorMappingInUse = "SCCTest",
                    ApplicationNumber = "",
                    ProcessId = null,
                    PropertyId = 123123,
                    Address1 = "1 Omrah Avenue",
                    Address2 = "string",
                    Suburb = "Caloundra",
                    State = "QLD",
                    PostCode = "4551",
                    DisposalTypeId = "2",
                    DisposalTypeDescription = "sub-surface",
                    SystemTypeId = "AquaNova",
                    SystemTypeDescription = "AquaNova",
                    ServiceIntervalId = "3",
                    ServiceIntervalDescription = "3 months",
                    SerialNumber = "123456",
                    LastServiceDateTime = DateTime.Now
                },
                ServiceDateTime = DateTime.Now,
                TesterFirstName = "SCC",
                TesterLastName = "Test",
                TesterLicenceNo = "1001001",
                TesterComments = "This is a test",
                ProblemIdentified = true,
                InspectionResultId = "Satisfy",
                InspectionResultDescription = "Satisfactory",
                InspectionTypeId = "Service",
                InspectionTypeDescription = "Service",
                AlarmConditionId = "Satisfy",
                AlarmConditionDescription = "Satisfactory",
                CauseId = "HighSludge",
                CauseDescription = "High Sludge",
                DisposalConditionId = "GOOD",
                DisposalConditionDescription = "GOOD",
                SludgeConditionId = "Level OK",
                SludgeConditionDescription = "Level OK",
                Report = "",
                ReportFilename = ""
            };

            var client =
                new OsfInspectionsApiClient(new Uri("https://api.devi.sccdi-internal.com/OsfInspections"), "{api-key}");

            var result = await client.Send(inspection);

            if (result?.Errors?.Any() == true)
            {
                Console.WriteLine("There is a problem with the inspection:");
                foreach (var error in result.Errors)
                {
                    Console.WriteLine(error.Detail);
                }
            }
            else
            {
                Console.WriteLine("Inspection submitted");
            }

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}
