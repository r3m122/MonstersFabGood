using System;

namespace Good.Monsters
{
    class bigMonster : IMonster
    {
        public void BatleRoar()
        {
            Console.WriteLine("ффффффаааррррр");
        }

        public override string ToString()
        {
            return "Большой";
        }
    }
}
