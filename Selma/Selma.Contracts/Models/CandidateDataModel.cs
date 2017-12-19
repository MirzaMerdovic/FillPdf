using System;
using Selma.Contracts.Entities;

namespace Selma.Contracts.Models
{
    public class CandidateDataModel
    {
        public int CandidateId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NameOfParent { get; set; }

        public string Address { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string Citizenship { get; set; }

        public string Phone { get; set; }

        public string LicenceId { get; set; }

        public DrivingLicenceCategory Category { get; set; }

        public DateTime IssuedOn { get; set; }

        public DateTime ExpiresOn { get; set; }
    }
}