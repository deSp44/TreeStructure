using Microsoft.EntityFrameworkCore;
using TreeStructure.Domain.Models;

namespace TreeStructure.Infrastructure
{
    public class Context : DbContext
    {
        public DbSet<NodeElement> NodeElements { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .Entity<NodeElement>();
        }
    }
}
