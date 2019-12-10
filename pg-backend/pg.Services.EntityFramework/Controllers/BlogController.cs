using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pg.EntityFramework.Database;

namespace pg.EntityFramework.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly BloggingService service;

        public BlogController(BloggingContext db)
        {
            this.service = new BloggingService(db);
        }

        [HttpGet("{id}")]
        public Blog Get(int id)
        {
            return this.service.Get(id);
        }

        [HttpGet]
        public IEnumerable<Blog> GetAll()
        {
            return this.service.Get();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Blog> Add(Blog blog)
        {
            this.service.Add(blog);

            return CreatedAtAction(nameof(Get), new { id = blog.BlogId }, blog);
        }

        [HttpPut]
        public void Update(Blog blog)
        {
            this.service.Update(blog);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            this.service.Remove(id);
        }
    }
}
