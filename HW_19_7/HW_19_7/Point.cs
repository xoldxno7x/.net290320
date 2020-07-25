using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HW_19_7
{   
    //Could have been efault as well 
    internal class Point
    {
        private int _x;
        private int _y;

        internal Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X{
            get 
            {    
                return _x;
            }

            set
            {
                if(value < 0 || value > 800)
                {
                    throw new Exception("X value must be between 0 and 800");
                }
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                if (value < 0 || value > 600)
                {
                    throw new Exception("Y value must be between 0 and 600");
                }
            }
        }

        public override string ToString()
        {
            return $"[Point : X value is {_x}, Y value is {_y}]";
        }
    }
}
