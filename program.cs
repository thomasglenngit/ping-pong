using System;
using Exercise.PingPong;

namespace Exercise
{
    class Program
    {
      static void Main()
      {
        Console.WriteLine("Please enter a positive integer: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        PongPing(number);
      }
    }
}