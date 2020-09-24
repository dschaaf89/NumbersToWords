using System;
using System.Numerics;
using NumbersToWords.Models;

namespace NumbersToWords
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("enter a number that is between 0 and 18 quintillion");
      BigInteger number = BigInteger.Parse(Console.ReadLine());

      Console.WriteLine(Words.test(number));

      // BigInteger number1 = BigInteger.Pow(UInt64.MaxValue, 3);
      // Console.WriteLine(number1);
// The example displays the following output:
//    6277101735386680762814942322444851025767571854389858533375
    }// 18,446,744,073,709,551,615
  }
}



