using System;
using System.Collections.Generic;
using System.Text;

namespace HW_19_7
{
    internal class MyButton
    {
        protected Point _topLeft;
        protected Point _buttomRight;
        private int _width;
        private int _height;

        internal MyButton(Point TopLeft, Point BottomRight)
        {
            _topLeft = TopLeft;
            _buttomRight = BottomRight;
        }

        internal int GetWidth()
        {
            return _width;
        }

        internal int GetHight()
        {
            return _height;
        }

        internal bool SetTopLeft(Point tl)
        {
                if(tl.Y <= _buttomRight.Y || tl.X >= _buttomRight.X)
                {
                    return false;
                }

                _topLeft = tl;
                _height = getDifferance(_topLeft.X,_buttomRight.X);
                return true;

        }

       
        internal bool SetButtomRight(Point br)
        {
            
                if (br.Y >= _topLeft.Y || br.X <= _topLeft.X)
                {
                    return false;
                }

                _buttomRight = br;
                _width = getDifferance(_buttomRight.X,_topLeft.X);
                return true;

        }

        internal Point GetBottomRight()
        {
            return _buttomRight;
        }

        internal Point GetTopLeft()
        {
            return _topLeft;
        }

        //Helper method to get hight and width
        private int getDifferance(int n_1,int n_2)
        {
            return Math.Abs(n_2 - n_1);
        }

        public override string ToString()
        {
            return $"My Button [ Top Left: {_topLeft}, Bottom Right: {_buttomRight}, Height: {_height}, Width: {_width}]";
        }
    }
}
