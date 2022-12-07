using System.Collections.Generic;
using Unit06.Game.Casting;

namespace Unit06
{
    public class Constants
    {
        // Game constants
        public static string GAME_NAME = "Ping Pong Game";
        public static int FRAME_RATE = 60;

        //Screen and Screen sizing
        public static int SCREEN_WIDTH = 1040;
        public static int SCREEN_HEIGHT = 680;
        public static int CENTER_X = SCREEN_WIDTH / 2;
        public static int CENTER_Y = SCREEN_HEIGHT / 2;

        //Game Field
        public static int FIELD_TOP = 60;
        public static int FIELD_BOTTOM = SCREEN_HEIGHT;
        public static int FIELD_LEFT = 0;
        public static int FIELD_RIGHT = SCREEN_WIDTH;

        //Game Font
        public static string FONT_FILE = "Assets/Fonts/zorque.otf";
        public static int FONT_SIZE = 32;

        //Game Sound
        public static string BOUNCE_SOUND = "Assets/Sounds/boing.wav";
        public static string WELCOME_SOUND = "Assets/Sounds/start.wav";
        public static string END_SOUND = "Assets/Sounds/end.wav";

        //Text Alignment
        public static int ALIGN_LEFT = 0;
        public static int ALIGN_LEFT = 1;
        public static int ALIGN_RIGHT = 2;

        //Game Colors
        public static Color BLACK = new Color(0, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color PURPLE = new Color(255, 0, 255);

        //Game Direction
        public static string LEFT = "left";
        public static string RIGHT = "right";
        public static string UP = "w";
        public static string DOWN = "s";
        public static string UP2 = "i";
        public static string DOWN2 = "k";
        public static string SPACE = "space";
        public static string ENTER = "enter";
        public static string PAUSE = "p";

        //Game Scene
        public static string NEW_GAME = "new game";
        public static string TRY_AGAIN = "try again";
        public static string NEXT_LEVEL = "next_level";
        public static string GAME_PLAY = "game_play";
        public static string GAME_OVER = "game_over";

        //Game Levels
        public static string LEVEL_FILE = "Assets/Data/level-{0:000}.txt";
        public static int BASE_LEVEL = 5;

        //SCRIPTING CONSTANTS
        public static string INITIALIZE = "initialize";
        public static string LOAD = "load";
        public static string INPUT = "input";
        public static string OUTPUT = "output";
        public static string UNLOAD = "unload";
        public static string RELEASE = "release";

        //GAME STATS
        public static string STATS_GROUP = "stats";
        public static int DEFAULT_LIVES = 3;
        public static int MAX_LIVES = 5;

        //HUD
        public static int HUD_MARGIN = 15;
        public static string LIVES_GROUP = "lives";
        public static string SCORE_GROUP = "score";
        public static string LIVES_FORMAT = "LIVES: {0}";
        public static string SCORE_FORMAT = "SCORE: {0}";

        //Ball
        public static string BALL_GROUP = "balls";
        public static string BALL_IMAGE = "Assets/Images/000.png";
        public static int BALL_WIDTH = 28;
        public static int BALL_HEIGHT = 28;
        public static int BALL_VELOCITY = 6;

        //Racket
        public static string RACKET_GROUP = "rackets";

        public static List<string> RACKET_IMAGES = new List<string>() {
            "Assets/Images/100.png",
            "Assets/Images/101.png",
            "Assets/Images/102.png"
        };

        public static List<string> RACKET_IMAGES2 = new List<string>() {
            "Assets/Images/103.png",
            "Assets/Images/104.png",
            "Assets/Images/105.png"
        };

        public static int RACKET_WIDTH = 28;
        public static int RACKET_HEIGHT = 106;
        public static int RACKET_RATE = 6;
        public static int RACKET_VELOCITY = 7;

        //Dialog
        public static string DIALOG_GROUP = "dialogs";
        public static string ENTER_TO_START = "PRESS ENTER TO START";
        public static string LAUNCH = "PREPARING TO LAUNCH";
        public static string GOOD_GAME = "GAME OVER";
    }

}