using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Smart.Data.Context
{
    public class SmartContext : IdentityDbContext
    {
        public SmartContext()
        {

        }
        public SmartContext(DbContextOptions<SmartContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }
}
