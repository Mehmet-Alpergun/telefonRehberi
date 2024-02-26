using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telrehber
{
    public class PhoneBook
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();
        private void displayContactDetails(Contact contact)
        {
            Console.WriteLine($"name: {contact.Name}  number: {contact.Number}");
        }
        private void displayContact(List<Contact> contacts )
        {
            foreach(Contact contact in contacts)
            {
                displayContactDetails(contact);
            }
        }
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }
        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("the number doesnt exist");
            }
            else
            {
                displayContactDetails(contact);
            }
        }
        public void DisplayAllContact()
        {
            displayContact(_contacts);
        }
        public void DisplayMatchingContacts(string searchpharese)
        {
            var matchingphrase = _contacts.Where(conatact => conatact.Name == searchpharese).ToList();
            displayContact(matchingphrase);
        }
    }    
}
