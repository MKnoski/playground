using System.Collections.Generic;
using System.Linq;

namespace pg.EntityFramework.Database
{
    public class BloggingService
    {
        private readonly BloggingContext db;

        public BloggingService(BloggingContext context)
        {
            this.db = context;
        }

        public void Add(Blog blog)
        {
            db.Add(blog);
            db.SaveChanges();
        }

        public Blog Get(int id)
        {
            var blog = db.Blogs.SingleOrDefault(b => b.BlogId == id);
            return blog;
        }

        public IEnumerable<Blog> Get()
        {
            var blogs = db.Blogs.ToList();
            return blogs;
        }

        public void Update(Blog blog)
        {
            db.Blogs.Update(blog);
            db.SaveChanges();
        }

        public void Remove(int id)
        {
            db.Remove(new Blog {BlogId = id});
            db.SaveChanges();
        }
    }
}