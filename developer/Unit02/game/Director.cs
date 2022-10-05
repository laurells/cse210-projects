using System;
using System.Collections.Generic;

namespace unit02.Game
{
    public class Director
    {
        List<Card> cards = new List<Card>();
        bool isPlaying = true;
        int winBonus = 100;
        int losingGame = 75;
        int totalScore = 300;

        int currentCard;
        int nextCard;
        public Director()
        {
            for (int i = 0; i < 1; i++){
                Card card = new Card();
                cards.Add(card);

            }
        }

        ///Starts game, connected to program.cs
        public void StartGame()
        {
            foreach (Card card in cards){
                card.getNewCard();
                currentCard = card.cardValue;
            }
            while (isPlaying)
            {
                MainGame();
                GameCheck();
            }
        }

        ///Main game.The cards are pulled and the user is asked for an input. 
        public void MainGame(){
            Console.WriteLine($"The card is {currentCard}");
            if (!isPlaying)
            {
                return;
            }

            foreach (Card card in cards){
                card.getNewCard();
                nextCard = card.cardValue;
            }
            Console.Write("Higher / Lower: [h/l]  ");
            string cardGuess = Console.ReadLine();
            Console.WriteLine($"The next card is:{nextCard}");
            if (cardGuess.Equals("h") && currentCard < nextCard){
                totalScore += winBonus;
            }
            else if(cardGuess.Equals("l") && currentCard > nextCard){
                totalScore += winBonus;
            }
            else if(cardGuess.Equals("h") && currentCard > nextCard){
                totalScore -= losingGame;
                if (totalScore < 0){
                    totalScore = 0;
                }
            }
            else if(cardGuess.Equals("l") && currentCard < nextCard){
                totalScore -= losingGame;
                if (totalScore < 0){
                    totalScore = 0;
                }
            }

        }

        /// Checks if the game should keep going
        public void GameCheck(){
            Console.WriteLine($"You have scored: {totalScore}");
            if (totalScore == 0){
                isPlaying = false;
            }
            if (!isPlaying)
            {
                return;
            }

            currentCard = nextCard;
            Console.Write("Keep Playing? [y/n] ");
            string rollDice = Console.ReadLine();
            
            if (rollDice == y){
                isPlaying = true;
            }
            else if (rollDice == n){
                isPlaying = false;
            }
        }
    }
}