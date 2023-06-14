using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PostgreSqlAsp.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
             : base(options)
        { }
    }

   
}
