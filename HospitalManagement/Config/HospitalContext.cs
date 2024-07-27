using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Config
{
    public class HospitalContext(string connectionString) : DbContext
    {
        public DbSet<Hospital> Hospital { get; set; }

        public string ConnectionString { get; } = connectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(ConnectionString);
    }
}
