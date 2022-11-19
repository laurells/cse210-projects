using System;


namespace Unit05.Game.Casting
{
    /// <summary>
    /// <para>The score of player one.</para>
    /// <para>
    /// The responsibility of OneScore is to keep track of Player one's score.
    /// </para>
    /// </summary>
    public class OneScore : Actor
    {
        private int _points = 0;

        /// <summary>
        /// Constructs a new instance of an OneScore.
        /// </summary>
        public OneScore()
        {
            AddPointsOne(0);
        }

        /// <summary>
        /// Adds the given points to the score.
        /// </summary>
        /// <param name="points">The points to add.</param>
        public void AddPointsOne(int points)
        {
            this._points += points;
            SetText($"Player One: {this._points}");
        }
    }
}