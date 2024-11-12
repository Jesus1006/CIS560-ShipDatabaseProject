using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_ShipDatabaseProject.Models
{
    public class Person
    {
        public int PersonID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public RankType RankType { get; }
        public Person(int personID, string firstName, string lastName, RankType rankType)
        {
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            RankType = rankType;
        }
    }
}
