using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Passcode pass = new Passcode();
            bool correctEntry = false;
            while (correctEntry == false)
            {
                correctEntry = pass.CheckPasscode();
            }
        }
    }
}
