using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler_problem
{
    class Gambler
    {
        const string StakeEveryday = "$100";
        const string Bet = "$1";
        public void Start()
        {
            Console.WriteLine("Gambler is starting with stack of"+StakeEveryday+"and bet"+Bet+"per game");
        }
    }
}
