using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDicPractice
{
    public class UserFunction
    {
        public static bool handleChoiceInUser(int choice)
        {
            bool status = true;
            switch (choice)
            {
                case 1:
                    addNameAndPhonenumber();
                    break;
                case 2:
                    display();
                    break;
                case 3:
                    searchByName();
                    break;
                case 4:
                    status = false;
                    break;
                default:
                    Console.WriteLine("Please choose options from 1 to 4.");
                    break;
            }
            return status;
        }

        public static void menuUser()
        {
            Console.WriteLine("\nContacts:");
            Console.WriteLine("1. Add name and phone number.\r\n2. Display contacts .\r\n3. Search for phone numbers by name.\r\n4. Exit.");
            Console.Write("Choice: ");
        }

        public static void addNameAndPhonenumber()
        {
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Phone Number:");
            string phoneNumber = Console.ReadLine();
            Storage.users.Add(new User(name, phoneNumber));
        }
        public static void display()
        {
            foreach (User user in Storage.users)
            {
                Console.WriteLine(user.ToString());
            }
        }
        public static void searchByName()
        {
            bool isEmpty = false;
            Console.Write("Find name:");
            string name = Console.ReadLine();
            foreach (User user in Storage.users)
            {
                if (user.Name.ToLower().Contains(name.ToLower()))
                {
                    isEmpty = true;
                    Console.WriteLine(user.ToString());
                }
            }
            if (!isEmpty) { Console.WriteLine("Empty"); }
        }
    }
}
