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
    public class CustomerController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CustomerController> logger;
        private readonly Crm_WASMContext _context;

        public CustomerController(ILogger<CustomerController> logger, Crm_WASMContext context)
        {
            this.logger = logger;
            this._context = context;
        }

        [HttpGet]
        public List<Shared.Customer> Get()
        {
            List<Models.Customer> customers = _context.Customers.ToList();
            List<Shared.Customer> contacts = new List<Shared.Customer>();
            foreach(var customer in customers)
            {
                contacts.Add(new Shared.Customer(customer.Id, customer.Name, customer.Surname, customer.Lastname, customer.Email, customer.PhoneNumber, customer.Login, customer.Password));
            }
            return contacts;
        }
        [HttpPut("updateprofile/{customerId}")]
        public async Task<Models.Customer> UpdateProfile(int customerId, [FromBody] Models.Customer customer)
        {
            
            Models.Customer customerToUpdate = await _context.Customers.Where(u => u.Id == customerId).FirstOrDefaultAsync();
            
            customerToUpdate.Name = customer.Name;
            customerToUpdate.Surname = customer.Surname;
            customerToUpdate.Lastname = customer.Lastname;
            customerToUpdate.Email = customer.Email;
            customerToUpdate.PhoneNumber = customer.PhoneNumber;
            await _context.SaveChangesAsync();

            return await Task.FromResult(customer);
        }

        [HttpGet("getprofile/{customerId}")]
        public async Task<Models.Customer> GetProfile(int customerId)
        {
            return await _context.Customers.Where(u => u.Id == customerId).FirstOrDefaultAsync();
        }
    }
}
