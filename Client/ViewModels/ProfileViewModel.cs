using Crm_WASM.Shared.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;


namespace Crm_WASM.ViewModels
{
    public class ProfileViewModel
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string Surname{ get; set; }
        public string Lastname{ get; set; }
        public string Email{ get; set; }
        public string PhoneNumber{ get; set; }
        public string Message{ get; set; }

        private HttpClient _httpClient;
         public ProfileViewModel()
        {

        }

        public ProfileViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task UpdateProfile()
        {
            Customer customer = this;
            await _httpClient.PutAsJsonAsync("customer/updateprofile/3", customer);
            this.Message = "Профиль успешно обновлен";
        }

        public async Task GetProfile()
        {
            Customer customer = await _httpClient.GetFromJsonAsync<Customer>("customer/getprofile/3");
            LoadCurrentObject(customer);
            this.Message = "Профиль успешно загружен";
        }

        private void LoadCurrentObject(ProfileViewModel profileViewModel)
        {
            this.Name = profileViewModel.Name;
            this.Surname = profileViewModel.Surname;
            this.Lastname = profileViewModel.Lastname;
            this.Email = profileViewModel.Email;
            this.PhoneNumber = profileViewModel.PhoneNumber;
            this.Id = profileViewModel.Id;
        }

        public static implicit operator ProfileViewModel(Customer customer)
        {
            return new ProfileViewModel
            {
                Name = customer.Name,
                Surname = customer.Surname,
                Lastname = customer.Lastname,
                Id = customer.Id,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };
        }
        public static implicit operator Customer(ProfileViewModel profileViewModel)
        {
            return new Customer
            {
                Name = profileViewModel.Name,
                Surname = profileViewModel.Surname,
                Lastname = profileViewModel.Lastname,
                Id = profileViewModel.Id,
                Email = profileViewModel.Email,
                PhoneNumber = profileViewModel.PhoneNumber
            };
        }
    }
}