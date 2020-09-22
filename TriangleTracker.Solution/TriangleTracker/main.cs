using System;
using TriangleTracker;


namespace Main
{
  public class Program
  {
    public static void Main()
    {

      // Console.WriteLine("Enter three numbers and find out what type of triangle you have.");
      // string inputSide1 = Console.ReadLine();
      // string inputSide2 = Console.ReadLine();
      // string inputSide3 = Console.ReadLine();
      // int side1 = int.Parse(inputSide1);
      // int side2 = int.Parse(inputSide2);
      // int side3 = int.Parse(inputSide3);
      // Console.WriteLine(Triangle.TriangleType(side1, side2, side3));

      Console.WriteLine("Enter three numbers and find out what type of triangle you have.");
      string line;
      while ((line = Console.ReadLine()) != "x")
      {
        string[] s = line.Split(" ");
        Console.WriteLine(Triangle.TriangleType(int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2])));
      }

    }
  }
}