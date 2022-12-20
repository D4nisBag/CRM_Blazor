using System;
using System.Collections.Generic;
using System.Text;

namespace Crm_WASM.Shared
{

    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Customer()
        {

        }
        public Customer(int CustomerId, string Name, string Surname, string LastName, string Email, string PhoneNumber, string Login, string Password)
        {
            this.CustomerId = CustomerId;
            this.Name = Name;
            this.SurName= Surname;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Login = Login;
            this.Password = Password;
        }
    }
}
