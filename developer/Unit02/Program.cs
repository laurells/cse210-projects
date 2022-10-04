using System;
using System.Collections.Generic;
using Unit02;


namespace Unit02
{
    /// The program's entry point.
    class Program
    {
        ///Begins the Hi-Lo game by calling the Director class
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Director player = new Director();
            player.StartGame();
        }
    }
}