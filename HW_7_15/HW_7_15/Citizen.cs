using System;
using System.Collections.Generic;
using System.Text;

namespace HW_7_15
{
    class Citizen
    {
        public string _name;
        public Citizen[] _children;
        public readonly int _fatherID;
        public readonly int _id;
        public static int _numberOfCurrentCitizens;
        public const int MAXIMUM_NUMBER_OF_CITIZENS = 1000000;

        public Citizen(string name, int fatherID)
        {
            _name = name;
            _fatherID = fatherID;
            _numberOfCurrentCitizens++;
            _id = _numberOfCurrentCitizens + fatherID;
            _children = new Citizen[0];
        }

        public static void PrintNumberOfCitizens()
        {
            Console.WriteLine(_numberOfCurrentCitizens);
        }

        public static bool ReachedHalfOfMaximumSize()
        {
            return _numberOfCurrentCitizens >= MAXIMUM_NUMBER_OF_CITIZENS;
        }

        public void PrintID()
        {
            Console.WriteLine(_id);
        }

        public void PrintGapBetweenMyIDAndFather()
        {
            Console.WriteLine(Math.Abs(_fatherID-_id));
        }

        public void SetChildren(Citizen[] arr)
        {
            _children = arr;
        }

        //Helper method for ToString
        private string PrintChildren()
        {

            if(_children != null && _children.Length != 0)
            {
                string s = "children: [ ";

                foreach (Citizen c in _children)
                {
                    s += c.ToString() + " ";
                }

                return s + " ]";
            }

            return "no children";
            
        }

        public override string ToString()
        {
            return $"Citizen: name is {_name}, {PrintChildren()}, father ID is {_fatherID}, id is {_id}, number of current citizens is {_numberOfCurrentCitizens}, maximum number of citizens is {MAXIMUM_NUMBER_OF_CITIZENS}";
        }
    }
}
