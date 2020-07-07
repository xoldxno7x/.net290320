using System;
using System.Collections.Generic;
using System.Text;

namespace HW_8_7
{
    class Dog : Animal
    {
        public string _favoriteDogFood;

        public Dog(string name, string favoriteDogFood) : base(name)
        {
            _favoriteDogFood = favoriteDogFood;
        }

        public override void MakeSound()
        {
            Bark();
        }

        public virtual void Bark()
        {
            Console.WriteLine("Barking dogishly!");
        }

        public override string ToString()
        {
            return base.ToString() + $" favorit dog food is: {_favoriteDogFood}";
        }
    }
}
