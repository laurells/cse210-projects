using System;

namespace unit02.Game
{
    class Card
    {
        public int cardValue;

        ///Draws a random card for the user/player
        public void getNewCard(){
            Random randomGenerator = new Random();
            cardValue = randomGenerator.Next(1,14);
        }
    }
}