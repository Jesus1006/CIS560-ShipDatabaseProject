using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_ShipDatabaseProject.Models
{
    public class ShipMission
    {
        public int ShipMissionID { get; }
        public int ShipID { get; }
        public int MissionID { get; }

        public ShipMission(int shipMissionID, int shipID, int missionID)
        {
            ShipMissionID = shipMissionID;
            ShipID = shipID;
            MissionID = missionID;
        }

    }
}
