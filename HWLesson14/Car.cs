using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson14
{
    class Car : VehicleBase
    {
        public int _numberOfDoors;

        public override int GetMaxNumOfPassengers()
        {
            return 5;
        }

        public override int GetMaxSpeed()
        {
            return 480;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Nmber Of Doors : {_numberOfDoors}";
        }
    }
}
