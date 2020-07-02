using System;
using System.Collections.Generic;
using System.Text;

namespace HW_5_7
{
    class Tomato : Fruit
    {
        public bool _isSherry;
        public override bool IsThisMyFavoriteFood()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $" is Sherry: {_isSherry}";
        }
    }
}
