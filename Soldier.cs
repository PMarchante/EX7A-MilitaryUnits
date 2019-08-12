using System;
using System.Collections.Generic;
using System.Text;

namespace EX7A
{
    class Soldier : ActiveDuty
    {
        internal Soldier(int dodId, string name, string jobTitle, payGrade rank)
        {
            this.DODiD = dodId;
            this.name = name;
            getPaygrade = rank;
            this.jobTitle = jobTitle;
        }
    }
}
