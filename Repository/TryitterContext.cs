using Microsoft.EntityFrameworkCore;
using twitter_vinicius.Models;

namespace twitter_vinicius.Repository;
public class TryitterContext : DbContext
{
    public TryitterContext(DbContextOptions<TryitterContext> options) : base(options) {}
    public DbSet<Student> Students { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured) return;
        const string connectionString = "Server=127.0.0.1;Database=tryitter;User=SA;Password=Password";
        optionsBuilder.UseSqlServer(connectionString);
    }
    
    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Post>()
            .HasOne(b => b.Student)
            .WithMany(a => a.Posts)
            .HasForeignKey(b => b.StudentId);
    }
}
