using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace HW_19_7
{
    class MyCanvas
    {
        public const int MAX_WIDTH = 800;
        public const int MAX_HEIGHT = 600;
        private static int _buttonIndex = 0;
        private const int MAX_BUTTONS = 3;
        private static MyButton[] _buttons = new MyButton[MAX_BUTTONS];

        public static bool CreateNewButton(int x1,int y1,int x2,int y2)
        {

            if(x1 < x2 && y1 > y2)
            {
                MyButton mb = new MyButton(new Point(x1, y1), new Point(x2, y2));
                
                if(_buttonIndex < MAX_BUTTONS)
                {
                    _buttons[_buttonIndex] = mb;
                    _buttonIndex++;
                }
                else
                {
                    return false;
                }
                
                return true;
            }

            return false;
            
        }

        public static bool MoveButton(int buttonNumber,int x,int y)
        {
            if(buttonNumber <= _buttonIndex)
            {
                _buttons[buttonNumber].SetButtomRight(new Point(_buttons[buttonNumber].GetBottomRight().X + x,
                    _buttons[buttonNumber].GetBottomRight().Y + y));

                _buttons[buttonNumber].SetTopLeft(new Point(_buttons[buttonNumber].GetTopLeft().X + x,
                    _buttons[buttonNumber].GetTopLeft().Y + y));
            }

            return false;
        }

        public static bool DeleteLastButton()
        {
            if(_buttonIndex == MAX_BUTTONS)
            {
                _buttons[MAX_BUTTONS] = null;
                return true;
            }
            return false;
        }

        //instead of nullifying the all array members, im creating a new array
        //as no instance points at the old array, it should be garbage collected 
        //we can also call System.GC.Collect() but its costly 
        public static void ClearAllButtons()
        {
            _buttons = new MyButton[MAX_BUTTONS];
        }

        public static int GetCurrentNumberOfButtons()
        {
            return _buttonIndex + 1;
        }
        
        public static int GetMaxNumberOfButtons()
        {
            return MAX_BUTTONS;
        }
        
        public static int GetMaxWidthOfButtons()
        {
            return MAX_WIDTH;
        }
        public static int GetMaxHeightOfButtons()
        {
            return MAX_HEIGHT;
        }

        public static bool IsPointInsideAButton(Point p)
        {
            
            foreach (MyButton b in _buttons)
            {
                if(p.X < b.GetBottomRight().X && p.X > b.GetTopLeft().X && p.Y < b.GetTopLeft().Y && p.Y > b.GetBottomRight().Y)
                {
                    return true;
                }
            }

            return false;
        }

        //O(n^2) - however as the array is this small it will not be noticible
        //If we had bigger arrays, we could have created implemented iComparable, quick sorted the array
        //and used binary searvh to achieve O(nlog^n)
        public static bool CheckifAnyButtonIsOverlapping()
        {
            foreach (MyButton mb in _buttons)
            {
                if(checkVertical(mb) || checkHorizontal(mb))
                {
                    return true;
                }
                
            }

            return false;
        }

        //Check the buttons share the same diagonal on the left of button a - the right of button b
        //If they do, make sure this diagonal is within the horizontal borders of one of the buttons 
        

        private static bool checkVertical(MyButton m)
        {
            foreach (MyButton mb in _buttons)
            {
                if (m == mb)
                {
                    continue;
                }

                if ((m.GetTopLeft().X == mb.GetBottomRight().X || m.GetBottomRight().X == mb.GetTopLeft().X )&&
                    (m.GetTopLeft().Y <= mb.GetTopLeft().Y && m.GetBottomRight().Y >= mb.GetBottomRight().Y)
                    || (m.GetTopLeft().Y >= mb.GetTopLeft().Y && m.GetBottomRight().Y <= mb.GetBottomRight().Y))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool checkHorizontal(MyButton m)
        {
            foreach (MyButton mb in _buttons)
            {
                if(m == mb)
                {
                    continue;
                }

                if(m.GetTopLeft().Y == mb.GetTopLeft().Y || m.GetBottomRight().Y == mb.GetBottomRight().Y)
                {
                    return true;
                }
            }

            return false;
        }


        private string printArray()
        {
            string s= "[ ";

            if (_buttonIndex > 0)
            {
                foreach (MyButton mb in _buttons)
                {
                    s += mb;
                }

                return s + " ]";
            }

            return "[ No buttons ]";
        }

        public override string ToString()
        {
            return $" My Canvas: [ Max width is: {MAX_WIDTH}, Max height is: {MAX_HEIGHT}, number of buttons: {_buttonIndex}, Max buttons: {MAX_BUTTONS}, buttons: {printArray()}   ]";
        }

    }
}
