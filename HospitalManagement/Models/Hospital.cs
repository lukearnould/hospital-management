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

        [StringLength(6)]
        [Required]
        public string Color
        {
            get { return _color; }
            set { _color = value.Replace("#", ""); }
        }

        private string _color;
    }
}
