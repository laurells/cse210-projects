using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class CollideBordersAction : Action
    {
        private AudioService audioService;
        private PhysicsService physicsService;
        
        public CollideBordersAction(PhysicsService physicsService, AudioService audioService)
        {
            this.physicsService = physicsService;
            this.audioService = audioService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Ball ball = (Ball)cast.GetFirstActor(Constants.BALL_GROUP);
            Body body = ball.GetBody();
            Point position = body.GetPosition();
            int x = position.GetX();
            int y = position.GetY();
            Sound bounceSound = new Sound(Constants.BOUNCE_SOUND);
            Sound overSound = new Sound(Constants.OVER_SOUND);

            if (x < Constants.FIELD_LEFT)
            {
            }
            else if (x >= Constants.FIELD_RIGHT - Constants.BALL_WIDTH)
            {
            }

            if (y < Constants.FIELD_TOP)
            {
                ball.BounceY();
                audioService.PlaySound(bounceSound);
            }
            else if (y >= Constants.FIELD_BOTTOM - Constants.BALL_WIDTH)
            {
                ball.BounceY();
                audioService.PlaySound(bounceSound);
            }
            
        }
    }
}