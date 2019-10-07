using System;
using burgershack.Controllers;

namespace burgershack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            DrinkController dc = new DrinkController();
            while(true)
            {
                dc.UserInput();
            }
        }
    }
}
