using Microsoft.EntityFrameworkCore;
using PschoolBackend_DAL.Entities;
using System.Reflection.Emit;

namespace PschoolBackend_DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Parent> parents { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<ParentCouple> parentCouples { get; set; } //Many to many relationship
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Student>()
                .HasOne(s => s.ParentCouple)
                .WithMany(pc => pc.Children)
                .HasForeignKey(s=>s.ParentCoupleId);

            builder.Entity<ParentCouple>()
                .HasCheckConstraint("CK_NotEqual_ParentIds", "[Parent1Id] <> [Parent2Id]")
                .HasOne(pc => pc.Parent1)
                .WithOne(p => p.ParentCoupleFromParent1)
                .HasForeignKey<ParentCouple>(pc => pc.Parent1Id);
                

            builder.Entity<ParentCouple>()
                .HasOne(pc => pc.Parent2)
                .WithOne(p => p.ParentCoupleFromParent2)
                .HasForeignKey<ParentCouple>(pc => pc.Parent2Id);

            base.OnModelCreating(builder);
        }
    }
}
