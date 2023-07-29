using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectGuestBook
{
    internal class GuestBookMethod
    {
        public static string Welcome()
        {
            Console.WriteLine("Welcome to the Lounge, What is your name?");
            string output = Console.ReadLine();
            return output;
        }

        public static int NumberOfGuest(string name)
        {
            Console.WriteLine($"Hello {name}, how many guest will be joining you?");
            string guestAmountText = Console.ReadLine();
            if (!int.TryParse(guestAmountText, out int guestAmount))
            {
                NumberOfGuest(name);
            }
            return guestAmount;
            
        }

        public static List<string> ListofGuest(int numberOfGuest)
        {
            List<string> guestList = new List<string>();
            for(int i = 0; i < numberOfGuest; i++)
            {
                Console.WriteLine($"Please enter the name of guest {i+1}");
                guestList.Add( Console.ReadLine() );
            }
            return guestList;
        }

        public static void ConfirmGuestList(string name, List<string> guestList)
        {
            Console.WriteLine($"Thank you {name} we have confirmed you're bringing {guestList.Count} guest");
            Console.WriteLine("The guest we listed are: ");
            foreach(string guest in guestList)
            {
                Console.WriteLine($"{guest}");
            }
            Console.WriteLine("Thanks again and have a great day");
        }
    }
}
