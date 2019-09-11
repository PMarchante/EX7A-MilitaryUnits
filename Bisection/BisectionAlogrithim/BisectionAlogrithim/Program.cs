using System;


namespace BisectionAlogrithim
{
    class Program
    {
        static void Main(string[] args)
        {
            Algo algo = new Algo();
            Var vars = new Var();
            

            while(vars.truth)
            {
                Console.Write("Enter a number between 1 and 10: ");
                try
                {
                    vars.input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"The value searched for, {vars.input}, has been found at index {algo.Finder(vars.input, vars.list, vars)}");
                    vars.truth = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid entry! Please enter a number:");
                }
                
            }
            
            CvsH c = new CvsH();
            c.ComputerGuess(vars);

            //commented out because it takes forever to run through
            //HvsC h = new HvsC();
            //h.Human(vars);
        }
    }
}
