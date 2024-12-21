using System.Data.Entity;

namespace CoreEntity.Models;

public class DatabaseContext : DbContext {
    public DatabaseContext() : base("name=ConnectionString") {
    }

    public DbSet<TGroup> TGroups { get; set; }
    public DbSet<TRelation> TRelations { get; set; }

    public DbSet<TProperty> TProperties { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TProperty>()
            .HasRequired(p => p.TGroup)
            .WithMany(g => g.TProperties)
            .HasForeignKey(p => p.GroupId)
            .WillCascadeOnDelete(true);
    }
}