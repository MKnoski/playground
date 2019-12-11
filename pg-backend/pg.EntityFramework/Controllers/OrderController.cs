using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pg.EntityFramework.Database.Models.TableSplitting;

namespace pg.EntityFramework.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderService service;

        public OrderController(OrdersContext db)
        {
            this.service = new OrderService(db);
        }

        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return this.service.Get(id);
        }

        [HttpGet]
        public IEnumerable<Order> GetAll()
        {
            return this.service.Get();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Order> Add(Order order)
        {
            this.service.Add(order);

            return CreatedAtAction(nameof(Get), new { id = order.Id }, order);
        }
    }
}
