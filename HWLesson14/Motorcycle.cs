using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson14
{
    class Motorcycle : VehicleBase
    {
        public int _numberOfHandBreakers;

        public override int GetMaxNumOfPassengers()
        {
            return 2;
        }

        public override int GetMaxSpeed()
        {
            return 350;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Nmber Of Hand Breakers : {_numberOfHandBreakers}";
        }
    }
}
