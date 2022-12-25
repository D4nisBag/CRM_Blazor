using Crm_WASM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Crm_WASM.Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;



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
        //для аутентификации
        [HttpPost("logincustomer")]
        public async Task<ActionResult<Models.Customer>> LoginCustomer(Models.Customer customer)
        {
            Models.Customer loggedInCustomer = await _context.Customers.Where(u => u.Login == customer.Login && u.Password == customer.Password).FirstOrDefaultAsync();

            if(loggedInCustomer != null)
            {
                //
                var claim = new Claim (ClaimTypes.Name, loggedInCustomer.Login);
                var claimsIdentity = new ClaimsIdentity(new[] {claim}, "serverAuth");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                await HttpContext.SignInAsync(claimsPrincipal);
            }

            return await Task.FromResult(loggedInCustomer);
        }
        [HttpGet("getcurrentcustomer")]
        public async Task<ActionResult<Models.Customer>> GetCurrentCustomer()
        {
            Models.Customer currentCustomer = new Models.Customer();
            if(User.Identity.IsAuthenticated)
            {
                currentCustomer.Login = User.FindFirstValue(ClaimTypes.Name);
            }
            
            return await Task.FromResult(currentCustomer);
        }
        [HttpGet("logoutcustomer")]
        public async Task<ActionResult<String>> LogoutCustomer()
        {
            await HttpContext.SignOutAsync();
            return "Success";
        }
        

        

    }
}
