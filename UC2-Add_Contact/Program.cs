using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_Add_Contact
{
    class Create_Contact
    {
        class Contact
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string address { get; set; }
            public string state { get; set; }
            public long phoneNumber { get; set; }
            public string email { get; set; }
            public int zipCode { get; set; }
        }
        List<Contact> People = new List<Contact>();
        public void GetContactDetails()   // creating contact details of person
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter the First Name");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            contact.lastName = Console.ReadLine();
            Console.WriteLine("Enter the Adresss");
            contact.address = Console.ReadLine();
            Console.WriteLine("Enter the State");
            contact.state = Console.ReadLine();
            Console.WriteLine("Enter the Zip Code");
            contact.zipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Phone Number");
            contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Email");
            contact.email = Console.ReadLine();
            People.Add(contact);
            Console.WriteLine();
        }
        public void Display()      //Display the details
        {
            foreach (var data in People)
            {
                Console.WriteLine("*************Contact Details****************");
                Console.WriteLine($"Name of person         : {data.firstName} {data.lastName}");
                Console.WriteLine($"Address of person is   : {data.address}");
                Console.WriteLine($"State                  : {data.state}");
                Console.WriteLine($"Zip                    : {data.zipCode}");
                Console.WriteLine($"Email of person        : {data.email}");
                Console.WriteLine($"Phone Number of person : {data.phoneNumber}");
            }
        }
        public static void Main(String[] args)
        {
            Create_Contact AddressBook = new Create_Contact();
            AddressBook.GetContactDetails();
            AddressBook.Display();
            Console.ReadLine();
        }
    }
}