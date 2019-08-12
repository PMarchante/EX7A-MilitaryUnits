using System;

namespace EX7A
{
    class Program
    {
        static void Main(string[] args)
        {
            Sailor s1 = new Sailor(1, "Jack", "Chief of Naval Operations", ActiveDuty.payGrade.O10);
            Sailor s2 = new Sailor(5, "April", "Deck seaman", ActiveDuty.payGrade.E1);
            Sailor s3 = new Sailor(101, "Blake", "Damage control", ActiveDuty.payGrade.E6);
            Sailor s4 = new Sailor(587, "Julie", "3M Coordinator", ActiveDuty.payGrade.W4);
            Sailor s5 = new Sailor(99, "Joe", "Division Officer", ActiveDuty.payGrade.O1);
            ///////////////////////////////////////////////////////////////////
            Soldier so2 = new Soldier(1, "joe", "fjds", ActiveDuty.payGrade.E1);
            Console.WriteLine(s5.ToString());
        }
    }
}
