using System;
using System.Collections.Generic;
using System.Text;

namespace HW_5_7
{
    class Mango : Fruit
    {
        public double _weight;
        public bool _isRipe;
        public override bool IsThisMyFavoriteFood()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $" Weight is: {_weight}, is ripe: {_isRipe}";
        }
    }
}
