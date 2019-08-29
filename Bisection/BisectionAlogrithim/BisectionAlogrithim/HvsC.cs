using System;
using System.Collections.Generic;
using System.Text;

namespace BisectionAlogrithim
{
    class HvsC
    {
        public int Computer()
        {
            Random r = new Random();
            return r.Next(1000);
        }
        public int Human()
        {
            int comp = Computer();
            int hum = 0;
            int counter = 0;
            while(hum != comp)
            {
                try
                {
                    counter++;
                    Console.Write("Guess the number from the comuputer: ");
                    hum = Convert.ToInt32(Console.ReadLine());
                    if (hum > comp)
                    {
                        Console.WriteLine("You are to high");
                    }
                    else if (hum < comp)
                    {
                        Console.WriteLine("You are to low");
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid entry! Try Again!");
                }
            } Console.WriteLine("You guessed the number!");
            return counter;
        }
    }
}
