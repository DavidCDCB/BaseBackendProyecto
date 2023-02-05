using Microsoft.EntityFrameworkCore;
using NewProtoNet.Models;

// https://www.entityframeworktutorial.net/code-first/code-based-migration-in-code-first.aspx

// Add-Migration "Segunda"
// Update-database

// https://www.entityframeworktutorial.net/code-first/configure-one-to-many-relationship-in-code-first.aspx
// https://geeksarray.com/blog/how-to-configure-entity-relationships-using-fluent-api-in-entity-framework
// https://learn.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key

// https://learn.microsoft.com/en-us/ef/core/saving/related-data?source=recommendations
// https://learn.microsoft.com/en-us/ef/core/querying/related-data/eager?source=recommendations

namespace NewProtoNet.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
