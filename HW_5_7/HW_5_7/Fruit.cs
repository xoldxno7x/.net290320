using System;
using System.Collections.Generic;
using System.Text;

namespace HW_5_7
{
    abstract class Fruit
    {
        public string _name;
        public int _calories;

        public abstract bool IsThisMyFavoriteFood();
        
        public override string ToString()
        {
            return $"Fruit: name is {_name}, calories are {_calories}";
        } 
    
}
}
