using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

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

        [StringLength(6)]
        [Required]
        public string Color
        {
            get { return _color; }
            set { _color = value.Replace("#", ""); }
        }

        private string _color;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value?.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", ""); }
        }

        private string _phoneNumber;
        [StringLength(100)]
        public string EmailAddress { get; set; }

        [StringLength(100)]
        public string URL { get; set; }

        //public List<Tag> Tags { get; set; }
    }
}
