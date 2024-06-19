using BMC_baithi2324.Models;
using Microsoft.EntityFrameworkCore;

namespace BMC_baithi2324.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Person> Person { get; set; }

public DbSet<BMC_baithi2324.Models.Employee> Employee { get; set; } = default!;
    }
}
