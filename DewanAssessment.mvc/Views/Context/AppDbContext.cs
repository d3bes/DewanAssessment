using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DewanAssessment.mvc.Views.Context
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(DbContextOptions options):base (options)
        {
            
        }
    }
}