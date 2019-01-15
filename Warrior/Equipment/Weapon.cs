using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warrior.Enum;

namespace Warrior.Equipment
{
    class Weapon
    {
        private int damage;
        private const int Good_Guy_Damage = 5;
        private const int Bad_Guy_Damage = 5;

        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.Good:
                    damage = Good_Guy_Damage;
                    break;
                case Faction.Bad:
                    damage = Bad_Guy_Damage;
                    break;
                default:
                    break;
            }
        }
    }
}
