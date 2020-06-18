using System;
using System.Collections.Generic;
using System.Text;

namespace HW18_6_20
{
    class Car : Vehicle
    {
        public int _numberOfDoors;
        public override int GetMaxSpeed()
        {
            return 220;
        }

        /// <summary>
        /// To clarify, this function will return the nubmer of passangers based on the number of doors
        /// not perfect - to be perfect it should have a set number of max passangers as well 
        /// however as it is not in the UML I did not add it
        /// </summary>
        /// <returns>num of passangers based on number of doors</returns>
        public override int GetNumberOfPassengers()
        {
            if (_numberOfDoors == 1)
            {
                return 2;
            }

            return _numberOfDoors;
        }

        public override string ToString()
        {
            return base.ToString() + $" number of doors: {_numberOfDoors}";
        }
    }
}
