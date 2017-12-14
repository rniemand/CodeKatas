using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorTests
{
  public class StringCalculator
  {
    public int Add(string numbers)
    {
      return !string.IsNullOrWhiteSpace(numbers)
        ? AddNumbers(numbers)
        : 0;
    }

    private static int AddNumbers(string numbers)
    {
      var extractedNumbers = GetNumbers(numbers);

      return extractedNumbers.Sum();
    }

    private static IEnumerable<int> GetNumbers(string numbers)
    {
      var delimiters = new[] { ",", "\n" };

      var extractedNumbers = numbers
        .Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

      return extractedNumbers.Select(int.Parse).ToArray();
    }
  }
}