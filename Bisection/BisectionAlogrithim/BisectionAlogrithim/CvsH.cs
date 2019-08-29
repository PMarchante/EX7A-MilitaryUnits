using System;
using System.Collections.Generic;
using System.Text;

namespace BisectionAlogrithim
{
    class CvsH
    {
        public void ComputerGuess()
        {
            int start = 0;
            int end = 100;
            int mid = (start + end) / 2;
            int hum = 0;
            
            try
            {
                Console.Write("Enter a number between 1 and 100: ");
                hum = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("Invalid entry!");
            }
            while (mid != hum)
            { 
                    if(mid > hum)
                    {
                        Console.WriteLine($"The computers guess of {mid} was to high");
                        end = mid;
                        mid = (start + end) / 2;
                    }
                    else if(mid < hum)
                    {
                        Console.WriteLine($"The computers guess of {mid} was to low");
                        start = mid;
                        mid = (start + end) / 2;
                    }

            }Console.WriteLine($"The computers guess of {mid} was exactly right!");
        }
    }
}
