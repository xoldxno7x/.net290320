using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HW_5_7
{
    class Banana : Fruit
    {
        public bool _hasBlackSpots;
        public bool _isGreen;
        public float _size;
        public override bool IsThisMyFavoriteFood()
        {
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + $" has black spots: {_hasBlackSpots}, is green: {_isGreen}, size: {_size}";
        }
    }
}
