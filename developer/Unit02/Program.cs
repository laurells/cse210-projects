using Unit02.Game;

namespace Unit02;

/// <summary>
/// The program's entry point.
/// </summary>
class Program
{
    ///Begins the Hi-Lo game by calling the Director class
    static void Main(string[] args)
    {
        Director director = new Director();
        director.StartGame();
        return 0;
    }
}