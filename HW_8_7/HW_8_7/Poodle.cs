using System;
using System.Collections.Generic;
using System.Text;

namespace HW_8_7
{
    class Poodle : Dog
    {
        public string _numberOfPonyTails;

        public Poodle(string name, string favoritDogFood, string numberOfPonyTales) : base(name, favoritDogFood)
        {
            _numberOfPonyTails = numberOfPonyTales;
        }

        public override void Bark()
        {
            Console.WriteLine("Barking Poodelishly!");
        }

        public override string ToString()
        {
            return base.ToString() + $" number of pony tails is: {_numberOfPonyTails}";
        }
    }
}
