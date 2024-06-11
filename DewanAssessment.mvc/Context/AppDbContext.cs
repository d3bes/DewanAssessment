using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DewanAssessment.mvc.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

namespace DewanAssessment.mvc.Context
{

         public class AppDbContext : DbContext
    {
        
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions<AppDbContext> options):base (options)
        {
            
        }

// protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//         if (!optionsBuilder.IsConfigured)
//         {
//             IConfigurationRoot configuration = new ConfigurationBuilder()
//                .SetBasePath(Directory.GetCurrentDirectory())
//                .AddJsonFile("appsettings.json")
//                .Build();
//             var connectionString = configuration.GetConnectionString("mysql");
//             optionsBuilder.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));
//         }
//     }

        public DbSet<Item> items {get;set;}
            public DbSet<Receipt> Receipts { get; set; }
    
    // DbSet for the ReceiptItem entity
    public DbSet<ReceiptItem> ReceiptItems { get; set; }

   
    }
    }
