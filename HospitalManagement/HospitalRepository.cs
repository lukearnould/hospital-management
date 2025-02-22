﻿using HospitalManagement.Config;
using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement
{
    public class HospitalRepository(ICoreConfig config) : IHospitalRepository
    {
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

        private DatabaseContext DefaultContext()
        {
            return new DatabaseContext(config.ConnectionString);
        }
    }
}
