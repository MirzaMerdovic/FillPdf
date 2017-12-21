using System;

namespace Selma.Contracts.Entities
{
    public class DrivingLicenceInfo
    {
        public string LicenceId { get; set; }

        public string Category { get; set; }

        public DateTime IssuedOn { get; set; }

        public DateTime ExpiresOn { get; set; }
    }
}