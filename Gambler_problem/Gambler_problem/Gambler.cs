using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler_problem
{
    class Gambler
    {
        const string StakeEveryday = "$100";
        const string Bet = "$1";
        /// <summary>
        /// starting with all details of gambler
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Gambler is starting with stack of"+StakeEveryday+"and bet"+Bet+"per game");
        }
        int Win = 1;
        int Loose = 0;
        /// <summary>
        /// 
        /// checking for gambler win or loose
        /// </summary>
        public void WinLoose()
        {
            Random random = new Random();
            int Check = random.Next(0, 2);
            if(Check == Win)
            {
                Console.WriteLine("the gambler win the game will get the bet of:"+Bet);       
            }
            if(Check == Loose)
            {
                Console.WriteLine("gambler loose");
            }
            else
                Console.WriteLine("The game stopped/drawn");

        }
    }
}
