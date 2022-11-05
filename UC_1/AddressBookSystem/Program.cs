
class ContactPersons
{
    private String firstName; private String lastName;
    private String address;
    private String city;
    private String state;
    private String zip;
    private String phoneNumber;
    private String email;
    public ContactPersons(String firstName, String lastName, String address, String city,
    String state, String zip, String phoneNumber, String email)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.address = address;
        this.city = city;
        this.state = state;
        this.zip = zip;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }


    //Override
    public String toString()
    {
        return "\n AddressBook" +
        "n..." +
    "\n FirstName=" + firstName +
    "\n LastName=" + lastName +
    "\n Address=" + address +
    "\n City=" + city +
    "\n State=" + state +
    "\n Zip=" + zip +
    "\n PhoneNumber=" + phoneNumber +
    "\n Email=" + email;
    }
}


public class AddressBookSystemMain
{
   
        //Default Constructor
    public AddressBookSystemMain()
    {
        Console.WriteLine("Welcome to Address Book Program!!!");
    }

    public static void Main(String[] args)
    {
        //Initialize Obiect
        AddressBookSystemMain obj = new AddressBookSystemMain();

        //Calling Encapsulated Class obiect
        ContactPersons addressBook = new ContactPersons("Dishant", "Yashwante",
    "AshokaMarg", "Nashik", "Maharashtra", "422006", "7767994410", "dishantyashwante1996@gmail.com");

        Console.WriteLine("\n" + addressBook.toString());

    }
}