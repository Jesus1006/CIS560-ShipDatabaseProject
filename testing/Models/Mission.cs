using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_ShipDatabaseProject.Models
{
    public class Mission
    {
        public int MissionID { get; }
        public DateTime FirstDate { get; }
        public DateTime LastDate { get; }
        public string MissionName { get; }
        public MissionType MissionType { get; }

        public Mission(int missionID, DateTime firstDate, DateTime lastDate, string missionName, MissionType missionType)
        {
            MissionID = missionID;
            FirstDate = firstDate;
            LastDate = lastDate;
            MissionName = missionName;
            MissionType = missionType;
        }
    }
}
