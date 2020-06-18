using System;
using System.Collections.Generic;
using System.Text;

namespace HW18_6_20
{
    class Motorcycle : Vehicle
    {
        public int _numberOfHandBreakes;
        public override int GetMaxSpeed()
        {
            return 300;
        }

        public override int GetNumberOfPassengers()
        {
            return 2;
        }

        public override string ToString()
        {
            return base.ToString() + $" number of hand breakes: {_numberOfHandBreakes}";
        }
    }
}
