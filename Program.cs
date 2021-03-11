using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler
{
    public class UC1_Start
    {
        private int every_Day = 100;
        private int every_Game = 1;

        public int getEvery_Day()
        {
            return every_Day;
        }

        public void setEvery_Day(int value)
        {
            this.every_Day = value;
        }



        public int getEvery_Game()
        {
            return every_Day;
        }

        public void setEvery_Game(int value)
        {
            this.every_Day = value;
        }




        public int win_Loose()
        {
            Random r = new Random();
            int bet = r.Next(0,2);
            return bet;
        }
    }
}
