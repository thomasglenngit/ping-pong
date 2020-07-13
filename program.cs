using System;

namespace Exercise
{
    public class Program
    {
      public static void Main()
      {
        Console.WriteLine("Please enter a positive integer greater than 0: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        PingPong.PongPing(number);
      }
    }
}