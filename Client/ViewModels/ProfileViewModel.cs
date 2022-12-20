using Crm_WASM.Shared.Models;

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