namespace Assignment
{
    using System;

    class BeerSong
    {
        public void SingSong(int startBottles)
        {
            for (int i = startBottles; i > 0; i--)
            {
                if (i > 1)
                {
                    Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.");
                    Console.WriteLine($"Take one down and pass it around, {i - 1} bottles of beer on the wall.\n");
                }
                else
                {
                    Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer.");
                    Console.WriteLine("Take one down and pass it around, no more bottles of beer on the wall.\n");
                }
            }
            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
            Console.WriteLine("Go to the store and buy some more, 99 bottles of beer on the wall.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BeerSong song = new BeerSong();
            song.SingSong(99);
        }
    }

}
