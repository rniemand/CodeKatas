using NUnit.Framework;

namespace StringCalculatorTests
{
  [TestFixture]
  public class StringCalculatorTests
  {
    [Test]
    public void Constructor_GivenCalled_ShouldCreateNewStringCalculator()
    {
      // arrange
      // act
      var calculator = new StringCalculator();

      // assert
      Assert.IsNotNull(calculator);
    }

    [Test]
    public void Add_GivenEmptyString_ShouldReturn0()
    {
      // arrange
      var expected = 0;
      var calculator = GetCalculator();

      // act
      var result = calculator.Add("");

      // assert
      Assert.AreEqual(expected, result);
    }

    [TestCase("1", 1)]
    [TestCase("2", 2)]
    [TestCase("99", 99)]
    public void Add_GivenSingleNuber_ShouldReturnNumber(string numbers, int expected)
    {
      // arrange
      var calculator = GetCalculator();

      // act
      var result = calculator.Add(numbers);

      // assert
      Assert.AreEqual(expected, result);
    }

    [TestCase("5,5", 10)]
    [TestCase("5,10", 15)]
    [TestCase("99,100", 199)]
    public void Add_GivenTwoNumbers_ShouldReturnTheirSum(string numbers, int expected)
    {
      // arrange
      var calculator = GetCalculator();

      // act
      var result = calculator.Add(numbers);

      // assert
      Assert.AreEqual(expected, result);
    }

    [TestCase("1,2,3", 6)]
    [TestCase("1,2,3,4", 10)]
    [TestCase("1,2,3,4,5", 15)]
    public void Add_GivenUnknownAmountOfNumber_ShouldReturnSumOfAllNumbers(string numbers, int expected)
    {
      // arrange
      var calculator = GetCalculator();

      // act
      var result = calculator.Add(numbers);

      // assert
      Assert.AreEqual(expected, result);
    }

    [TestCase("1\n2\n3", 6)]
    [TestCase("1\n2\n3\n4", 10)]
    public void Add_GivenNewLineDelimiters_ShouldReturnSumOfNumbers(string numbers, int expected)
    {
      // arrange
      var calculator = GetCalculator();

      // act
      var result = calculator.Add(numbers);

      // assert
      Assert.AreEqual(expected, result);
    }

    [TestCase("1\n2,3", 6)]
    [TestCase("1\n2,3\n4", 10)]
    public void Add_GivenMultipleDelimiters_ShouldReturnSumOfNumbers(string numbers, int expected)
    {
      // arrange
      var calculator = GetCalculator();

      // act
      var result = calculator.Add(numbers);

      // assert
      Assert.AreEqual(expected, result);
    }

    // Helpers
    private static StringCalculator GetCalculator()
    {
      return new StringCalculator();
    }
  }
}
