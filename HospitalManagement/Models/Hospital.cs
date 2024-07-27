﻿namespace HospitalManagement.Models
{
    public record Hospital
    {
        public int HospitalId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Color { get; set; }
    }
}
