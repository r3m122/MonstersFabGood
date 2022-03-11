using System;

using Good.Monsters;

namespace Good.Factories
{
    /// Класс представляющий фабрику, которая генерирует монстров
    /// для лёгкого уровня сложности
    class EzLvlMonsterFactory : IMonsterFactory
    {
        private static Random rnd = new Random();

        public IMonster Create()
        {
            string[] Monsters = new string[] {
                "Маленький",
                "Средний",
                "Большой"
            };

            switch(Monsters[rnd.Next(0, Monsters.Length)]) 
            {
                case "Маленький":
                    return new littleMonster();
                case "Средний":
                    return new  middleMonster();
                case "Большой":
                    return new bigMonster();
                default:
                    throw new Exception("Таких конкретных классов нет D:");
            }
        }

        public override string ToString()
        {
            return "Лёгкий уровень сложности";
        }
    }
}
