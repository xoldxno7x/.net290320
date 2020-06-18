using System;
using System.Collections.Generic;
using System.Text;

namespace HW18_6_20
{
    abstract class Vehicle
    {
        public int _numberOfWheels;
        public string _model;

        public abstract int GetNumberOfPassengers();
        public abstract int GetMaxSpeed();

        public override string ToString()
        {
            return $"Model: {_model}, Number of wheels: {_numberOfWheels}, Max number of passangers: {GetNumberOfPassengers()}, Max speed: {GetMaxSpeed()}";
        }
    }
}
