using NUnit.Framework;
using StringCalculatorLibrary.Interfaces;
using StringCalculatorLibrary.StringConversions;
using System.Collections.Generic;

namespace StringCalculator.tests
{
    [TestFixture]
    public class SplitTokensOnCustomDelimitersTests
    {
        private IStringSplitter _stringSplitter;

        [SetUp]
        public void Setup()
        {
            _stringSplitter = new SplitTokensOnCustomDelimiters();
        }

        [Test]
        public void Given_StringWithTokensAndOneCustomDelimiter_When_SplittingTheStringWithCustomDelimiters_Then_Return_ListOfSplitTokens()
        {
            //Arrange
            const string numbers = "##;\n1;2";
            List<string> expectedResult = new List<string>() { "1", "2" };

            //Act
            var result = _stringSplitter.SplitTokensOnDelimiters(numbers);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Given_StringWithTokensWithALongLenghtCustomDelimiter_When_SplittingTheStringWithCustomDelimiters_Then_Return_ListOfSplitTokens()
        {
            //Arrange
            const string numbers = "##[***]\n1***2***3";
            List<string> expectedResult = new List<string>() { "1", "2", "3" };

            //Act
            var result = _stringSplitter.SplitTokensOnDelimiters(numbers);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Given_StringWithTokensAndTwoCustomDelimiter_When_SplittingTheStringWithCustomDelimiters_Then_Return_ListOfSplitTokens()
        {
            //Arrange
            const string numbers = "##[*][%]\n1*2%3";
            List<string> expectedResult = new List<string>() { "1", "2", "3" };

            //Act
            var result = _stringSplitter.SplitTokensOnDelimiters(numbers);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
