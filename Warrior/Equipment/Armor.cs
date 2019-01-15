
using Warrior.Enum;

namespace Warrior.Equipment
{
    class Armor
    {
        private int protection;
        private const int Good_Guy_Armor = 5;
        private const int Bad_Guy_Armor = 5;

        public int Protection
        {
            get
            {
                return protection;
            }
        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.Good:
                    protection = Good_Guy_Armor;
                    break;
                case Faction.Bad:
                    protection = Bad_Guy_Armor;
                    break;
                default:
                    break;
            }
        }
    }
}
