using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler
{

    class UC3_Resign 
    {

        public void resigned()
        {
            UC1_Start uc11 = new UC1_Start();
            int stack = uc11.getEvery_Day();
            int bet = uc11.win_Loose();
            if (bet == 0)
            {
               Console.WriteLine("Loose the game");
                stack = stack - 50;
                if (stack == 50)
                {
                    Console.WriteLine("Resigned");
                }

            }
            else if (bet == 1)
            {
                Console.WriteLine("Won the Game");
                stack = stack + 50;
                if (stack == 150)
                {
                    Console.WriteLine("Resigned");
                }
            }
        }
    }  

}

