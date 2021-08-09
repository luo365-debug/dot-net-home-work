using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderAPI.Data;
using OrderManage.Models;

namespace OrderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderServicesController : ControllerBase
    {
        private readonly OrderAPIContext _context;

        public OrderServicesController(OrderAPIContext context)
        {
            _context = context;
        }

        // GET: api/OrderServices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderService>>> GetOrderService()
        {
            return await _context.OrderService.ToListAsync();
        }

        // GET: api/OrderServices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderService>> GetOrderService(int id)
        {
            var orderService = await _context.OrderService.FindAsync(id);

            if (orderService == null)
            {
                return NotFound();
            }

            return orderService;
        }

        // PUT: api/OrderServices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderService(int id, OrderService orderService)
        {
            if (id != orderService.Index)
            {
                return BadRequest();
            }

            _context.Entry(orderService).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderServiceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderServices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderService>> PostOrderService(OrderService orderService)
        {
            _context.OrderService.Add(orderService);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderService", new { id = orderService.Index }, orderService);
        }

        // DELETE: api/OrderServices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderService(int id)
        {
            var orderService = await _context.OrderService.FindAsync(id);
            if (orderService == null)
            {
                return NotFound();
            }

            _context.OrderService.Remove(orderService);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderServiceExists(int id)
        {
            return _context.OrderService.Any(e => e.Index == id);
        }
    }
}
