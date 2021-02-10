using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
namespace YgoApp.Models
{
    public class YgoDbContext:DbContext
    {
        public YgoDbContext(DbContextOptions<YgoDbContext> options):base(options)
        {
            
        }
        
        public DbSet<User> Users { get; set; }
        
    }
}