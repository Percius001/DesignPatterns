using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class MotorcycleBuilder:VehicleBuilder
    {
        public MotorcycleBuilder() 
        {
            vehicle = new Vehicle("Motorcycle");
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "MotorCycle Frame";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "MotorCycle Engine";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "MotorCycle Wheels";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "MotorCycle Doors";
        }
    }
}
