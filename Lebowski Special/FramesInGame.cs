using System;
using System.Collections.Generic;

namespace Lebowski_Special
{
    public class FramesInGame : IFramesInGame
    {
        public FramesInGame()
        {
            Frames = new List<Frame>();
        }

        public List<Frame> Frames { get; private set; }

        public void AddFrame(Frame frame)
        {
            Frames.Add(frame);
        }
    }
}