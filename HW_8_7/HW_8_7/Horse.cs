using System;
using System.Collections.Generic;
using System.Text;

namespace HW_8_7
{
    class Horse : Animal
    {
        public bool _racingHorse;

        public Horse(string name, bool racingHorse) : base(name)
        {
            _racingHorse = racingHorse;
        }

        public override void MakeSound()
        {
            Neigh();
        }

        //no one is inheriting from me so why virtual?
        public virtual void Neigh()
        {
            Console.WriteLine("Happy neighing!");
        }

        public override string ToString()
        {
            return base.ToString() + $" is racing horse: {_racingHorse}";
        }
    }
}
