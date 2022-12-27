using Crm_WASM.Shared.Models;

namespace Crm_WASM.ViewModels
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        
        public Contact()
        {

        }
        public Contact(string Name, string Surname, string Lastname)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Lastname = Lastname;
        }

        public Contact(int contactId, string Name, string Surname, string Lastname)
        {
            this.ContactId = contactId;
            this.Name = Name;
            this.Surname = Surname;
            this.Lastname = Lastname;
        }

        //operators
        public static implicit operator Contact(Customer customer)
        {
            return new Contact
            {
                ContactId = (int)customer.Id,
                Name = customer.Name,
                Surname = customer.Surname,
                Lastname = customer.Lastname
            };
        }
        public static implicit operator Customer(Contact contact)
        {
            return new Customer
            {
                Id = contact.ContactId,
                Name = contact.Name,
                Surname = contact.Surname,
                Lastname = contact.Lastname
            };
        }
    }
}