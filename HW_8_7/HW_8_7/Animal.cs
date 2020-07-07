using System;
using System.Collections.Generic;
using System.Text;

namespace HW_8_7
{
    abstract class Animal
    {
        public string _name;

        public Animal(string name)
        {
            _name = name;
        }
        public abstract void MakeSound();

        public override string ToString()
        {
            return $"Name: {_name}";
        }
    }
}
