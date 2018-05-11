using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealFinalProjectJordanBurdick
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero();
            Hero myOtherHero = new Hero("Flash", "Zoom", "Human", "Speed", true);
            Hero thirdHero = new Hero("Wonder Woman", "All bad people", "Amazonian", "Stength, Speed, Fly");

            Hero Hero1 = new Hero("SuperMan",25,9);
            {
                Hero1.ChargePower(2);
                Hero1.Investigate();
                Hero1.FightCrime("New York City");
                Hero1.ChargePower(40);
                Hero1.FightCrime("New York City");
                Hero1.Climb(20);
            }
            Hero hero2 = new Hero("Iron Man", "Mandarin", "Human", "Armor, Ranged, Speed, Fly");
            hero2.Fly();
            hero2.Investigate();
            hero2.ChargePower(99);
            hero2.FightCrime("5783 Ocean Drive California");
            hero2.Climb(29);
            hero2.Fly();

            Hero hero3 = new Hero("Spider Man", "Sand Man", "Human", "Web shooting");
            hero3.Fly();
            Console.WriteLine("Spider Man: 'Oh yeah I forgot I can't fly'");
            hero3.Climb(200);
            hero3.FightCrime("10036 2 Times Square");
            hero3.Investigate();
            hero3.ChargePower(999);
            /*
                Problem 7:
                Each Hero must:
                 - ChargePower (as much as you want)
                 - Investigate
                 - FightCrime (at least one must win. at least one must not win)
                 - Fly (at least one superhero should be able to fly)
                 - Climb
            */
        }
    }
}
