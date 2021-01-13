using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson14
{
    abstract class VehicleBase
    {
        public int _numberOfWheels;
        public string _model;

        public abstract int GetMaxNumOfPassengers();

        public abstract int GetMaxSpeed();

        public override string ToString()
        {
            GetMaxNumOfPassengers();
            GetMaxSpeed();
            return $" Number Of Wheels : {_numberOfWheels} Model : {_model} +" +
                $"Max Number Of Passengers : {GetMaxNumOfPassengers()} Max Speed : {GetMaxSpeed()}";
        }
    }
}
