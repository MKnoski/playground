using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace pg.EntityFramework.Database
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
        : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }

        public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseLoggerFactory(MyLoggerFactory);
    }
}