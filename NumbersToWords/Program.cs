using System;
using NumbersToWords.Models;

namespace NumbersToWords
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("enter a number that is between 0 and 18 quintillion");
      ulong number = UInt64.Parse(Console.Readline());

      Console.WriteLine(Words.Test(number));
    }// 18,446,744,073,709,551,615
  }
}