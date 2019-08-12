using System;
using System.Collections.Generic;
using System.Text;

namespace EX7A
{
    internal abstract class ActiveDuty
    {
        internal string name { get; set; }
        internal int DODiD { get; set; }
        internal enum payGrade { E1, E2, E3, E4, E5, E6, E7, E8, E9, W1, W2, W3, W4, W5, O1, O2, O3, O4, O5, O6, O7, O8, O9, O10 }
        internal payGrade getPaygrade { get; set; }
        internal string jobTitle { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("I am a United States ").Append(this.GetType().Name).Append($". My name is {name}. ").Append($"My DOD ID is {DODiD}. ")
                .Append($"My paygrade is {getPaygrade}.").Append($" And i am a {jobTitle}");

            return sb.ToString();
        }
    }
}
