using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson14
{
    class Carrier
    {
        VehicleBase[] _vehicles;

        public override string ToString()
        {
            string result = "Carrier: \n";
            for (int i = 0; i < _vehicles.Length; i++)
            {
                result = result + _vehicles[i].ToString() + "\n";
            }
            return result;
        }
    }
}
