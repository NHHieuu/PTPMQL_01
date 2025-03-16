using Microsoft.EntityFrameworkCore;
using MvcProject.Models;

namespace MvcProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options){}
        public DbSet<student> students { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}