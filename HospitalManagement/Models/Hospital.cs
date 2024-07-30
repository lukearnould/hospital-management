using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public record Hospital
    {
        [Key]
        public int HospitalId { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(500)]
        [Required]
        public string Description { get; set; }

        [Required]
        public string Color { get; set; } = "#000000";

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value?.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", ""); }
        }

        private string _phoneNumber;

        [EmailAddress]
        [StringLength(100)]
        public string EmailAddress { get; set; }

        [StringLength(100)]
        public string URL { get; set; }
    }
}
