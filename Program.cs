using System;

namespace Lab2Sharp
{
    abstract class Musician
    {
        public string Name { get; set; }
        public string Specializathion { get; set; }
        public string[] Repertoir { get; set; }
        public readonly int DateOfBerth;
        static readonly protected int date = DateTime.Now.Year;

        protected abstract void LearnNewSong();
        public abstract void GetInfo();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}