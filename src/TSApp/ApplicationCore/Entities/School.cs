namespace TalentVN.ApplicationCore.Entities
{
    public class School
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string LogoUri { get; set; }

        public double Tuition { get; set; }

        public string Detail { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public SchoolStatus SchoolStatus { get; set; }
    }

    public enum SchoolStatus
    {
        None = 0,
        New = 1,
        Hot = 2,
    }
}
