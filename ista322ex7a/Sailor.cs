using System;
using System.Collections.Generic;
using System.Text;

namespace EX7A
{
    class Sailor : ActiveDuty
    {
        internal Sailor(int dodId, string name, string jobTitle, payGrade rank)
        {
            this.DODiD = dodId;
            this.firstname = name;
            getPaygrade = rank;
            this.jobTitle = jobTitle;
        }

    }
}
