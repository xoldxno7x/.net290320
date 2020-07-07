using System;
using System.Collections.Generic;
using System.Text;

namespace HW_8_7
{
    sealed class PetWolf : Wolf
    {
        public PetWolf(string name, string favoriteDogFood, string nameOfPack) : base(name, favoriteDogFood, nameOfPack)
        {

        }

        public override void Bark()
        {
            Console.WriteLine("Hauls like a pup!");
        }
    }
}
