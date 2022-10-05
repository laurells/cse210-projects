using Unit02.Game;


namespace Unit02
{
    /// The program's entry point.
    class Program
    {
        ///Begins the Hi-Lo game by calling the Director class
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome To The Hilo Game!");
            Director player = new Director();
            player.StartGame();
        }
    }
}