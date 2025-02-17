using HospitalManagement.Models;

namespace HospitalManagement
{
    public interface IHospitalRepository
    {
        Task Delete(int id);
        Task<List<Hospital>> Get();
        Task<Hospital?> Get(int id);
        Task Save(Hospital hospital);
    }
}