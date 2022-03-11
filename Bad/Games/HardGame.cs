using System;

using Bad.GameObjects;
using Bad.Monsters;

namespace Bad.Games
{
    /// Класс представляет игру тяжёлой сложности
    class HardGame : IGame
    {
        private static Random rnd = new Random();

        private Park location;
        private Hero gamer;

        public HardGame()
        {
            gamer = new Hero();

            Tree[] trees = new Tree[] { 
                new Tree(),
                new Tree(),
                new Tree()
            };

            Bench[] benches = new Bench[] { 
                new Bench(),
                new Bench(),
                new Bench()
            };

            IMonster[] Monsters = new IMonster[100];

            string[] MonstersEnum = new string[] {
                "Средний",
                "Большой"
            };

            for (int i = 0; i < Monsters.Length; i++)
            {
                switch (MonstersEnum[rnd.Next(0, MonstersEnum.Length)]) 
                {
                    case "Средний":
                        Monsters[i] = new middleMonster();
                        break;
                    case "Большой":
                        Monsters[i] = new bigMonster();
                        break;
                    default:
                        throw new Exception("Таких конкретных классов нет D:");
                }
            }

            location = new Park(Monsters, trees, benches); 
        }

        public void StartGame()
        {
            Console.WriteLine("Локация загружена");
            Console.WriteLine("Деревья расставлены");
            Console.WriteLine("Скамейки расставлены");
            Console.WriteLine("Монстры на местах");
            Console.WriteLine("Игрок загружен");
            Console.WriteLine("И тут игра, такая, начинается");

            location.MonsterInfo(); 
        }

        public override string ToString()
        {
            return "Сложный уровень сложности";
        }
    }
}
