using System;

namespace Lesson4_abstaction
{
    public class Player : IPlayable, IRecodable
    {
        private bool isRecording = false;

        public void Record()
        {
            isRecording = true;
            Console.WriteLine("Recording");
        }

        public void Pause()
        {
            if (isRecording)
            {
                Console.WriteLine("Pause recording");
            }
            else
            {
                Console.WriteLine("Pause video");
            }
        }

        public void Stop()
        {
            if (isRecording)
            {
                isRecording = false;
                Console.WriteLine("Stop recording");
            }
            else
            {
                Console.WriteLine("Stop video");
            }
        }

        public void Play()
        {
            Console.WriteLine("Play record");
        }
    }
}