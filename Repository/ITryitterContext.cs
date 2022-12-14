using twitter_vinicius.Models;
using Microsoft.EntityFrameworkCore;

namespace twitter_vinicius.Repository;

public interface ITryitterContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Post> Posts { get; set; }
}