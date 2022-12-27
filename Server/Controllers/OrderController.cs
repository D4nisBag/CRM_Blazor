using Crm_WASM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Crm_WASM.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace Crm_WASM.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CustomerController> logger;
        private readonly Crm_WASMContext _context;

        public OrderController(ILogger<CustomerController> logger, Crm_WASMContext context)
        {
            this.logger = logger;
            this._context = context;
        }

        [HttpGet]
        public List<Shared.Order> Get()
        {
            List<Models.Order> orders = _context.Orders.ToList();
            List<Shared.Order> orderslist = new List<Shared.Order>();
            foreach(var order in orders)
            {
                orderslist.Add(new Shared.Order(order.Id, order.CustomerId, order.OrderName, order.DispatchAdress, order.TargetAdress,
                order.Weight, order.SendingProduct, order.Status, order.Message));
            }
            return orderslist;
        }
        [HttpPut("updateorder/{Id}")]
        public async Task<Models.Order> UpdateProfile(int Id, [FromBody] Models.Order order)
        {
            Models.Order orderToUpdate = await _context.Orders.Where(u => u.Id == Id).FirstOrDefaultAsync();
            orderToUpdate.Status = "closed";
            await _context.SaveChangesAsync();
            return await Task.FromResult(order);
        }

        // [HttpGet("getprofile/{customerId}")]
        // public async Task<Models.Customer> GetProfile(int customerId)
        // {
        //     return await _context.Customers.Where(u => u.Id == customerId).FirstOrDefaultAsync();
        // }
    }
}
