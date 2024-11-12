using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_ShipDatabaseProject.Models
{
    public class CrewMember
    {
        public int CrewMemberID { get; }
        public int ShipID { get; }
        public int PersonID { get; }
        public DateTime JoinDate { get; }
        public DateTime LeftDate { get; }

        public CrewMember(int crewMemberID, int shipID, int personID, DateTime joinDate, DateTime leftDate)
        {
            CrewMemberID = crewMemberID;
            ShipID = shipID;
            PersonID = personID;
            JoinDate = joinDate;
            LeftDate = leftDate;
        }


    }
}
