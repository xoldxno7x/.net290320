using System;

namespace HW_19_7
{
    class Program
    {
        static void Main(string[] args)
        {
            MyButton b1 = new MyButton(new Point(1, 5), new Point(3, 1));
            MyButton b2 = new MyButton(new Point(0, 3), new Point(5, 2));
            MyButton b3 = new MyButton(new Point(5, 8), new Point(9, 0));

            MyCanvas mc = new MyCanvas();

            MyCanvas.CreateNewButton(b1.GetTopLeft().X, b1.GetTopLeft().Y, b1.GetBottomRight().X, b1.GetBottomRight().Y);
            MyCanvas.CreateNewButton(b2.GetTopLeft().X, b2.GetTopLeft().Y, b2.GetBottomRight().X, b2.GetBottomRight().Y);
            MyCanvas.CreateNewButton(b3.GetTopLeft().X, b3.GetTopLeft().Y, b3.GetBottomRight().X, b3.GetBottomRight().Y);

            Console.WriteLine(mc);
        }
    }
}
