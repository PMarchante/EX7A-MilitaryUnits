using System;

namespace BisectionAlogrithim
{
    class Program
    {
        static void Main(string[] args)
        {
            Algo algo = new Algo();
            bool truther = true;
            int input;
            string str;
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            while(truther)
            {
                Console.Write("Enter a number between 1 and 10: ");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"The value searched for, {input}, has been found at index {algo.Finder(input, list)}");
                    truther = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid entry! Please enter a number:");
                }
                
            }
            //HvsC h = new HvsC();
            //h.Human();

            CvsH c = new CvsH();
            c.ComputerGuess();
        }
    }
}
