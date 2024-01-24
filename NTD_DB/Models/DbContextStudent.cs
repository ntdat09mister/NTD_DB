using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NTD_DB.Models
{
    public partial class DbContextStudent : DbContext
    {
        public DbContextStudent()
            : base("name=DbContextStudent")
        {
        }

        public virtual DbSet<student> students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<student>()
                .Property(e => e.name)
                .IsUnicode(false);
        }
    }
}
