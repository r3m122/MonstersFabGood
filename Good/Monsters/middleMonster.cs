using System;

namespace Good.Monsters
{
    class middleMonster : IMonster
    {
        public void BatleRoar()
        {
            Console.WriteLine("ааааааааррр");
        }

        public override string ToString()
        {
            return "Средний";
        }
    }
}
