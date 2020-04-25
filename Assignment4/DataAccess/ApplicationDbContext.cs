using Assignment4.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment4.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Reports> Reports { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
