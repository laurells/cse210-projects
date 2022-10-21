using System;
using Unit03.game;

namespace Unit03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Director director = new Director();
            director.StartGame();
        }
    }
}
