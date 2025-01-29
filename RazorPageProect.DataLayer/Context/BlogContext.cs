using Microsoft.EntityFrameworkCore;

namespace RazorPageProect.DataLayer.Context;

public class BlogContext :DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options):base(options)
    {
        
    }
}