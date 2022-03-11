using System;

namespace Bad.Monsters
{
    class littleMonster : IMonster
    {
        //вообще можно было и не добавлять крики монстров, но так прикольнее)))
        public void BatleRoar()
        {
            Console.WriteLine("ааааар");
        }

        public override string ToString()
        {
            return "Маленький";
        }
    }
}