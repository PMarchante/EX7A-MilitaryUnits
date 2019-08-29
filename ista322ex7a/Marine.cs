using System;
using System.Collections.Generic;
using System.Text;

namespace EX7A
{
    class Marine : ActiveDuty
    {
        internal Marine(string firstname, string lastname, payGrade rank)
        {
            
           // this.DODiD = dodId;

            this.firstname = firstname;
            this.lastname = lastname;
            getPaygrade = rank;
           // this.jobTitle = jobTitle;
        }

    }
}
