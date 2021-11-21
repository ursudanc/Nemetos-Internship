using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api.Models;
using Web_Api.Services;

namespace Web_Api.Data
{
    public class AdministratorDbContext : DbContext
    {
       
        public AdministratorDbContext(DbContextOptions<AdministratorDbContext> options) : base(options) { }
        public DbSet<Admin> Admins { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(
            new Admin
            {
                Id = 3,
                UserName = "testing",
                Password = new Encrypting().ConvertToEncrypt("testing")
            });
        }
    }
}
