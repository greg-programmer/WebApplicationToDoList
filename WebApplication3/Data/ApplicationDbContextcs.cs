using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ToDoList> ToDoLists { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoList>().HasData(
            new ToDoList { Id = 1, Title = "Salon", Description = "Balayer le sol", Finished = false },
            new ToDoList { Id = 2, Title = "Cuisine", Description = "Faire la vaisselle", Finished = false },
            new ToDoList { Id = 3, Title = "Chambre", Description = "Balayer le sol", Finished = false });
        }
    }
}
    
    