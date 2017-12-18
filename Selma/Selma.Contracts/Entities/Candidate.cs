namespace Selma.Contracts.Entities
{
    public class Candidate
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NameOfParent { get; set; }

        public string Address { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string Citizenship { get; set; }

        public int DrivingLicenceId { get; set; }
    }
}