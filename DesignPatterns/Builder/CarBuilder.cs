using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class CarBuilder:VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "Car Frame";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "Car Engine";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "Car Wheels";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "Car Doors";
        }
    }
}
