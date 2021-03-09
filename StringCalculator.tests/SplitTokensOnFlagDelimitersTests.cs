using NUnit.Framework;
using StringCalculatorLibrary.Interfaces;
using System.Collections.Generic;

namespace StringCalculator.tests
{
    [TestFixture]
    public class SplitTokensOnFlagDelimitersTests
    {
        private IStringSplitter _stringSplitter;

        [SetUp]
        public void Setup()
        {
            _stringSplitter = new StringCalculatorLibrary.StringConversions.SplitTokensOnFlagDelimiters();
        }

        [Test]
        public void Given_StringWithTokensAndOneCustomFlagDelimiter_When_SplittingTheStringWithFlagDelimiters_Then_Return_ListOfSplitTokens()
        {
            //Arrange
            const string numbers = "<(>)##(*)\n1*2*3";
            List<string> expectedResult = new List<string>() { "1", "2", "3" };

            //Act
            var result = _stringSplitter.SplitTokensOnDelimiters(numbers);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Given_StringWithTokensWithTwoFlagSeperators_When_SplittingTheStringWithFlagDelimiters_Then_Return_ListOfSplitTokens()
        {
            //Arrange
            const string numbers = "<[>}##[::}\n3::4::5";
            List<string> expectedResult = new List<string>() { "3", "4", "5" };

            //Act
            var result = _stringSplitter.SplitTokensOnDelimiters(numbers);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Given_StringWithTokensAndFlagSeperatorsAsDelimiter_When_SplittingTheStringWithFlagDelimiters_Then_Return_ListOfSplitTokens()
        {
            //Arrange
            const string numbers = "<>><##>&<\n4&5&6";
            List<string> expectedResult = new List<string>() { "4", "5", "6" };

            //Act
            var result = _stringSplitter.SplitTokensOnDelimiters(numbers);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Given_StringWithCustomFlagSeperatorsAndHashSepertaors_When_SplittingTheStringWithFlagDelimiters_Then_Return_ListOfSplitTokens()
        {
            //Arrange
            const string numbers = "<<>>##<$$$><###>\n5$$$6###7";
            List<string> expectedResult = new List<string>() { "5", "6", "7" };

            //Act
            var result = _stringSplitter.SplitTokensOnDelimiters(numbers);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
