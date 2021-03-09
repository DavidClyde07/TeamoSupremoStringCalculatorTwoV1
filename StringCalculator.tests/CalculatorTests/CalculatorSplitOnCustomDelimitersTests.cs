using NUnit.Framework;
using StringCalculatorLibrary.Interfaces;
using StringCalculatorLibrary;
using NSubstitute;
using System.Collections.Generic;

namespace StringCalculator.tests.CalculatorTests
{
    [TestFixture]
    public class CalculatorSplitOnFCustomDelimiterTests
    {
        private ICalculator _calculator;
        private IStringSplitter _stringSplitter;
        private IConvertLetterToNumber _convertLetterToNumber;

        [SetUp]
        public void Setup()
        {
            _stringSplitter = Substitute.For<IStringSplitter>();
            _convertLetterToNumber = Substitute.For<IConvertLetterToNumber>();
            _calculator = new Calculator(_convertLetterToNumber, _stringSplitter);
        }


        [Test]
        [TestCase(-6,"##;\n1;2;3")]
        [TestCase(-6, "##***\n1***2***3")]
        [TestCase(-6, "##[***]\n1***2***3")]
        public void GIVEN_StringOfNumbersWithCustomDelimiters_WHEN_Subtracting_RETURN_NegativeSumOfNumbers(int expected, string input)
        {
            //Arrange
            _stringSplitter.SplitTokensOnDelimiters(input).Returns(new List<string>() { "1", "2", "3" });
            _convertLetterToNumber.ConvertListOfStringToListOfInt(new List<string>() { "1", "2", "3" }).ReturnsForAnyArgs(new List<int>() { 1, 2, 3 });

            //Act
            var result = _calculator.Subtract(input);
             
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(-6,"##[*][%]\n1*2%3")]
        [TestCase(-6,"##[**][%%%]\n1**2%%%3")]
        public void GIVEN_StringOfNumbersWithMultipleCustomDelimiters_WHEN_Subtracting_RETURN_NegativeSumOfNumbers(int expected, string input)
        {
            //Arrange
            _stringSplitter.SplitTokensOnDelimiters(input).Returns(new List<string>() { "1", "2", "3" });
            _convertLetterToNumber.ConvertListOfStringToListOfInt(new List<string>() { "1", "2", "3" }).ReturnsForAnyArgs(new List<int>() { 1, 2, 3 });

            //Act
            var result = _calculator.Subtract(input);
             
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}