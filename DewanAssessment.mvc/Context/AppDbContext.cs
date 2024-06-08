using DewanAssessment.mvc.Models;
using Microsoft.EntityFrameworkCore;



namespace DewanAssessment.mvc.Views.Context
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(DbContextOptions options):base (options)
        {
            
        }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=sql.freedb.tech;Port=3306;Database=freedb_dewanAssessment;Uid=freedb_hiiehaejk;Pwd=7U48dq*Mm73*Rft;",
                new MySqlServerVersion(new Version(8, 0, 21)));
            }
        }


        public DbSet<Item> items {get;set;}
            public DbSet<Receipt> Receipts { get; set; }
    
    // DbSet for the ReceiptItem entity
    public DbSet<ReceiptItem> ReceiptItems { get; set; }

   
    }
}