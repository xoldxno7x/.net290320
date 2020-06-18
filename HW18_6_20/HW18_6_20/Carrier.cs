using System;
using System.Collections.Generic;
using System.Text;

namespace HW18_6_20
{
    class Carrier
    {
        public Vehicle[] _vehicles;

        public override string ToString()
        {
            int i;
            string res = "Vehicles: [";

            for (i = 0; i < _vehicles.Length - 1; i++)
            {
                res += $"{i+1}: {_vehicles[i]} | ";
            }

            res += $"{i + 1}: {_vehicles[_vehicles.Length - 1]}]";
            
            return res;
        }
    }
}
