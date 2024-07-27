using HospitalManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement
{
    public class Repository
    {

        public async Task<List<Hospital>> Get()
        {
            using var db = new HospitalContext();
            return await db.Hospital.ToListAsync();
        }

        public async Task Save(Hospital hospital)
        {
            using var db = new HospitalContext();
            db.Add(hospital);
            await db.SaveChangesAsync();
        }
    }
}
