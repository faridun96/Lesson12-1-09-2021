using System;

namespace PlayerApp
{
   interface IPlayable
    {
        void Play(); 
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player : IPlayable , IRecodable
    {
        public void Pause()
        {
            Console.WriteLine("Песня на паузе");
        }

        public void Play()
        {
            Console.WriteLine("Песня играет");
        }

        public void Record()
        {
            Console.WriteLine("Запись песни");
        }

        public void Stop()
        {
            Console.WriteLine("Остановка песни");
        }
    }
	class Program
    {
        static void Main(string[] args)
        {
            IPlayable player = new Player();
            IRecodable recodable = new Player();
            recodable.Record();
            recodable.Pause();
            recodable.Stop();
            player.Play();
            player.Pause();
            player.Stop();
        }
    }
}