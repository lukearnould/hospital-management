namespace HospitalManagement.Models
{
    public record Hospital
    {
        public int HospitalId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Address Address { get; set; }
    }
}
