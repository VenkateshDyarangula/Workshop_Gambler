using System;

namespace Gambler
{
    class Program
    {
        static void Main(string[] args)
        {
           //Console.WriteLine("HelloWorld");
            
         UC1_Start var = new UC1_Start();
         int game = var.getEvery_Game();
         int day = var.getEvery_Day();
         int bet = var.win_Loose();
         if (bet == 0)
            {
                //int day = var.every_Day;
                Console.WriteLine("Loose the game");
                day -= 1;
                Console.WriteLine(day);
            }
            else if (bet == 1)
            {
                //int day = var.every_Day;
                Console.WriteLine("Won the Game");
                day += 1;
                Console.WriteLine(day);
            }
    
   }
}

