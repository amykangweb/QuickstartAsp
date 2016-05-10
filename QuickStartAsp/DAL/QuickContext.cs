using QuickStartAsp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace QuickStartAsp.DAL
{
    public class QuickContext : DbContext
    {
        public QuickContext() : base("QuickContext") { }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}