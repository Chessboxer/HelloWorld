using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Surv ey
    {
        public void RunSurvey()
        {
            Console.Write("Please Enter Your Name : ");
            var name = Console.ReadLine();
            if(name == "")
            {
                Console.WriteLine("You did't enter anything, please enter your name: ");
                name = Console.ReadLine();
            }

            Console.Write("Please Enter Your Age : ");
            var age = Console.ReadLine();
            Console.Write("Please Enter Your Brith Month : ");
            var birthMonth = Console.ReadLine();

            Console.WriteLine("Thank you! ^_^ Let us confirm your information : ");
            Console.WriteLine();
            Console.WriteLine("You said your name is : {0}", name);
            Console.WriteLine("You said your age is : {0}", age);
            Console.WriteLine("You said your birth month is : {0} ", birthMonth);

            if(birthMonth == "march")
            {
                Console.WriteLine("You are gonna die");
            }
        }
    }
}
