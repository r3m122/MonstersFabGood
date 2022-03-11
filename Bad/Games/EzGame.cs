using System;

using Bad.GameObjects;
using Bad.Monsters;

namespace Bad.Games
{
    /// Класс представляет игру лёгкой сложности
    class EzGame : IGame
    {
        private static Random rnd = new Random();

        private Park location;
        private Hero gamer;

        public EzGame()
        {
            gamer = new Hero();

            Tree[] trees = new Tree[] { // Задаём список деревьев, которые будут на локации
                new Tree(),
                new Tree(),
                new Tree()
            };

            Bench[] benches = new Bench[] { // Задаём список скамеек, которые буду на локации
                new Bench(),
                new Bench(),
                new Bench()
            };

            IMonster[] Monsters = new IMonster[100];

            string[] MonstersEnum = new string[] {
                "Маленький",
                "Средний",
                "Большой"
            };

            for (int i = 0; i < Monsters.Length; i++)
            {
                switch (MonstersEnum[rnd.Next(0, MonstersEnum.Length)]) 
                {
                    case "Маленький":
                        Monsters[i] = new littleMonster();
                        break;
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
            return "Лёгкий уровень сложности";
        }
    }
}
