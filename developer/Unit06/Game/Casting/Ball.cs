using System;
using System.Collections.Generic;

namespace Unit06.Game.Casting
{
    public class Ball : Actor
    {
        private static Random _random = new Random();
        private Body _body;
        private Image _image;
    
        /// <summary>
        /// Constructs a new instance
        /// </summary>
        public Ball(Body body, Image image, bool debug = false) : base(debug)
        {
            this._body = body;
            this._image = image;
        }
        ///<summary>
        ///Bounces the ball horizontally
        ///</summary>
        public void BounceX()
        {
            Point velocity = _body.GetVelocity();
            double rn = (_random.NextDouble() * (1.2 - 0.8) + 0.8);
            double vx = velocity.GetX();
            double vy = velocity.GetY() * -1;
            Point newVelocity = new Point((int)vx, (int)vy);
            _body.SetVelocity(newVelocity);

        }
        /// <summary>
        /// Gets the image
        /// </summary>
        /// <returns>The image.</returns>
        public Image GetImage()
        {
            return image;
        }

        /// <summary>
        ///RElease the ball in random horizontal direction
        /// </summary>
        public void Release()
        {
            Point velocity = _body.GetVelocity();
            List<int> velocities = new List<int> {Constants.BALL_VELOCITY, Constants.BALL_VELOCITY, Constants.BALL_VELOCITY};
            int index = _random.Next(velocities.Count);
            double vx = velocities[index];
            double vy = -Constants.BALL_VELOCITY;
            Point newVelocity = new Point(int)vx, (int)vy;
            _body.SetVelocity(newVelocity);
        }
    }        
}