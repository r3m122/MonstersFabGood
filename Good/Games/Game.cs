using System;
using Good.GameObjects;

namespace Good
{
    class Game
    {
        private Park location;
        private Hero gamer;

        public Game(IMonsterFactory factory)
        {
            gamer = new Hero(); // В игре должен быть главный герой, за которого бы будем играть

            Tree[] trees = new Tree[] { // Задаём список деревьев, которые будут на локации
                new Tree(),
                new Tree(),
                new Tree()
            };

            Bench[] benches = new Bench[] { // Задаём список скамеек, которые будут на локации
                new Bench(),
                new Bench(),
                new Bench()
            };

            IMonster[] Monsters = new IMonster[100]; // Задаём список монстров на локации

            for(int i = 0; i < Monsters.Length; i++)
            {
                Monsters[i] = factory.Create();
            }

            location = new Park(Monsters, trees, benches); // инициализируем игровую локацию
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
    }
}
