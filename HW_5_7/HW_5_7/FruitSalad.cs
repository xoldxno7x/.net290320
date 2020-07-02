using System;
using System.Collections.Generic;
using System.Text;

namespace HW_5_7
{
    class FruitSalad
    {
        public Fruit[] _fruits;

        /// <summary>
        /// Iterates over fruits in O(n) 
        /// </summary>
        /// <returns>int sum - the sum of all cals</returns>
        public int getTotalCalories()
        {
            int sum = 0;
            foreach (Fruit fr in _fruits)
            {
                sum += fr._calories;
            }

            return sum;
        }


        /// <summary>
        /// Iterates over fruits in O(n) 
        /// </summary>
        /// <returns> true if finds favorite Fruit false if doesnt</returns>
        public bool ContainsMyFavoriteFruit()
        {
            foreach (Fruit fr in _fruits)
            {
                if (fr.IsThisMyFavoriteFood())
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            string ts = "Fruits in Salad: ";
            int i = 0;

            for (i = 0; i < _fruits.Length - 1; i++)
            {
                ts += $"[ {i + 1} : { _fruits[i]} ] ,";
            }

            return ts + $"[ {i+1} : {_fruits[i]} ]";
        }
    }

    
}
