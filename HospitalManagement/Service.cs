using HospitalManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class Service(Repository repo)
    {
        public async Task<List<Hospital>> Get()
        {
            return await repo.Get();
        }

        public async Task Save(Hospital hospital)
        {
            await repo.Save(hospital);
        }
    }
}
