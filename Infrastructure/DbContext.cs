using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vue.Models;

namespace Vue.Infrastructure
{
    public class ApplicationContext : IdentityDbContext<User, Role, string>
    {
        public DbSet<Product> Products { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options) { }
    }
}
