using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Crm_WASM.Client;
using Crm_WASM.Shared.Models;

namespace Crm_WASM.ViewModels
{
    public class LoginViewModel
    {
        public string Login { get; set; }
        public string Password { get; set; }

        private HttpClient _httpClient;
        public LoginViewModel()
        {

        }
        public LoginViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task LoginCustomer()
        {
            await _httpClient.PostAsJsonAsync<Customer>("customer/logincustomer", this);
        }

        public static implicit operator LoginViewModel(Customer customer)
        {
            return new LoginViewModel
            {
                Login = customer.Login,
                Password = customer.Password
            };
        }

        public static implicit operator Customer(LoginViewModel loginViewModel)
        {
            return new Customer
            {
                Login = loginViewModel.Login,
                Password = loginViewModel.Password
            };
        }
    }
}