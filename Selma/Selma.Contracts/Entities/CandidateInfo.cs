using System;
using System.Collections.Generic;

namespace Selma.Contracts.Entities
{
    public class CandidateInfo
    {
        public string CandidateId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NameOfParent { get; set; }

        public DateTime BirthDate { get; set; }

        public string Address { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string Citizenship { get; set; }

        public string Phone { get; set; }

        public string Jmbg { get; set; }

        public string Occupancy { get; set; }

        public DrivingLicenceInfo DrivingLicence { get; set; }

        public ICollection<ExamInfo> Exams { get; set; } = new List<ExamInfo>(0);
    }
}