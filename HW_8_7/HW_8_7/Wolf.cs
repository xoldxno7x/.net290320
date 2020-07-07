using System;
using System.Collections.Generic;
using System.Text;

namespace HW_8_7
{
    class Wolf : Dog
    {
        public string _nameOfPack;

        public Wolf(string name, string favoriteDogFood, string nameOfPack) : base(name, favoriteDogFood)
        {
            _nameOfPack = nameOfPack;
        }

        public override void Bark()
        {
            Console.WriteLine("Haul to the moon!");
        }

        public override string ToString()
        {
            return base.ToString() + $" name of the pack is: {_nameOfPack}";
        }
    }
}
