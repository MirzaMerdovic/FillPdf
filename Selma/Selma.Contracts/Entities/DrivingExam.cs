using System;

namespace Selma.Contracts.Entities
{
    public class DrivingExam
    {
        public bool IncludesTrafficAndRoadRegulationTest { get; set; }

        public bool IncludesFirstAidTest { get; set; }

        public bool IncludesVehicleDrivingTest { get; set; }

        public DrivingLicenceCategory Category { get; set; }

        public int NumberOfTries { get; set; }

        public string DrivingLicencePenalties { get; set; }

        public DateTime TakenOn { get; set; }

        public int CandidateId { get; set; }
    }
}