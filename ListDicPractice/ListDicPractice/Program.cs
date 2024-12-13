using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDicPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Menu.display();
                choice = Menu.userChoice();
            } while (Menu.handleChoice(choice));
        }
    }
}
