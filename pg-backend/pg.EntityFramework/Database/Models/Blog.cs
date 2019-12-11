using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace pg.EntityFramework.Database.Models
{
    public class Blog
    {
        private Blog()
        {
        }

        public Blog(int id)
        {
            this.BlogId = id;
        }

        [Column("id")]
        public int BlogId { get; set; }

        public string Url { get; set; }

        public string Author { get; set; }

        public IEnumerable<Post> Posts { get; }
    }
}