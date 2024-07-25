using HospitalManagement.Models;

namespace HospitalManagement.Mvc.Models
{
    public class HomeViewModel
    {
        public List<Hospital> Hospitals { get; set; }

        public Hospital Hospital { get; set; }
    }
}
