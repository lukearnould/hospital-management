using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace HospitalManagement.Models
{
    public record Hospital
    {
        public Hospital() { }

        public Hospital(string name, string description, string color, string phoneNumber, string emailAddress, string url)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name cannot be null or empty");
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                throw new Exception("Description cannot be null or empty");
            }

            if (string.IsNullOrWhiteSpace(color))
            {
                throw new Exception("Color cannot be null or empty");
            }

            if (string.IsNullOrWhiteSpace(phoneNumber) || phoneNumber.Length > 10)
            {
                throw new Exception("Phone number must be 10 characters or less and cannot be empty");
            }

            if (!MailAddress.TryCreate(emailAddress, out MailAddress? parsedEmail))
            {
                throw new Exception("Email is an invalid format");
            }

            if (!Uri.TryCreate(url, UriKind.Absolute, out Uri? parsedUri))
            {
                throw new Exception("Invalid URI");
            }

            Name = name;
            Description = description;
            Color = color;
            PhoneNumber = phoneNumber;
            EmailAddress = parsedEmail;
            URL = parsedUri;
        }

        [Key]
        public int HospitalId { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; } = "";

        [StringLength(500)]
        [Required]
        public string Description { get; set; } = "";

        [Required]
        public string Color { get; set; } = "#000000";

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value?.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "") ?? ""; }
        }

        private string _phoneNumber = "";

        [EmailAddress]
        [StringLength(100)]
        public MailAddress EmailAddress { get; set; }

        [StringLength(100)]
        public Uri URL { get; set; }
    }
}
