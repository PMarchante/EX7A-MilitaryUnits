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
        public int Human(Var vars)
        {

            vars.comp = Computer();
            vars.hum = 0;
            vars.counter = 0;
            while(vars.hum != vars.comp)
            {
                try
                {
                    vars.counter++;
                    Console.Write("Guess the number from the comuputer: ");
                    vars.hum = Convert.ToInt32(Console.ReadLine());
                    if (vars.hum > vars.comp)
                    {
                        Console.WriteLine("You are to high");
                    }
                    else if (vars.hum < vars.comp)
                    {
                        Console.WriteLine("You are to low");
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid entry! Try Again!");
                }
            } Console.WriteLine("You guessed the number!");
            return vars.counter;
        }
    }
}
