using System;

namespace Gambler
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("HelloWorld");
            UC1_Start var = new UC1_Start();
            int bet = var.win_Loose();
            if (bet == 0)
            {
                //int day = var.every_Day;
                Console.WriteLine("Loose the game");
                day -= 1;
            }
            else if (bet == 1)
            {
                //int day = var.every_Day;
                Console.WriteLine("Won the Game");
                day += 1;
            }
        }
    }
}

