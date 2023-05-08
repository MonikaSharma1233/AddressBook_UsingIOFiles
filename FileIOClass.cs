using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_IO
{
    public class FileIOClass
    {
       
       
        public void Address_store_inFile(List<Address_Book_Model> contact)
        {

       
            string path = "D:\\BridgeLabz\\CSharp\\AddressBook_IO\\Address_book.txt";
           

            using(StreamWriter sr=File.AppendText(path))
            {
                foreach(Address_Book_Model model in contact)
                {
                    sr.WriteLine("First name="+ model.F_name+" Last name: " +model.L_name +"City: "+model.City+"State: "+model.State+"Zip Code"+model.Zip+"Phone no: "+"=model.Phone"+"Email: "+model.Email);
                }
               
                sr.Close();
                Console.WriteLine("Contact Saved in file ");
                Console.WriteLine(File.ReadAllText(path));
               
            }

        }
    }
}
