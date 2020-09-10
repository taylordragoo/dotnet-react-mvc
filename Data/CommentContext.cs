using Microsoft.EntityFrameworkCore;
using dotnet_react_mvc.Models;

namespace dotnet_react_mvc.Data
{
    public class CommentContext : DbContext
    {
        public CommentContext(DbContextOptions<CommentContext> options)
            : base(options)
        {

        }

        public DbSet<CommentModel> Comment { get; set; }
    }
}
