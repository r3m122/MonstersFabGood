using System;

using Good.Monsters;

namespace Good.Factories
{
    /// Класс представляющий фабрику, которая генерирует монстров
    /// для сложного уровня сложности
    class HardLvlMonsterFactory : IMonsterFactory
    {
        private static Random rnd = new Random();
        public IMonster Create()
        {
            string[] Monsters = new string[] {
                "Средний",
                "Большой"
            };

            switch (Monsters[rnd.Next(0, Monsters.Length)]) // Рандомно выбираем из гопников и нудистов
            {
                case "Средний":
                    return new middleMonster();
                case "Большой":
                    return new bigMonster();
                default:
                    throw new Exception("Таких конкретных классов нет D:");
            }
        }

        public override string ToString() // реализуем приведение экземпляра класс к строке
        {
            return "Сложный уровень сложности";
        }
    }
}
