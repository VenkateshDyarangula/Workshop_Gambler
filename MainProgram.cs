using System;

namespace Gambler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            UC4_After_20_Days uc4 = new UC4_After_20_Days();
            UC3_Resign uc3 = new UC3_Resign();
            //Uc1 Calling
            Program p = new Program();
            p.winorLoose();
            uc3.resigned();
            uc4.after20Days();
        }
        public void winorLoose()
        {
            UC1_Start var = new UC1_Start();
            int game = var.getEvery_Game();
            int day = var.getEvery_Day();
            int bet = var.win_Loose();
            Console.WriteLine(game);
            Console.WriteLine(bet);
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
