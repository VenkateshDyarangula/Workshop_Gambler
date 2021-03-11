using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler
{
     class UC4_After_20_Days
    {  
          public void after20Days()
          { 
            UC1_Start varr = new UC1_Start();
            int bet = varr.win_Loose();
            int stack = varr.getEvery_Day();
            int total_Day = 20;
            for (int i = 1; i <= total_Day; i++)
                {
                    if (bet == 0)
                    {
                       // Console.WriteLine("Loose the game");
                        //stack = stack - 50;
                        stack = i + stack;
                        if (stack == 50)
                        {
                            Console.WriteLine("Resigned");
                        }

                    }
                    else if (bet == 1)
                    {
                        //Console.WriteLine("Won the Game");
                        stack = stack + 50;
                        if (stack == 150)
                        {
                            Console.WriteLine("Resigned");
                        }
                    }   
             }            
        }
    }
}
