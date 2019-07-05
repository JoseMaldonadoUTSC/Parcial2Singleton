using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>

    /// The 'Director' class

    /// </summary>

    class Shop

    {
        // Builder uses a complex series of steps

        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
    /// <summary>

    /// The 'Builder' abstract class

    /// </summary>

    abstract class VehicleBuilder

    {
        protected Vehicle vehicle;

        // Gets vehicle instance

        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        // Abstract build methods

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
