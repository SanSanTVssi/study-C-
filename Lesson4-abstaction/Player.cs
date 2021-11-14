using System;

namespace Lesson4_abstaction
{
    public class Player : IPlayable, IRecodable
    {
        public void Record()
        {
            Console.WriteLine("Recording");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pause recording");
        }
        
        void IPlayable.Pause()
        {
            Console.WriteLine("Pause video");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Stop video");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Stop recording");
        }

        public void Play()
        {
            Console.WriteLine("Play record");
        }
    }
}