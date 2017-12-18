using System;

namespace Selma.Contracts.Entities
{
    public class DrivingLicence
    {
        public string LicenceId { get; set; }

        public DrivingLicenceCategory Category { get; set; }

        public DateTime IssuedOn { get; set; }

        public int CandidateId { get; set; }
    }
}