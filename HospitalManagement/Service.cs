using HospitalManagement.Models;

namespace HospitalManagement
{
    public class Service(Repository repo)
    {
        public async Task<Hospital?> GetOptional(int id)
        {
            return await repo.Get(id);
        }

        public async Task<Hospital> Get(int id)
        {
            return await GetOptional(id) ?? throw new Exception($"Hospital with ID {id} not found");
        }

        public async Task<List<Hospital>> Get()
        {
            return await repo.Get();
        }

        public async Task Save(Hospital hospital)
        {
            await repo.Save(hospital);
            //await ReconcileTags(hospital);
        }

        //private async Task ReconcileTags(Hospital hospital)
        //{
        //    var existingTags = await repo.GetTags();
        //    var newTags = 
        //        from tag in hospital.Tags
        //        where !existingTags.Select(x => x.Name).Contains(tag)
        //        select new Tag() { Name = tag };
        //    await repo.SaveTags(newTags.ToList());
        //}

        public async Task Delete(int id)
        {
            await repo.Delete(id);
        }
    }
}
