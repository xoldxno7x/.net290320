using System;
using System.Collections.Generic;
using System.Text;

namespace HW_5_7
{
    class Apple : Fruit
    {
        public string _color;
        public bool _pinkLady;
        public override bool IsThisMyFavoriteFood()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $" color: {_color}, is Pink Lady: {_pinkLady}";
        }
    }
}
