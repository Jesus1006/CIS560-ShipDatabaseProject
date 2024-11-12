using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_ShipDatabaseProject.Models
{
    public class Port
    {
        public int PortID { get; }
        public string PortName { get; }
        public string PortLocation { get;  }
        public int ShipCapacity { get; }

        public Port(int portID, string portName, string portLocation, int shipCapacity)
        {
            PortID = portID;
            PortName = portName;
            PortLocation = portLocation;
            ShipCapacity = shipCapacity;
        }
    }
}
