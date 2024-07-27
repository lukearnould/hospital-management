using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class HospitalContext : DbContext
    {
        public DbSet<Hospital> Hospital { get; set; }

        public string DbPath { get; }

        public HospitalContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = "LUKE-DESKTOP\\SQLEXPRESS";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer($"Data Source={DbPath}; Initial Catalog=HospitalManagement; Trust Server Certificate=true; User Id=HospitalManagementUser; Password=quTxyr-godzu8-qerpic");
    }
}
