using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_ShipDatabaseProject.Models
{
    public class Ship
    {
        public int ShipID { get; }
        public int PortID { get; }
        public ShipType ShipType { get; }
        public decimal ShipWeight { get; }
        public string ShipName { get; }
        public decimal ShipCost { get; }

        public Ship(int shipID, int portID, ShipType shipType, decimal shipWeight, string shipName, decimal shipCost)
        {
            ShipID = shipID;
            PortID = portID;
            ShipType = shipType;
            ShipWeight = shipWeight;
            ShipName = shipName;
            ShipCost = shipCost;
        }


    }
}
