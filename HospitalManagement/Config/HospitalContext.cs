using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Config
{
    public class HospitalContext(string connectionString) : DbContext
    {
        public DbSet<Hospital> Hospital { get; set; }

        public DbSet<Tag> Tag { get; set; }

        public string ConnectionString { get; } = connectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(ConnectionString);
    }
}
