using System;

namespace Computer
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer asus = new Computer {
                model = "VivoBook 16",
                price = 5000,
                numberOfProcessors = 4,
                screenSize = 16
            };

            Computer lenovo = new Computer
            {
                model = "SmartBook",
                price = 6400,
                numberOfProcessors = 8,
                screenSize = 13
            };

            Computer lenovoLegion = new Computer
            {
                model = "Legion",
                price = 15000,
                numberOfProcessors = 16,
                screenSize = 20
            };

            Console.WriteLine(asus.TellMeThePrice());
            Console.WriteLine(asus.TellMeTheScreenSize());
            asus.TurnOn();
            Console.WriteLine(asus.isTurnOn);
            asus.AddProcessor();
            Console.WriteLine(asus.numberOfProcessors);
            Console.WriteLine(asus.ToString());

            Console.WriteLine(lenovo.TellMeThePrice());
            Console.WriteLine(lenovo.TellMeTheScreenSize());
            lenovo.TurnOn();
            Console.WriteLine(lenovo.isTurnOn);
            lenovo.AddProcessor();
            Console.WriteLine(lenovo.numberOfProcessors);
            Console.WriteLine(lenovo.ToString());


            Console.WriteLine(lenovoLegion.TellMeThePrice());
            Console.WriteLine(lenovoLegion.TellMeTheScreenSize());
            lenovoLegion.TurnOn();
            Console.WriteLine(lenovoLegion.isTurnOn);
            lenovoLegion.AddProcessor();
            Console.WriteLine(lenovoLegion.numberOfProcessors);
            Console.WriteLine(lenovoLegion);
        }
    }
}
