using System;

namespace SpatialGames
{
    class Program
    {
        
        //**
        //2D Array of strategy classes
        //
        static void Main(string[] args)
        {
            Test test = new Test();
            Split split = new Split(2,2,0);

            Console.WriteLine("Hello World");
            Console.WriteLine(test.getValue());
            Console.WriteLine(split.xCoor);
            split.xCoor = 5;
            Console.WriteLine(split.xCoor);
        }

    }
}