using NUnit.Framework;
using System.Collections.Generic;
using StringCalculatorLibrary;

namespace StringCalculator.tests
{
    [TestFixture]
    public class NumberConverterTests
    {
        [Test]
        public void Given_ListWithNegativeAndPositiveNumbers_When_ConvertNegativeNumbersToPositives_Then_Return_ListOfPositiveNumbers()
        {
            //Arrange
            List<string> negativeNumbers = new List<string>() { "-5", "10", "-2", "7" };
            List<string> expectedResult = new List<string>() { "5", "10", "2", "7" };

            //Act
            var result = negativeNumbers.ConvertNegativesToPositives();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Given_ListWithNegativeNumbers_When_ConvertNegativeNumbersToPositives_Then_Return_ListOfPositiveNumbers()
        {
            //Arrange
            List<string> negativeNumbers = new List<string>() { "-5", "-10", "-2", "-7" };
            List<string> expectedResult = new List<string>() { "5", "10", "2", "7" };

            //Act
            var result = negativeNumbers.ConvertNegativesToPositives();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
