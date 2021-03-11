using System;

namespace Gambler
{
    class Program
    {
        static void Main(string[] args)
        {
         UC1_Start var = new UC1_Start();
         UC3_Resign uc3 = new UC3_Resign();
         int game = var.getEvery_Game();
         int day = var.getEvery_Day();
         int bet = var.win_Loose();
         if (bet == 0)
            {
                Console.WriteLine("Loose the game");
                day -= 1;
                Console.WriteLine(day);
            }
            else if (bet == 1)
            {
                Console.WriteLine("Won the Game");
                day += 1;
                Console.WriteLine(day);
            }
          uc3.resigned();
   }
}

