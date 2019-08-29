using System;

namespace EX7A
{
    class Program
    {
        public void CreatePlatoon()
        {
            Random r = new Random();
            string[] firstName = { "bob", "joe", "phil", "tom", "matt", "bill", "tyler", "george" };
            string[] lastName = { "smith", "doe", "allen", "jackson", "guy", "matthews" };
            

            

            for(int i = 0; i < 31; i++)
            {
                Marine m = new Marine(firstName[r.Next(8)], lastName[r.Next(6)], ActiveDuty.payGrade.E3 );
                Console.WriteLine(m.ToString());
            }
        }
        static void Main(string[] args)
        {
            Program plt = new Program();
            plt.CreatePlatoon();
            
        }
    }
}
