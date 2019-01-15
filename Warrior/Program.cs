using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warrior.Enum;

namespace Warrior
{
    class Program
    {
        static Random rng = new Random();

        static void Main(string[] args)
        {
            Warrior one = new Warrior(Faction.Good, "Grethel");
            Warrior two = new Warrior(Faction.Bad, "Samuel");

            while (one.IsAlive && two.IsAlive)
            {
                if (rng.Next(0, 10) < 5)
                {
                    one.Attack(two);
                }
                else
                {
                    two.Attack(one);
                }
            }
        }
    }
}
