using System;

namespace Gambler_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Welcome to Gambler problem  ");
            Gambler gambler = new Gambler();
            gambler.Start();
            gambler.WinLoose();
        }
    }
}
