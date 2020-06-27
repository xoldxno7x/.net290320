using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6_28
{
    class Game
    {
        public string _name;
        public int _numberOfPlayers;
        public float _rating;
        public string _originCountry;

        public Game()
        {
        }

        public Game(string name, float rating = (float)5.5)
        {
            _name = name;
            _rating = rating;
        }

        public Game(string name, int numberOfPlayers, float rating, string originCountry)
        {
            _name = name;
            _numberOfPlayers = numberOfPlayers;
            _rating = rating;
            _originCountry = originCountry;
        }

        public int TellMeHowManyPlayers()
        {
            return _numberOfPlayers;
        }

        public override string ToString()
        {
            return $"Game: name is {_name}, number of players is {_numberOfPlayers}, rating is {_rating}, origin country is {_originCountry}";
        }
    }
}
