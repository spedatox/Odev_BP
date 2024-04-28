using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.Logging;
using Odev_BP.Models;  
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Odev_BP
{
    public class OtelDbContext : DbContext
    {
        public DbSet<Models.calisan> Calisan { get; set; }  
        public DbSet<Models.musteri> Musteri { get; set; }  
        public DbSet<Models.rezervasyon> Rezervasyon { get; set; }  
        public DbSet<Models.otelOda> OtelOda { get; set; } 
        public DbSet<Models.odeme> Odeme { get; set; }  
        public DbSet<Log> Log { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<rezervasyon>()
                .HasOne(r => r.Musteri)
                .WithMany(m => m.Rezervasyon)
                .HasForeignKey(r => r.MusteriID);

            modelBuilder.Entity<rezervasyon>()
                .HasOne(r => r.OtelOda)
                .WithMany(o => o.Rezervasyon)
                .HasForeignKey(r => r.OdaID);

            modelBuilder.Entity<Log>().ToTable("Log"); 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(new String[] { @"bin\" }, StringSplitOptions.None)[0];
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(projectPath)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
    }

}









