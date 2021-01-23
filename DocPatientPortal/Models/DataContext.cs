﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

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
        public DbSet<User> Users { get; set; }


    }
}
