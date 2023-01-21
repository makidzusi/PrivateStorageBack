using Microsoft.EntityFrameworkCore;
using PrivateStorage.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateStorage.DataAccess
{
    public class PrivateCloudContext : DbContext
    {
        public PrivateCloudContext(DbContextOptions<PrivateCloudContext> options) : base(options) {
            Database.EnsureCreated();
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new FileConfiguration());
        }

        //public DbSet<User> Users { get; set; }
        //public DbSet<UserFile> UserFiles { get; set; }

    }
}
