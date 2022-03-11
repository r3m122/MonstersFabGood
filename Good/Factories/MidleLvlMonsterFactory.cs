using Good.Monsters;

namespace Good.Factories
{ 
    /// <summary>
    /// 
    /// Класс представляющий фабрику, которая генерирует монстров
    /// для среднего уровня сложности
    /// 
    /// (абсолютно рандомно, но сначала генерит 10 сильных мобов)
    class MidleLvlMonsterFactory : IMonsterFactory
    {
        private static int HardMonsterCount = 0;

        public IMonster Create()
        {
            if(HardMonsterCount < 10) 
            {
                HardMonsterCount += 1;
                return new bigMonster(); 
            }
            IMonsterFactory ezFactory = new EzLvlMonsterFactory();
            return ezFactory.Create();
        }

        public override string ToString()
        {
            return "Средний уровень сложности";
        }
    }
}
