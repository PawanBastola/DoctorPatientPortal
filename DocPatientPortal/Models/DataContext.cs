using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DocPatientPortal.Models;

namespace DocPatientPortal.Models
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            optionsBuilder.UseMySql(configuration
                ["ConnectionStrings:DefaultConnection"]);

        }

        //Need to register your models here
        // public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }//this is for blood insert update and delete
        public DbSet<Doctor_Details> Doctors { get; set; }
        public DbSet<Patient_Details> Patients { get; set; }
        public DbSet<UserLogin> userlogins { get; set; }
        public DbSet<Appointment> appointmentss { get; set; }

        public DbSet<Unavailability> unavaibilities { get; set; }
        

        //Need to register your models here
        // public DbSet<Product> Products { get; set; }

    }
}
