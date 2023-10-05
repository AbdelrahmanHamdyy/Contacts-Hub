using Contacts.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Contacts.WebAPI
{
    // Memory representation of the actual database
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :base(options) {}

        public DbSet<Contact> Contacts { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Contact>().HasKey
        //}
    }
}
