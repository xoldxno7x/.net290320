using System;

namespace HW_6_28
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Game witcher = new Game("Witcher 3", 1, (float)5.5, "Poland");

            //2
            Game fallOut = new Game()
            {
                _name = "Fall Out 3",
                _originCountry = "USA",
                _numberOfPlayers = 1,
                _rating = 5
            };

            //3 
            Game doom = new Game("Doom Internal")
            {
                _numberOfPlayers = 1,
                _originCountry = "USA",
                _rating = 6
            };

            //4
            Game darkSouls = new Game("Dark Souls 3", (float)4.5)
            {
                _numberOfPlayers = 1,
                _originCountry = "Japan"
            };

            //Testing 
            PrintGame(witcher);
            PrintGame(fallOut);
            PrintGame(doom);
            PrintGame(darkSouls);
        }

        //Will have an S next to it in ILDASM
        public static void PrintGame(Game g)
        {
            int number = g.TellMeHowManyPlayers();
            Console.WriteLine(g);
        }

        //Will not have an S next to it in ILDASM
        public void notStatic()
        {

        }
    }
}
