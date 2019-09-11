using System;
using System.Collections.Generic;
using System.Text;

namespace BisectionAlogrithim
{
    class CvsH
    {
        public void ComputerGuess(Var vars)
        {

            vars.start = 0;
            vars.end = 100;
            vars.mid = (vars.start + vars.end) / 2;
            vars.hum = 0;
            
            try
            {
                Console.Write("Enter a number between 1 and 100: ");
                vars.hum = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("Invalid entry!");
            }
            while (vars.mid != vars.hum)
            { 
                    if(vars.mid > vars.hum)
                    {
                        Console.WriteLine($"The computers guess of {vars.mid} was to high");
                        vars.end = vars.mid;
                        vars.mid = (vars.start + vars.end) / 2;
                    }
                    else if(vars.mid < vars.hum)
                    {
                        Console.WriteLine($"The computers guess of {vars.mid} was to low");
                        vars.start = vars.mid;
                        vars.mid = (vars.start + vars.end) / 2;
                    }

            }Console.WriteLine($"The computers guess of {vars.mid} was exactly right!");
        }
    }
}
