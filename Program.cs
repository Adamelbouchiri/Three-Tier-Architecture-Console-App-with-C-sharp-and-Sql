using System;
//using System.Data;
using ContactBusinessLayer;

namespace ContactsConsoleApp_PresentationLayer
{
    internal class Program
    {

        static void testFindContact(int ID)
        {
            clsContact contact = clsContact.Find(ID);

            if(contact != null )
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName);
                Console.WriteLine(contact.Email);
                Console.WriteLine(contact.Phone);
                Console.WriteLine(contact.Address);
                Console.WriteLine(contact.DateOfBirth);
                Console.WriteLine(contact.ImagePath);
                Console.WriteLine(contact.ContryID);
            }
            else
            {
                Console.WriteLine("Contact With ID: " + ID + " Is Not Found");
            }
        }
        static void Main(string[] args)
        {
            testFindContact(1);
            Console.ReadKey();
        }
    }
}
