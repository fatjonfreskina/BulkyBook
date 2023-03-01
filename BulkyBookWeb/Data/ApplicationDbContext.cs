using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore; // Allows to use data annotation and not to write sql statements

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        // ctor code snippet for construcotr
        // Establish the connection with entity framework
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } // generates a table named Categories 
    }
}
