using System;

using Good.Factories;

namespace Good
{
    class Program
    {
        static void Main(string[] args)
        {
            IMonsterFactory[] lvls = new IMonsterFactory[] { 
                new EzLvlMonsterFactory(),
                new MidleLvlMonsterFactory(),
                new HardLvlMonsterFactory()
            };

            Console.WriteLine("Выберете уровень сложности и введите его номер:");

            for (int i = 0; i < lvls.Length; i++) 
            {
                Console.WriteLine($"{i+1}. {lvls[i].ToString()}"); // i+1 потому что нормальные люди считают с 1, а не с 0
            }

            int lvlNumber = Convert.ToInt32(Console.ReadLine()) - 1; // -1 потому что нормальные люди всё ещё считают с 1

            if(lvlNumber > -1 && lvlNumber < lvls.Length) {
                Game game = new Game(lvls[lvlNumber]); // создаём игру с выбранным уровнем сложности
                game.StartGame();
            }
                else
            {
                Console.WriteLine("Недопустимое число");
            }
            
            Console.ReadKey();
        }
    }
}
