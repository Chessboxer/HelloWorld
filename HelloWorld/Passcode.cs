using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Passcode
    {
        private string xd = "secret";

        public bool CheckPasscode()
        {
            Console.Write("Enter Password : ");
            String entry = Console.ReadLine();
            if (entry == xd)
            {
                Console.WriteLine("Passcode confirmed, logging in.......");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect, Try Again");
                return false;
            }
        }

    }
}
