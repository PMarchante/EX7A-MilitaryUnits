using System;
using System.Collections.Generic;
using System.Text;

namespace EX7A
{
    class Marine : ActiveDuty
    {
        internal Marine(int dodId, string name, string jobTitle, payGrade rank)
        {
            this.DODiD = dodId;
            this.name = name;
            getPaygrade = rank;
            this.jobTitle = jobTitle;
        }

    }
}
