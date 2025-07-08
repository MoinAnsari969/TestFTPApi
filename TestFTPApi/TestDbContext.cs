using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TestFTPApi
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
    }
}
