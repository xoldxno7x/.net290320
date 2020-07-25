using System;
using System.Collections.Generic;
using System.Text;

namespace NewsComp
{
    public class Newspaper
    {
        private Story[] _stories;
        private float _price;

        public Newspaper(Story[] story, float price)
        {
            if(story.Length != 3)
            {
                throw new Exception("Should get an array with exactly 3 stories");
            }
            else
            {
                _stories = story;
            }
           _price = price;
        }

        public Story[] GetStories()
        {
            if(_stories != null)
            {
                return _stories;
            }

            return new Story[0];
        }

        public void SetStories(Story[] arr)
        {
            _stories = arr;
        }

        public float GetPrice()
        {
            return _price;
        }

        public void SetPrice(float p)
        {
            _price = p;
        }

        public void Read()
        {
            if(_stories == null || _stories.Length == 0)
            {
                Console.WriteLine("No stories");
                return;
            }
            foreach(Story s in _stories)
            {
                Console.WriteLine(s);
            }
        }

        private string storyStringHelper()
        {
            String s = "";
            if (_stories == null || _stories.Length == 0)
            {
                return "No stories";
            }
            foreach (Story st in _stories)
            {
                s += st;
            }

            return s;
        }

        public override string ToString()
        {
            return $"Newspapaer: [ price is: {_price}, stories are: {storyStringHelper()}]";
        }
    }
}
