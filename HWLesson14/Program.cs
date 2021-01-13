using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            Car hennessey = new Car
            {
                _numberOfWheels = 4,
                _model = "VenomGT",
                _numberOfDoors = 3
            };

            Car bugatti = new Car
            {
                _numberOfWheels = 4,
                _model = "Chiron",
                _numberOfDoors = 3
            };

            Motorcycle kawasaki = new Motorcycle
            {
                _numberOfWheels = 2,
                _model = "ninja ZX-11",
                _numberOfHandBreakers = 2

            };

            Motorcycle bmv = new Motorcycle
            {
                _numberOfWheels = 2,
                _model = "K 1200 S",
                _numberOfHandBreakers = 2

            };

            PrintVehicle(hennessey);
            PrintVehicle(bugatti);
            PrintVehicle(kawasaki);
            PrintVehicle(bmv);
            Console.WriteLine("==========");

            VehicleBase [] vehicls = new VehicleBase[] { hennessey, bugatti, kawasaki, bmv };
            PrintVehicleArray(vehicls);

        }

        static void PrintVehicle(VehicleBase v)
        {
            Console.WriteLine(v._model);
            Console.WriteLine(v);
        }

        static void PrintVehicleArray(VehicleBase[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
