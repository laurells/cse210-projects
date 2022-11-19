using System.Collections.Generic;
using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawActorsAction : Action
    {
        private VideoService _videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this._videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            CycleOne cycleone = (CycleOne)cast.GetFirstActor("cycleone");
            List<Actor> segments1 = cycleone.GetSegments();
            CycleTwo cycletwo = (CycleTwo)cast.GetFirstActor("cycletwo");
            List<Actor> segments2 = cycletwo.GetSegments();
            Actor onescore = cast.GetFirstActor("onescore");
            Actor twoscore = cast.GetFirstActor("twoscore");
            twoscore.SetPosition(new Point(Constants.MAX_X -100, 0));
            List<Actor> messages = cast.GetActors("messages");
            
            _videoService.ClearBuffer();
            _videoService.DrawActors(segments1);
            _videoService.DrawActors(segments2);
            _videoService.DrawActor(onescore);
            _videoService.DrawActor(twoscore);
            _videoService.DrawActors(messages);
            _videoService.FlushBuffer();
        }
    }
}