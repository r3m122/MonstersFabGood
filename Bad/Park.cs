using System;
using System.Linq;
using Bad.GameObjects;

namespace Bad
{
    /// Класс представляющий локацию
    class Park
    {
        /// Монстры, обитающие на локации
        private IMonster[] Monsters;

        /// Деревья на локации 
        private Tree[] trees;

        /// Скамейки на локации
        private Bench[] benches;

        public Park(IMonster[] Monsters, Tree[] trees, Bench[] benches)
        {
            this.Monsters = Monsters;
            this.Monsters = Monsters;
            this.Monsters = Monsters;
        }


        public void MonsterInfo()
        {
            var littleMonster = Monsters.Where((item) => {
                return item.ToString() == "Маленький";
            }).Count();

            Console.WriteLine($"{littleMonster} Маленький");


            var middleMonster = Monsters.Where((item) => {
                return item.ToString() == "Средний";
            }).Count();

            Console.WriteLine($"{middleMonster} Средний");


            var bigMonster = Monsters.Where((item) => {
                return item.ToString() == "Большой";
            }).Count();

            Console.WriteLine($"{bigMonster} Большой");
        }

    }
}