using System;

namespace NewsComp
{
    class Program
    {
        static void Main(string[] args)
        {
            GossipTeam gt = new GossipTeam();
            gt.CreateStory();
            gt.AddStyle();
          
            PoliticsTeam pt = new PoliticsTeam();
            pt.CreateStory();
            pt.AddStyle();
            
            HealthTeam ht = new HealthTeam();
            ht.CreateStory();
            ht.AddStyle();

            Story[] st = new Story[3] { gt.GetStory(), pt.GetStory(), ht.GetStory() };
            Newspaper times = new Newspaper(st, (float)14.99);
            Console.WriteLine(times);
            Console.WriteLine(NewspaperCalculator.CalcNumberOfChars(times));
        }
    }
}
