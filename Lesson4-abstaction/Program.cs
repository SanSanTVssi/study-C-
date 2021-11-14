using System;

namespace Lesson4_abstaction
{
    class Program
    {
        static void DocumentProcessing(AbstractHandler handler)
        {
            handler.Chenge();
            handler.Create();
            handler.Open();
            handler.Save();
        }

        static void Record(IRecodable player)
        {
            player.Record();
            player.Pause();
            player.Stop();
        }
        
        static void Play(IPlayable player)
        {
            player.Play();
            player.Pause();
            player.Stop();
        }
        
        static void Main(string[] args)
        {
            // Task 2
            DocumentProcessing(new DOCHandler());
            DocumentProcessing(new TXTHandler());
            DocumentProcessing(new XMLHandler());
         
            //Task 3
            Player player = new Player();
            Record(player);
            Play(player);
        }
    }
}