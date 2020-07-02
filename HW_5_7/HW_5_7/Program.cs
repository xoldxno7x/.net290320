using System;

namespace HW_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple ap = new Apple()
            {
                _calories = 60,
                _color = "green",
                _name = "Golan",
                _pinkLady = false

            };

            Apple ap2 = new Apple()
            {
                _calories = 60,
                _color = "red",
                _name = "PoisonApple",
                _pinkLady = true
            };

            Banana bn = new Banana()
            {
                _calories = 120,
                _hasBlackSpots = false,
                _isGreen = true,
                _name = "banana",
                _size = 10
            };

            Banana bn2 = new Banana()
            {
                _calories = 180,
                _hasBlackSpots = true,
                _isGreen = false,
                _name = "bananana",
                _size = 15
            };

            FruitSalad fs = new FruitSalad();
            fs._fruits = new Fruit[4] { ap, ap2, bn, bn2 };
            Fruit[] fr = new Fruit[4] { ap, ap2, bn, bn2 };
            AppleColor(ap);
            BananaSize(bn2);
            TotalSaladCall(fs);
            IsMyFavFruitHere(fs);
            Console.WriteLine(NewSalad(fr));

        }

        public static void AppleColor(Apple ap)
        {
            Console.WriteLine(ap._color);
        }

        public static void BananaSize(Banana bn)
        {
            Console.WriteLine(bn._size);
        }

        public static void TotalSaladCall(FruitSalad fs)
        {
            Console.WriteLine(fs.getTotalCalories());
        }

        public static void IsMyFavFruitHere(FruitSalad fs)
        {
            Console.WriteLine(fs.ContainsMyFavoriteFruit());
        }

        public static FruitSalad NewSalad(Fruit[] fa)
        {
            FruitSalad fs = new FruitSalad();
            
            fs._fruits = (Fruit[])fa.Clone();
           
            return fs;
        }

    }
}
