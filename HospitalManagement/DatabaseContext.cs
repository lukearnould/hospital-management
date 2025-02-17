using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement
{
    public class DatabaseContext(string connectionString) : DbContext
    {
        public DbSet<Hospital> Hospital { get; set; }

        public string ConnectionString { get; } = connectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(ConnectionString);
    }
}
