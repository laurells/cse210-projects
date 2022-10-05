using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    
    public class Director
    {
        List<Die> _dice = new List<Die>();
        bool _isPlaying = true;
        int _score = 0;
        int _totalScore = 0;

        
        /// Constructs a new instance of Director.
        
        public Director()
        {
            for (int i = 0; i < 5; i++)
            {
                Die die = new Die();
                _dice.Add(die);
            }
        }

        
        /// Starts the game by running the main game loop.
        
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        
        /// Asks the user if they want to roll.
        
        public void GetInputs()
        {
            Console.Write("Roll dice? [y/n] ");
            string rollDice = Console.ReadLine();
            _isPlaying = (rollDice == "y");
        }

        
        /// Updates the player's score.
        
        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }

            _score = 0;
            foreach (Die die in _dice)
            {
                die.Roll();
                _score += die._points;
            }
            _totalScore += _score;
        }

        
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }

            string values = "";
            foreach (Die die in _dice)
            {
                values += $"{die._value} ";
            }

            Console.WriteLine($"You rolled: {values}");
            Console.WriteLine($"Your score is: {_totalScore}\n");
            _isPlaying = (_score > 0);
        }
    }
}


