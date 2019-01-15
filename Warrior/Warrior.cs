using System;
using System.Threading;
using Warrior.Enum;
using Warrior.Equipment;

namespace Warrior
{
    class Warrior
    {
        // readonly is a constant that takes effect at run time in the constructor
        private readonly Faction FACTION;

        private const int Good_Guy_Starting_Health = 20;
        private const int Bad_Guy_Starting_Health = 20;
        private int health;
        private string name;
        private bool isAlive;


        private Weapon weapon;
        private Armor armor;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        public Warrior()
        {

        }

        public Warrior(Faction faction, string name)
        {
            isAlive = true;
            this.FACTION = faction;
            this.name = name;

            switch (faction)
            {
                case Faction.Good:
                    health = Good_Guy_Starting_Health;
                    weapon = new Weapon(Faction.Good);
                    armor = new Armor(Faction.Good);
                    break;
                case Faction.Bad:
                    health = Bad_Guy_Starting_Health;
                    weapon = new Weapon(Faction.Bad);
                    armor = new Armor(Faction.Bad);
                    break;
                default:
                    break;
            }
            //Console.WriteLine(faction);
            //Console.ReadLine();
        }

        public void Attack(Warrior enemy)
        {
            int damage = weapon.Damage / enemy.armor.Protection;
            //enemy.health = enemy.health - damage;
            enemy.health -= damage;

            AttackResult(enemy, damage);
            Thread.Sleep(200);
        }

        private void AttackResult(Warrior enemy, int damage)
        {
            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                //Console.ForegroundColor = ConsoleColor.Red;
                tools.ColorMessage($"{enemy.name} is dead!", ConsoleColor.Red);
                tools.ColorMessage($"{name} is victorious!", ConsoleColor.Green);
                System.Console.ReadLine();
            }
            else
            {
                //Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{name} attacked. {damage} damage was inflected to {enemy.name}, remaining health of {enemy.name} is {health}");
                //Console.ReadLine();
            }
        }
    }
}
