// See https://aka.ms/new-console-template for more information
using telrehber;

Console.WriteLine("hello world");
Console.WriteLine(" 1) Add contact\n 2) Display contact by number\n 3) View all contacts\n 4) Search for contacts for a given name\n 5) click q to exit\n Select Operation");
var userInput = Console.ReadLine();
PhoneBook phoneBook = new PhoneBook();

while (true)
{
    switch (userInput)
    {
        case "1":
            Console.WriteLine("Contact name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Contact number");
            var phoneNumber = Console.ReadLine();
            var yenino = new Contact(name, phoneNumber);
            phoneBook.AddContact(yenino);
            break;
        case "2":
            Console.WriteLine("Contact number to search");
            var searchNumber = Console.ReadLine();
            phoneBook.DisplayContact(searchNumber);
            break;
        case "3":
            phoneBook.DisplayAllContact();
            break;
        case "4":
            Console.WriteLine("Name search phrase");
            var searchphrase = Console.ReadLine();
            phoneBook.DisplayMatchingContacts(searchphrase);
            break;
        case "q":
            return;
        default:
            Console.WriteLine("select valid operation");
            break;
    }
    Console.WriteLine("select option: ");
     userInput = Console.ReadLine();
}
