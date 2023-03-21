using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TWJobs.Core.Data.EntityConfigs;
using TWJobs.Core.Models;

namespace TWJobs.Core.Data.Context
{
    public class TWJobsDbContext : DbContext
    {
        public DbSet<Job> Jobs => Set<Job>();

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=Localhost,1433;Database=TWJobs;User ID=sa;Password=1q2w3e4r@#; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new JobEntityConfig());
        }
    }
}
