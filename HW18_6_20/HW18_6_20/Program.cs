using System;

namespace HW18_6_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Car suzuki = new Car()
            {
                _model = "Liana",
                _numberOfWheels = 4,
                _numberOfDoors = 4
            };

            Car ford = new Car()
            {
                _model = "Mustang",
                _numberOfWheels = 4,
                _numberOfDoors = 2
            };

            Motorcycle harleyDavidson = new Motorcycle()
            {
                _model = "Road King",
                _numberOfWheels = 2,
                _numberOfHandBreakes = 2
            };

            Motorcycle chopper = new Motorcycle()
            {
                _model = "Zed's Chopper",
                _numberOfWheels = 2,
                _numberOfHandBreakes = 2
            };

            Vehicle[] vs = { suzuki, ford, chopper };

            Carrier c = new Carrier()
            {
                _vehicles = new Vehicle[2]
            };

            c._vehicles[0] = ford;
            c._vehicles[0] = harleyDavidson;

            //Test
            //Console.WriteLine(c);
            //Console.WriteLine(PrintVehicle(chopper));
            //PrintVehicleArr(vs);


        }
        /// <summary>
        /// Not sure that this is the implementation you were looking for
        /// It made more sense to me rather than just console writing both the model and the Vehicle
        /// </summary>
        /// <param name="v"></param>
        /// <returns>vehilce ToString</returns>
        public static string PrintVehicle(Vehicle v)
        {
            Console.WriteLine($"The model is: {v._model}");
            return $"{v}";
        }

        public static void PrintVehicleArr(Vehicle[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($" Vehicle number {i+1}: " + arr[i]);
            }
        }
    }
}
