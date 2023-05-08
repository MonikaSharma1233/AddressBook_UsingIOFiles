using System.Security.Cryptography.X509Certificates;

namespace AddressBook_IO
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            FileIOClass file=new FileIOClass();
            List<Address_Book_Model> contact=new List<Address_Book_Model>();
            contact.Add(new Address_Book_Model("Shiva", "Mahadev", "Kailash", "Himalya", "123456", "123456789", "mahadev@gmail.com"));
            contact.Add(new Address_Book_Model("Shiva1", "Mahadev", "Kailash", "Himalya", "123456", "123456789", "mahadev1@gmail.com"));
            contact.Add(new Address_Book_Model("Shiva2", "Mahadev", "Kailash", "Himalya", "123456", "123456789", "mahadev2@gmail.com"));
            contact.Add(new Address_Book_Model("Shiva3", "Mahadev", "Kailash", "Himalya", "123456", "123456789", "mahadev3@gmail.com"));
            contact.Add(new Address_Book_Model("Shiva4", "Mahadev", "Kailash", "Himalya", "123456", "123456789", "mahadev4@gmail.com"));


            foreach (Address_Book_Model model  in contact)
            {
                Console.WriteLine(model.F_name+model.L_name);
            }
            file.Address_store_inFile(contact);
        }
    }
}
