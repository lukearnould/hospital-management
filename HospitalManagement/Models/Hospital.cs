namespace HospitalManagement.Models
{
    public record Hospital
    {
        public int HospitalId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Color
        {
            get { return _color; }
            set { _color = value.Replace("#", ""); }
        }

        private string _color;
    }
}
