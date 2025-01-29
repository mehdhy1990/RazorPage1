using Microsoft.EntityFrameworkCore;
using RazorPageProect.DataLayer.Entities;

namespace RazorPageProect.DataLayer.Context;

public class BlogContext :DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options):base(options)
    {
        
    }

    public DbSet<Post> Posts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<PostComment> PostComments { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }
        base.OnModelCreating(modelBuilder);
    }
}