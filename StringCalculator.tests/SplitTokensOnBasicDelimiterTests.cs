using NUnit.Framework;
using StringCalculatorLibrary.Interfaces;
using StringCalculatorLibrary.StringConversions;
using System.Collections.Generic;

namespace StringCalculator.tests
{
    [TestFixture]
    public class SplitTokensOnBasicDelimiterTests
    {
        private IStringSplitter _stringSplitter;

        [SetUp]
        public void Setup()
        {
            _stringSplitter = new SplitTokensOnBasicDelimiters();
        }

        [Test]
        public void Given_StringWithTokensAndCommaDelimiter_When_SplittingTheStringWithBasicDelimiters_Then_Return_ListOfSplitTokens()
        {
            //Arrange
            const string numbers = "1,2";
            List<string> expectedResult = new List<string>() { "1", "2" };

            //Act
            var result = _stringSplitter.SplitTokensOnDelimiters(numbers);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Given_StringWithTokensWithNewLineDelimiter_When_SplittingTheStringWithBasicDelimiters_Then_Return_ListOfSplitTokens()
        {
            //Arrange
            const string numbers = "1\n2";
            List<string> expectedResult = new List<string>() { "1", "2" };

            //Act
            var result = _stringSplitter.SplitTokensOnDelimiters(numbers);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Given_StringWithManyTokensAndTwoBasicDelimiters_When_SplittingTheStringWithBasicDelimiters_Then_Return_ListOfSplitTokens()
        {
            //Arrange
            const string numbers = "1\n2,3";
            List<string> expectedResult = new List<string>() { "1", "2", "3" };

            //Act
            var result = _stringSplitter.SplitTokensOnDelimiters(numbers);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
