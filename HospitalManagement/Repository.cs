using HospitalManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HospitalManagement.Config;

namespace HospitalManagement
{
    public class Repository(ICoreConfig config)
    {
        private HospitalContext DefaultContext()
        {
            return new HospitalContext(config.SQLConnectionString);
        }

        public async Task<List<Hospital>> Get()
        {
            using var db = DefaultContext();
            return await db.Hospital.ToListAsync();
        }

        public async Task<Hospital?> Get(int id)
        {
            using var db = DefaultContext();
            return await db.Hospital.FindAsync(id);
        }

        public async Task Save(Hospital hospital)
        {
            using var db = DefaultContext();

            if (hospital.HospitalId == 0)
            {
                db.Add(hospital);
            }
            else
            {
                db.Update(hospital);
            }
            await db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            using var db = DefaultContext();

            Hospital hospital = new() { HospitalId = id };
            db.Hospital.Attach(hospital);
            db.Remove(hospital);
            await db.SaveChangesAsync();
        }
    }
}
