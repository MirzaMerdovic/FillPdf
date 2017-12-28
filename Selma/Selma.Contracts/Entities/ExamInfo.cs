using System;

namespace Selma.Contracts.Entities
{
    public class ExamInfo
    {
        public string Id { get; set; }

        public DateTime TakenOn { get; set; }

        public string Category { get; set; }

        public bool IncludesTrafficRegulationsTest { get; set; }

        public bool IncludesFirstAidTest { get; set; }

        public bool IncludesDrivingTest { get; set; }

        public string Location { get; set; }

        public DayOfWeek Day { get; set; }

        public string Instructor { get; set; }

        public string InstructorPhone { get; set; }
    }
}
